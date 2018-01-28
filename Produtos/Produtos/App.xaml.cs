using Prism.Unity;
using Produtos.Views;
using Xamarin.Forms;

namespace Produtos
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            // NavigationService.NavigateAsync("NavigationPage/MainPage?title=Hello%20from%20Xamarin.Forms");
             await this.NavigationService.NavigateAsync("/MasterPage/NavigationPage/RamoAtivadePage");
           // await this.NavigationService.NavigateAsync("LoginPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<MenuPage>();
            Container.RegisterTypeForNavigation<MasterPage>();
            Container.RegisterTypeForNavigation<UserPage>();
            Container.RegisterTypeForNavigation<teste>();
            Container.RegisterTypeForNavigation<CustomerPage>();
            Container.RegisterTypeForNavigation<LoginPage>();
            Container.RegisterTypeForNavigation<EspecialidadePage>();
           Container.RegisterTypeForNavigation<Especialidades01Page>();
            Container.RegisterTypeForNavigation<ProfissionalPage>();
            Container.RegisterTypeForNavigation<TbProfissionaisPage>();
            Container.RegisterTypeForNavigation<ProfissionalPesquisaPage>();
            Container.RegisterTypeForNavigation<TbTitulos>();
            Container.RegisterTypeForNavigation<TbPacientes>();
            Container.RegisterTypeForNavigation<TbDestaques>();
            Container.RegisterTypeForNavigation<TbAjuda>();
            Container.RegisterTypeForNavigation<TbSobrePage>();
            Container.RegisterTypeForNavigation<ProfissionaisPage02>();
            Container.RegisterTypeForNavigation<ConvenioPage>();
            Container.RegisterTypeForNavigation<PesquisaPage>();
            Container.RegisterTypeForNavigation<RamoAtivadePage>();
            Container.RegisterTypeForNavigation<LocalizacaoPage>();
        }
    }
}
