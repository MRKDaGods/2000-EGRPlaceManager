using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRK {
    public abstract class View {
        readonly TextBox m_SearchBox;
        protected readonly ListView m_ListView;

        public View(string viewName, TabPage page) {
            m_SearchBox = (TextBox)page.Controls.Find($"{viewName}SearchTextbox", false)[0];
            m_ListView = (ListView)page.Controls.Find($"{viewName}ListView", false)[0];
        }

        public void ReloadData() {
            m_ListView.Items.Clear();

            LoadData();
        }

        /// <summary>
        /// Used to insert data into m_ListView
        /// </summary>
        protected abstract void LoadData();
    }
}
