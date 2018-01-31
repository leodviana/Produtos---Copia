using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Plugin.Geolocator;
using Xamarin.Forms.Maps;

namespace Produtos.ViewModels
{
    public class LocalizacaoPageViewModel : BindableBase
    {
        public  static Map MyMap;
        public ObservableCollection<Pin> Pins { get; set; }
        public LocalizacaoPageViewModel()
        {
            MyMap = new Map();
            Pins = new ObservableCollection<Pin>();
            GetGeolocation();
            foreach (Pin item in Pins)
            {
                MyMap.Pins.Add(item);
            }

            Locator();

        }
        public void GetGeolocation()
        {
            var position1 = new Position(-3.729680, -38.508561);
            var pin1 = new Pin
            {
                Type = PinType.Place,
                Position = position1,
                Label = "Pin1",
                Address = "Local Pino 01"
            };
            Pins.Add(pin1);

            var position2 = new Position(-18.753730, -44.430406);
            var pin2 = new Pin
            {
                Type = PinType.Place,
                Position = position2,
                Label = "Pin2",
                Address = "Local Pino 02"
            };
            Pins.Add(pin2);

            var position3 = new Position(-12.971687, -38.475612);
            var pin3 = new Pin
            {
                Type = PinType.Place,
                Position = position3,
                Label = "Pin3",
                Address = "Local Pino 03"
            };
            Pins.Add(pin3);
        }


        private async void Locator()
        {
            var locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 50;

            //var location = await locator.GetPositionAsync(TimeSpan.FromSeconds(20), null, true);
            var location = await locator.GetPositionAsync();
            var position = new Position(location.Latitude,location.Longitude);
            MyMap.MoveToRegion(MapSpan.FromCenterAndRadius(position,Distance.FromKilometers(.3)));
        }
    }
}
