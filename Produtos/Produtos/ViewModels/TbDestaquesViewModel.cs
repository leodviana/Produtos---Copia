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
    public class TbDestaquesViewModel : BindableBase
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
        public TbDestaquesViewModel(INavigationService navigationService)
        {
            //GoToCommand = new DelegateCommand(()=> Abre_pesquisa());
            Destaques = new ObservableCollection<Destaque>();
            carrega();
            LoadMenu();

            _navigationService = navigationService;
        }


        readonly INavigationService _navigationService;

        public ObservableCollection<Destaque> Destaques { get; set; }
        public List<Destaque> ListaDestaques;

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

            Destaques.Clear();
            // ListaEspecialidades.OrderBy(x => x.Descricao);
            if (ProductFilter.Trim().Length > 0)
            {

                foreach (var item in ListaDestaques.Where(x => x.Nome.ToUpper().Contains(ProductFilter.ToUpper())).OrderBy(x => x.Nome))
                {
                    Destaques.Add(new Destaque()
                    {
                        Nome = item.Nome,
                        Foto = item.Foto,
                        // Endereco = item.Endereco
                    });
                }
            }
            else
            {
                foreach (var item in ListaDestaques.OrderBy(x => x.Nome))
                {
                    Destaques.Add(new Destaque()
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

            ListaDestaques = new List<Destaque>();
            Destaque item01 = new Destaque()
            {
                Nome = "Carlo Danilo",
                Foto = "destaque",
                //Endereco = ""
            };
            ListaDestaques.Add(item01);

            Destaque item02 = new Destaque()
            {
                Nome = "Leonardo Viana",
                Foto = "destaque",
                //Endereco =""
            };
            ListaDestaques.Add(item02);

            Destaque item03 = new Destaque()
            {
                Nome = "Caio Daniel",
                Foto = "destaque",
                //Endereco =""
            };
            ListaDestaques.Add(item03);

 

        }

    }
}

