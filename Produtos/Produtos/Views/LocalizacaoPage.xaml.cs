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
            MyMap = LocalizacaoPageViewModel.MyMap;
            

        }
    }
}
