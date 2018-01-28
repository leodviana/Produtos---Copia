using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prism.Navigation;
using Xamarin.Forms;
using Produtos.Model;
using MenuItem = Produtos.Model.MenuItem;


namespace Produtos.ViewModels
{
    public class MasterPageViewModel : BindableBase
    {

        private INavigationService NavigationService { get; }

        private bool isPresented;

        public bool IsPresented
        {
            get { return this.isPresented; }
            set { this.SetProperty(ref this.isPresented, value); }
        }

        public MasterPageViewModel(INavigationService navigationService)
        {
            this.NavigationService = navigationService;
            //LoadMenu();
        }

        public async Task PageChangeAsync(MenuItem menuItem)
        {
            await this.NavigationService.NavigateAsync($"NavigationPage/{menuItem.PageName}");
            this.IsPresented = false;
        }
    }
}
