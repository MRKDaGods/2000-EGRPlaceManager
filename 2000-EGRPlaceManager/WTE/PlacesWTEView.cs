using MRK.WTE;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRK {
    public class PlacesWTEView : View<Context> {
        public PlacesWTEView(TabPage page) : base("placesWTE", page) {
        }

        protected override void LoadData() {
            Logger.Log("Loading data...");

            Task.Run(Core.Instance.GetWTEContext).ContinueWith(x => {
                m_CachedData = x.Result;

                Logger.Log($"Found WTE database {m_CachedData.Name}");

                m_CachedData = x.Result;
                Runnable.RunOnUIThread(() => {
                    foreach (Place place in m_CachedData.Places) {
                        ListViewItem viewItem = new(place.CID.ToString());
                        viewItem.SubItems.Add(place.Name);
                        viewItem.Tag = place;
                        AddListViewItem(viewItem);
                    }
                });
            });
        }
        protected override void SaveDataInternal()
        {
            Logger.Log("attempting to save WTE  places");
            if (m_CachedItems == null || m_CachedItems.Count == 0)
            {
                Logger.Log("no cached items");
                return;
            }
           
            foreach (ListViewItem item in m_CachedItems)
            {
                Place p = (Place)item.Tag;
                p.Name = item.SubItems[1].Text;
                p.CID = ulong.Parse(item.SubItems[0].Text);
            }
            Core.Instance.SaveWTEContext(m_CachedData);


        }
    }
}
