using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRK {
    public class PlacesLiveView : View<List<LivePlace>> {

        public PlacesLiveView(TabPage page) : base("placesLive", page) {
        }

        protected override void LoadData() {
            Logger.Log("Loading data...");

            Task.Run(Core.Instance.GetLivePlaces).ContinueWith(x => {
                Logger.Log("Found " + x.Result.Count + " places");

                m_CachedData = x.Result;
                Runnable.RunOnUIThread(() => {
                    foreach (LivePlace place in x.Result) {
                        ListViewItem viewItem = new(place.CID);
                        viewItem.SubItems.Add(place.Name);
                        viewItem.SubItems.Add(place.Type);
                        viewItem.SubItems.Add(place.Chain.ToString());
                        AddListViewItem(viewItem);
                    }
                });
            });
        }
    }
}
