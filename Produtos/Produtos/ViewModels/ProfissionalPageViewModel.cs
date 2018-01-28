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
    public class ProfissionalPageViewModel : BindableBase
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
        public ProfissionalPageViewModel(INavigationService navigationService)
        {
            Profissionais = new ObservableCollection<profissionais>();
            
            carrega();
            LoadMenu();
            _navigationService = navigationService;

        }
        public ObservableCollection<profissionais> Profissionais { get; set; }
        public List<profissionais> ListaProfissionais;

        public DelegateCommand GoToCommand => new DelegateCommand(Abre_pesquisa);
        //MyCommand = new DelegateCommand(async () => await MyJobAsync());


        private void Abre_pesquisa()
        {
            _navigationService.NavigateAsync("PesquisaPage", useModalNavigation: true);
        }
        private void LoadMenu()
        {
            
            Profissionais.Clear();
            // ListaEspecialidades.OrderBy(x => x.Descricao);
            if (ProductFilter.Trim().Length > 0)
            {
                foreach (var item in ListaProfissionais.Where(x => x.Nome.ToUpper().Contains(ProductFilter.ToUpper())).OrderBy(x => x.Nome))
                {
                    Profissionais.Add(new profissionais()
                    {
                        Nome = item.Nome,
                        Foto = item.Foto,
                        // Endereco = item.Endereco
                    });
                }
            }
            else
            {
                foreach (var item in ListaProfissionais.OrderBy(x => x.Nome))
                {
                    Profissionais.Add(new profissionais()
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

            ListaProfissionais = new List<profissionais>();
            profissionais item01 = new profissionais()
            {
                Nome = "Carlo Danilo",
                Foto = "profissional.png",
                //Endereco = ""
            };
            ListaProfissionais.Add(item01);

            profissionais item02 = new profissionais()
            {
                Nome = "Marjorie Teles",
                Foto = "profissional.png",
                //Endereco =""
            };
            ListaProfissionais.Add(item02);

            profissionais item03 = new profissionais()
            {
                Nome = "Gustavo Viana",
                Foto = "profissional.png",
                //Endereco =""
            };
            ListaProfissionais.Add(item03);

            profissionais item04 = new profissionais()
            {
                Nome = "Lorena Loureiro",
                Foto = "profissional.png",
                //Endereco =""
            };
            ListaProfissionais.Add(item04);

            profissionais item05 = new profissionais()
            {
                Nome = "Leonardo Viana",
                Foto = "profissional.png",
               // Endereco = ""
            };
            ListaProfissionais.Add(item05);

            profissionais item06 = new profissionais()
            {
                Nome = "Rafael Viana",
                Foto = "profissional.png",
                //Endereco = ""
            };
            ListaProfissionais.Add(item06);

            profissionais item07 = new profissionais()
            {
                Nome = "Antonio Loureiro",
                Foto = "profissional.png",
                //Endereco = ""
            };
            ListaProfissionais.Add(item07);

            profissionais item08 = new profissionais()
            {
                Nome = "Caio Daniel",
                Foto = "profissional.png",
                //Endereco = ""
            };
            ListaProfissionais.Add(item08);

            profissionais item09 = new profissionais()
            {

                Nome = "Carla Fabiana",
                Foto = "profissional.png",
                //Endereco = ""
            };
            ListaProfissionais.Add(item09);

            profissionais item10 = new profissionais()
            {

                Nome = "Luciano Praça",
                Foto = "profissional.png",
                //Endereco = ""
            };
            ListaProfissionais.Add(item10);

            profissionais item11 = new profissionais()
            {

                Nome = "Rodrigo Rego",
                Foto = "profissional.png",
                //Endereco = ""
            };
            ListaProfissionais.Add(item11);
            profissionais item12 = new profissionais()
            {

                Nome = "Leane Landim",
                Foto = "profissional.png",
                //Endereco = ""
            };
            ListaProfissionais.Add(item12);
        }

    }
}
