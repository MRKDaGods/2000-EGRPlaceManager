using System;
using System.Drawing;
using System.Windows.Forms;

namespace MRK {
    public class EditableListView {
        class ScrollListener : NativeWindow, IDisposable {
            const uint WM_HSCROLL = 0x114;
            const uint WM_VSCROLL = 0x115;
            const uint WM_MOUSEWHEEL = 0x020A;

            Control m_Control;

            public event EventHandler ControlScrolled;

            protected bool Disposed { get; set; }

            public ScrollListener(Control control) {
                m_Control = control;
                AssignHandle(control.Handle);
            }

            public void Dispose() {
                Dispose(true);
            }

            void Dispose(bool disposing) {
                if (Disposed)
                    return;

                ReleaseHandle();
                Disposed = true;
            }

            protected override void WndProc(ref Message m) {
                if (m.Msg == WM_HSCROLL || m.Msg == WM_VSCROLL || m.Msg == WM_MOUSEWHEEL) {
                    if (ControlScrolled != null) {
                        ControlScrolled(m_Control, EventArgs.Empty);
                    }
                }
                
                base.WndProc(ref m);
            }
        }

        ListViewItem.ListViewSubItem m_SelectedSubItem;
        readonly ListView m_ListView;
        readonly TextBox m_Textbox;
        readonly ScrollListener m_ScrollListener;

        public EditableListView(ListView lv) {
            m_ListView = lv;

            m_Textbox = new TextBox {
                BackColor = Color.Black,
                ForeColor = Color.White,
            };
            m_Textbox.Hide();
            m_ListView.Controls.Add(m_Textbox);

            m_ListView.MouseUp += OnListViewMouseUp;
            m_ListView.MouseDown += OnListViewMouseDown;

            m_Textbox.Leave += OnTextboxLeave;
            m_Textbox.KeyUp += OnTextboxKeyUp;

            //fixups?
            m_ScrollListener = new ScrollListener(m_ListView);
            m_ScrollListener.ControlScrolled += OnListViewScroll;
        }

        void OnListViewMouseUp(object? sender, MouseEventArgs e) {
            ListViewHitTestInfo i = m_ListView.HitTest(e.X, e.Y);
            m_SelectedSubItem = i.SubItem;
            if (m_SelectedSubItem == null)
                return;

            int border = 0;
            switch (m_ListView.BorderStyle) {
                case BorderStyle.FixedSingle:
                    border = 1;
                    break;
                case BorderStyle.Fixed3D:
                    border = 2;
                    break;
            }

            int CellWidth = m_SelectedSubItem.Bounds.Width;
            int CellHeight = m_SelectedSubItem.Bounds.Height;
            int CellLeft = border + /*m_ListView.Left +*/ i.SubItem.Bounds.Left;
            int CellTop = /*m_ListView.Top + */i.SubItem.Bounds.Top;
            // First Column
            if (i.SubItem == i.Item.SubItems[0])
                CellWidth = m_ListView.Columns[0].Width;

            m_Textbox.Show();
            m_Textbox.Location = new Point(CellLeft, CellTop);
            m_Textbox.Size = new Size(CellWidth, CellHeight);
            m_Textbox.Visible = true;
            m_Textbox.BringToFront();
            m_Textbox.Text = i.SubItem.Text;
            m_Textbox.Select();
            m_Textbox.SelectAll();
        }

        void OnListViewMouseDown(object? sender, MouseEventArgs e) {
            HideTextEditor();
        }

        void OnListViewScroll(object? sender, EventArgs e) {
            HideTextEditor();
        }

        void OnTextboxLeave(object? sender, EventArgs e) {
            HideTextEditor();
        }

        void OnTextboxKeyUp(object? sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
                HideTextEditor();
        }

        void HideTextEditor() {
            m_Textbox.Visible = false;
            if (m_SelectedSubItem != null)
                m_SelectedSubItem.Text = m_Textbox.Text;

            m_SelectedSubItem = null;
            m_Textbox.Text = string.Empty;
        }
    }
}
