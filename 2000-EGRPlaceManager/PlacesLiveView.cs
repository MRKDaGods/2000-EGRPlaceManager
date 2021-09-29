using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRK {
    public class PlacesLiveView : View {
        public PlacesLiveView(TabPage page) : base("placesLive", page) {
        }

        protected override void LoadData() {
            Logger.Log("Loading data...");

            Task.Run(Core.Instance.GetLivePlaces).ContinueWith(x => {
                Logger.Log("Found " + x.Result.Count + " places");

                Runnable.RunOnUIThread(() => {
                    foreach (LivePlace place in x.Result) {
                        ListViewItem viewItem = new(place.Name);
                        viewItem.SubItems.Add(place.CID);
                        m_ListView.Items.Add(viewItem);
                    }
                });
            });
        }
    }
}
