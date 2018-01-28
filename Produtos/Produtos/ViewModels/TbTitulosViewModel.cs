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
    public class TbTitulosViewModel : BindableBase
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
        public TbTitulosViewModel(INavigationService navigationService)
        {
            //GoToCommand = new DelegateCommand(()=> Abre_pesquisa());
            Titulos = new ObservableCollection<Titulo>();
            carrega();
            LoadMenu();

            _navigationService = navigationService;
        }


        readonly INavigationService _navigationService;

        public ObservableCollection<Titulo> Titulos { get; set; }
        public List<Titulo> ListaTitulos;

        public DelegateCommand PesquisaCommand => new DelegateCommand(Pesquisa_convenio);

        public DelegateCommand GoToCommand => new DelegateCommand(Abre_pesquisa);
        //MyCommand = new DelegateCommand(async () => await MyJobAsync());


        private void Abre_pesquisa()
        {
            _navigationService.NavigateAsync("PesquisaPage", useModalNavigation: true);
        }

        private void Pesquisa_convenio()
        {


        }

        private void LoadMenu()
        {

            Titulos.Clear();
            // ListaEspecialidades.OrderBy(x => x.Descricao);
            if (ProductFilter.Trim().Length > 0)
            {

                foreach (var item in ListaTitulos.Where(x => x.Nome.ToUpper().Contains(ProductFilter.ToUpper())).OrderBy(x => x.Nome))
                {
                    Titulos.Add(new Titulo()
                    {
                        Nome = item.Nome,
                        Foto = item.Foto,
                        // Endereco = item.Endereco
                    });
                }
            }
            else
            {
                foreach (var item in ListaTitulos.OrderBy(x => x.Nome))
                {
                    Titulos.Add(new Titulo()
                    {
                        Nome = item.Nome,
                        Foto = item.Foto,
                        // Endereco = item.Endereco
                    });
                }

            }

        }
        public void carrega()
        {

            ListaTitulos = new List<Titulo>();
            Titulo item01 = new Titulo()
            {
                Nome = "Mestrado",
                Foto = "titulos",
                //Endereco = ""
            };
            ListaTitulos.Add(item01);

            Titulo item02 = new Titulo()
            {
                Nome = "Especialização",
                Foto = "titulos",
                //Endereco =""
            };
            ListaTitulos.Add(item02);

            Titulo item03 = new Titulo()
            {
                Nome = "Doutorado",
                Foto = "titulos",
                //Endereco =""
            };
            ListaTitulos.Add(item03);

            Titulo item04 = new Titulo()
            {
                Nome = "Aperfeiçoamento",
                Foto = "titulos",
                //Endereco =""
            };
            ListaTitulos.Add(item04);

            Titulo item05 = new Titulo()
            {
                Nome = "Pos-doctor",
                Foto = "titulos",
                //Endereco =""
            };
            ListaTitulos.Add(item05);
        }

    }
}

