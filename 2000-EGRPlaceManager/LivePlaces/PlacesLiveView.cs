using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRK
{
    public class PlacesLiveView : View<List<LivePlace>>
    {

        public PlacesLiveView(TabPage page) : base("placesLive", page)
        {
        }

        protected override void LoadData()
        {
            Logger.Log("Loading data...");

            Task.Run(Core.Instance.GetLivePlaces).ContinueWith(x =>
            {
                Logger.Log("Found " + x.Result.Count + " places");

                m_CachedData = x.Result;
                Runnable.RunOnUIThread(() =>
                {
                    foreach (LivePlace place in x.Result)
                    {
                        ListViewItem viewItem = new(place.CID);
                        viewItem.SubItems.Add(place.Name);
                        viewItem.SubItems.Add(place.Type);
                        viewItem.SubItems.Add(place.Chain.ToString());
                        viewItem.Tag = place;
                        AddListViewItem(viewItem);
                    }
                });
            });
        }

        protected override void SaveDataInternal()
        {
            Logger.Log("attempting to save live places");
            if (m_CachedItems == null || m_CachedItems.Count == 0)
            {
                Logger.Log("no cached items");
                return;
            }
            foreach (ListViewItem item in m_CachedItems)
            {

                LivePlace place = (LivePlace)item.Tag;
                place.Name = item.SubItems[1].Text;
                place.CID = item.SubItems[0].Text;
                place.Type = item.SubItems[2].Text;
                place.Chain = ulong.Parse(item.SubItems[3].Text);
                Core.Instance.SavePlace(place);
            }

        }
    }
}
