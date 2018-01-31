using Plugin.Geolocator;
using Produtos.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace Produtos.Views
{
    public partial class LocalizacaoPage : ContentPage
    {
        public LocalizacaoPage()
        {
            InitializeComponent();
            //MyMap = LocalizacaoPageViewModel.MyMap;
          //  getLocations();

        }

        private async void getLocations()
        {
            var locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 50;

            //var location = await locator.GetPositionAsync(TimeSpan.FromSeconds(20), null, true);
            var location = await locator.GetPositionAsync();
            var position = new Position(location.Latitude, location.Longitude);
            MyMap.MoveToRegion(MapSpan.FromCenterAndRadius(position, Distance.FromKilometers(.3)));
        }
    }
}
