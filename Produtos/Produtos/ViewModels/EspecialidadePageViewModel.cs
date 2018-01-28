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
    public class EspecialidadePageViewModel : BindableBase
    {

        private string _ProductFilter = "";

        public string ProductFilter
        {
            get { return _ProductFilter; }
            set
            {
                SetProperty(ref _ProductFilter, value);
                LoadMenu();
            }
        }
        readonly INavigationService _navigationService;
        public EspecialidadePageViewModel(INavigationService navigationService)
        {
            Especialidades = new ObservableCollection<Especialidade>();
            carrega();
            LoadMenu();
            
            _navigationService = navigationService;
            
        }
        public ObservableCollection<Especialidade> Especialidades { get; set; }
        public List<Especialidade> ListaEspecialidades;

        public DelegateCommand GoToCommand => new DelegateCommand(Abre_pesquisa);
        //MyCommand = new DelegateCommand(async () => await MyJobAsync());


        private void Abre_pesquisa()
        {
            _navigationService.NavigateAsync("PesquisaPage", useModalNavigation: true);
        }
        /*   private void LoadMenu()
           {

               Especialidades = new ObservableCollection<Especialidade>
               {
                   new Especialidade()
                   {
                       Icon = "especialidade",
                       Descricao = "Fisioterapia",

                   },
                   new Especialidade()
                   {
                       Icon = "especialidade",
                       Descricao = "Cardiologia",

                   },
                   new Especialidade()
                   {
                       Icon = "especialidade",
                       Descricao = "Clinica Geral",

                   },
                   new Especialidade()
                   {
                       Icon = "especialidade",
                       Descricao = "Urologia",

                   },
                   new Especialidade()
                   {
                       Icon = "especialidade",
                       Descricao = "Traumatologia",

                   },
                   new Especialidade()
                   {
                       Icon = "especialidade",
                       Descricao = "Geriatria",

                   },
                   new Especialidade()
                   {
                       Icon = "especialidade",
                       Descricao = "Pediatria",

                   },
                   new Especialidade()
                   {
                       Icon = "especialidade",
                       Descricao = "Oftalmologia",

                   },
                   new Especialidade()
                   {
                       Icon = "especialidade",
                       Descricao = "Neurocirurgia",

                   },
                   new Especialidade()
                   {
                       Icon = "especialidade",
                       Descricao = "Nefrologia",

                   },
               };



           }*/
        private void LoadMenu()
        {
           
           
            
            Especialidades.Clear();
            // ListaEspecialidades.OrderBy(x => x.Descricao);
            if (ProductFilter.Trim().Length > 0)
            {
                foreach (var item in ListaEspecialidades.Where(x => x.Descricao.ToUpper().Contains(ProductFilter.ToUpper())).OrderBy(x => x.Descricao))
                {
                    Especialidades.Add(new Especialidade()
                    {
                        Icon = item.Icon,
                        Descricao = item.Descricao,

                    });
                }
            }
            else
            {
                foreach (var item in ListaEspecialidades.OrderBy(x => x.Descricao))
                {
                    Especialidades.Add(new Especialidade()
                    {
                        Icon = item.Icon,
                        Descricao = item.Descricao,

                    });
                }
            }
        }
        public void carrega()
        {

            ListaEspecialidades = new List<Especialidade>();
            Especialidade item01 = new Especialidade()
            {
                 Icon = "especialidade",
                 Descricao = "Fisioterapia",
            };
            ListaEspecialidades.Add(item01);

            Especialidade item02 = new Especialidade()
            {
                Icon = "especialidade",
                Descricao = "Cardiologia",
            };
            ListaEspecialidades.Add(item02);

            Especialidade item03 = new Especialidade()
            {
                Icon = "especialidade",
                Descricao = "Clinica Geral",
            };
            ListaEspecialidades.Add(item03);

            Especialidade item04 = new Especialidade()
            {
                Icon = "especialidade",
                Descricao = "Urologia",
            };
            ListaEspecialidades.Add(item04);

            Especialidade item05 = new Especialidade()
            {
                Icon = "especialidade",
                Descricao = "Traumatologia",
            };
            ListaEspecialidades.Add(item05);

            Especialidade item06 = new Especialidade()
            {
                Icon = "especialidade",
                Descricao = "Geriatria",
            };
            ListaEspecialidades.Add(item06);

            Especialidade item07 = new Especialidade()
            {
                Icon = "especialidade",
                Descricao = "Pediatria",
            };
            ListaEspecialidades.Add(item07);

            Especialidade item08 = new Especialidade()
            {
                Icon = "especialidade",
                Descricao = "Oftalmologia",
            };
            ListaEspecialidades.Add(item08);

            Especialidade item09 = new Especialidade()
            {

                Icon = "especialidade",
                Descricao = "Nefrologia",
            };
            ListaEspecialidades.Add(item09);

            Especialidade item10 = new Especialidade()
            {

                Icon = "especialidade",
                Descricao = "Endoscopia",
            };
            ListaEspecialidades.Add(item10);
            Especialidade item11 = new Especialidade()
            {

                Icon = "especialidade",
                Descricao = "Pneumologia",
            };
            ListaEspecialidades.Add(item11);
            Especialidade item12 = new Especialidade()
            {

                Icon = "especialidade",
                Descricao = "Radiologia",
            };
            ListaEspecialidades.Add(item12);

            Especialidade item13 = new Especialidade()
            {

                Icon = "especialidade",
                Descricao = "Cirurgia Geral",
            };
            ListaEspecialidades.Add(item13);
            Especialidade item14 = new Especialidade()
            {

                Icon = "especialidade",
                Descricao = "Radioterapia",
            };
            ListaEspecialidades.Add(item14);
        }



    }
}
