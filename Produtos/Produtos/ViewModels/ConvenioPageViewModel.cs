using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using Prism.Navigation;
using Produtos.Model;
using Produtos.Views;

namespace Produtos.ViewModels
{
    public class ConvenioPageViewModel : BindableBase
    {

        private string _ProductFilter ="";

        public string ProductFilter
        {
            get { return _ProductFilter; }
            set
            {
                SetProperty(ref _ProductFilter, value);
                LoadMenu();
            }
        }

        public ConvenioPageViewModel(INavigationService navigationService)
        {
            //GoToCommand = new DelegateCommand(()=> Abre_pesquisa());
            Convenios = new ObservableCollection<convenio>();
            carrega();
            LoadMenu();
           
            _navigationService = navigationService;
        }

        
        readonly INavigationService _navigationService;
        
        public ObservableCollection<convenio> Convenios { get; set; }
        public List<convenio> ListaConvenios;

        public DelegateCommand PesquisaCommand => new DelegateCommand(Pesquisa_convenio);

        public DelegateCommand GoToCommand => new DelegateCommand(Abre_pesquisa);
        //MyCommand = new DelegateCommand(async () => await MyJobAsync());
     
      
        private  void Abre_pesquisa()
        {
            _navigationService.NavigateAsync("PesquisaPage",useModalNavigation:true);
        }

        private void Pesquisa_convenio()
        {
           
            
        }

        private void LoadMenu()
        {
            
            Convenios.Clear();
            // ListaEspecialidades.OrderBy(x => x.Descricao);
            if (ProductFilter.Trim().Length > 0)
            {

                foreach (var item in ListaConvenios.Where(x => x.Nome.ToUpper().Contains(ProductFilter.ToUpper())).OrderBy(x => x.Nome))
                {
                    Convenios.Add(new convenio()
                    {
                        Nome = item.Nome,
                        Foto = item.Foto,
                        // Endereco = item.Endereco
                    });
                }
            }
            else
            {
                foreach (var item in ListaConvenios.OrderBy(x => x.Nome))
                {
                    Convenios.Add(new convenio()
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

            ListaConvenios = new List<convenio>();
            convenio item01 = new convenio()
            {
                Nome = "Unimed",
                Foto = "convenio",
                //Endereco = ""
            };
            ListaConvenios.Add(item01);

            convenio item02 = new convenio()
            {
                Nome = "Camed",
                Foto = "convenio",
                //Endereco =""
            };
            ListaConvenios.Add(item02);

            convenio item03 = new convenio()
            {
                Nome = "HapVida",
                Foto = "convenio",
                //Endereco =""
            };
            ListaConvenios.Add(item03);

            convenio item04 = new convenio()
            {
                Nome = "Cassi",
                Foto = "convenio",
                //Endereco =""
            };
            ListaConvenios.Add(item04);

            convenio item05 = new convenio()
            {
                Nome = "Bradesco",
                Foto = "convenio",
                // Endereco = ""
            };
            ListaConvenios.Add(item05);

            convenio item06 = new convenio()
            {
                Nome = "Golden Cross",
                Foto = "convenio",
                //Endereco = ""
            };
            ListaConvenios.Add(item06);

            convenio item07 = new convenio()
            {
                Nome = "Nome",
                Foto = "convenio",
                //Endereco = ""
            };
            ListaConvenios.Add(item07);

            convenio item08 = new convenio()
            {
                Nome = "Nome",
                Foto = "convenio",
                //Endereco = ""
            };
            ListaConvenios.Add(item08);

            convenio item09 = new convenio()
            {

                Nome = "Nome",
                Foto = "convenio",
                //Endereco = ""
            };
            ListaConvenios.Add(item09);

        }

    }
}

