using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FuzzySharp;

namespace MRK {
    public abstract class View<T> : IView {
        readonly TextBox m_SearchBox;
        protected readonly ListView m_ListView;
        readonly ComboBox m_SearchComboBox;
        EditableListView m_EditableListView;
        protected T m_CachedData;
        protected List<ListViewItem> m_CachedItems;
        readonly ListViewItem m_SearchItem;
        CancellationTokenSource m_CancellationTokenSource;

        public View(string viewName, TabPage page) {
            m_SearchBox = (TextBox)page.Controls.Find($"{viewName}SearchTextbox", false)[0];
            m_ListView = (ListView)page.Controls.Find($"{viewName}ListView", false)[0];

            //always have the first item as def
            m_SearchComboBox = (ComboBox)page.Controls.Find($"{viewName}SearchComboBox", false)[0];
            m_SearchComboBox.Items.Clear();

            m_SearchItem = new ListViewItem();
            foreach (ColumnHeader column in m_ListView.Columns) {
                m_SearchComboBox.Items.Add(column.Text);

                m_SearchItem.SubItems.Add("-");
            }

            m_SearchComboBox.SelectedIndex = 0;

            ((Button)page.Controls.Find($"{viewName}SearchButton", false)[0]).Click += (_, _) => Search();

            m_EditableListView = new EditableListView(m_ListView);

            m_SearchBox.TextChanged += OnSearchBoxChanged;

            m_CachedItems = new List<ListViewItem>();
        }

        void ClearCurrentListViewItems(bool clearCache = true) {
            if (clearCache) {
                m_CachedItems.Clear();
            }

            m_ListView.Items.Clear();
        }

        protected void AddListViewItem(ListViewItem item, bool cache = true) {
            if (cache) {
                m_CachedItems.Add(item);
            }

            m_ListView.Items.Add(item);
        }

        void Search() {
            if (m_CachedData == null) {
                return;
            }

            if (string.IsNullOrEmpty(m_SearchBox.Text)) {
                ClearCurrentListViewItems(false);
                LoadCachedData();
                return;
            }

            Func<ListViewItem, string> processor;

            int searchIdx = m_SearchComboBox.SelectedIndex;
            string searchTxt = m_SearchBox.Text;
            //Name
            if (searchIdx == 0) {
                m_SearchItem.Text = searchTxt;
                processor = (item) => item.Text;
            }
            else {
                m_SearchItem.SubItems[searchIdx].Text = searchTxt;
                processor = (item) => item.SubItems[searchIdx].Text;
            }

            if (m_CancellationTokenSource != null) {
                m_CancellationTokenSource.Cancel(false);
            }

            m_CancellationTokenSource = new CancellationTokenSource();
            Task.Run(() => {
                var res = Process.ExtractSorted(m_SearchItem, m_CachedItems, processor);
                Runnable.RunOnUIThread(() => {
                    ClearCurrentListViewItems(false);

                    foreach (var item in res) {
                        AddListViewItem(item.Value, false);
                    }
                }, m_CancellationTokenSource.Token);
            }, m_CancellationTokenSource.Token);
        }

        void OnSearchBoxChanged(object? sender, EventArgs e) {
            if (Main.Instance.LiveSearchEnabled) {
                Search();
            }
        }

        public void ReloadData() {
            ClearCurrentListViewItems();
            LoadData();
        }

        /// <summary>
        /// Used to insert data into m_ListView
        /// </summary>
        protected abstract void LoadData();

        void LoadCachedData() {
            Logger.Log("Loading cached data...");

            foreach (ListViewItem item in m_CachedItems) {
                AddListViewItem(item, false);
            }
        }
    }
}
