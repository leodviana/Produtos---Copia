using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Prism.Navigation;
using Produtos.Model;

namespace Produtos.ViewModels
{
    public class MenuPageViewModel : BindableBase
    {
        readonly INavigationService _navigationService;


        private List<MenuItem> listaordenada;

        public DelegateCommand<MenuItem> NavigateCommand
        {
            get
            {
                return new DelegateCommand<MenuItem>((item) =>
                {
                    _navigationService.NavigateAsync("/MasterPage/NavigationPage/" + item.PageName);
                });

            }
        }
        public ObservableCollection<MenuItem> Menus { get; set; }


         
          private void LoadMenu()
        {

            Menus = new ObservableCollection<MenuItem>
            {
                new MenuItem()
                {
                    Icon = "atividade",
                    Title = "Atividades",
                    PageName = "RamoAtivadePage"
                },
                new MenuItem()
                {
                    Icon = "especialidade",
                    Title = "Especialidades",
                    PageName = "EspecialidadePage"
                },
                                   new MenuItem()
                {
                    Icon = "convenio",
                    Title = "Convenios",
                    PageName = "ConvenioPage"
                },
                                    new MenuItem()
                {
                    Icon = "titulos",
                    Title = "Titulos",
                    PageName = "TbTitulos"
                },
 new MenuItem()
                {
                    Icon = "destaque",
                    Title = "Destaques",
                    PageName = "TbDestaques"
                },
                new MenuItem()
                {
                    Icon = "profissional",
                    Title = "Profisionais",
                    PageName = "ProfissionalPage"
                },
               
                
               
                new MenuItem()
                {
                    Icon = "localizador",
                    Title = "Localizador",
                    PageName = "LocalizacaoPage"
                },

                   new MenuItem()
                {
                    Icon = "perfil",
                    Title = "Perfil",
                    PageName = "TbPacientes"
                },
                 new MenuItem()
                {
                    Icon = "ajuda",
                    Title = "Ajuda",
                    PageName = "TbAjuda"
                },
                  new MenuItem()
                {
                    Icon = "sobre",
                    Title = "Sobre",
                    PageName = "TbSobrePage"
                },
               
                    new MenuItem()
                {
                    Icon = "sair",
                    Title = "Sair",
                    PageName = "ConvenioPage"
                }
            };



        }

       

        public MenuPageViewModel(INavigationService navigationService)
        {
            LoadMenu();
            
            _navigationService = navigationService;
            // NavigateCommand = new DelegateCommand<MenuItem>(Navigate);
        }

        /*   private void Navigate(MenuItem)
           {
               //var x = args as MenuItem;

               _navigationService.NavigateAsync("/RootPage/NavigationPage/"  +MenuItem.);

           }*/
    }
}

