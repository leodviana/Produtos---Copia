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
    public class RamoAtivadePageViewModel : BindableBase
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
        public RamoAtivadePageViewModel(INavigationService navigationService)
        {
            //GoToCommand = new DelegateCommand(()=> Abre_pesquisa());
            RamosAtividades = new ObservableCollection<RamoAtividade>();
            carrega();
            LoadMenu();

            _navigationService = navigationService;
        }
        readonly INavigationService _navigationService;

        public ObservableCollection<RamoAtividade> RamosAtividades { get; set; }
        public List<RamoAtividade> ListaRamosAtividades;

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

            RamosAtividades.Clear();
            // ListaEspecialidades.OrderBy(x => x.Descricao);
            if (ProductFilter.Trim().Length > 0)
            {

                foreach (var item in ListaRamosAtividades.Where(x => x.Nome.ToUpper().Contains(ProductFilter.ToUpper())).OrderBy(x => x.Nome))
                {
                    RamosAtividades.Add(new RamoAtividade()
                    {
                        Nome = item.Nome,
                        Foto = item.Foto,
                        // Endereco = item.Endereco
                    });
                }
            }
            else
            {
                foreach (var item in ListaRamosAtividades.OrderBy(x => x.Nome))
                {
                    RamosAtividades.Add(new RamoAtividade()
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

            ListaRamosAtividades = new List<RamoAtividade>();
            RamoAtividade item01 = new RamoAtividade()
            {
                Nome = "Segurança",
                Foto = "atividade",
                //Endereco = ""
            };
            ListaRamosAtividades.Add(item01);

            RamoAtividade item02 = new RamoAtividade()
            {
                Nome = "Fisioterapia",
                Foto = "atividade",
                //Endereco =""
            };
            ListaRamosAtividades.Add(item02);

            RamoAtividade item03 = new RamoAtividade()
            {
                Nome = "Medicina",
                Foto = "atividade",
                //Endereco =""
            };
            ListaRamosAtividades.Add(item03);

            RamoAtividade item04 = new RamoAtividade()
            {
                Nome = "Odontoogia",
                Foto = "atividade",
                //Endereco =""
            };
            ListaRamosAtividades.Add(item04);

            RamoAtividade item05 = new RamoAtividade()
            {
                Nome = "Informática",
                Foto = "atividade",
                // Endereco = ""
            };
            ListaRamosAtividades.Add(item05);

            RamoAtividade item06 = new RamoAtividade()
            {
                Nome = "Direito",
                Foto = "atividade",
                //Endereco = ""
            };
            ListaRamosAtividades.Add(item06);

            RamoAtividade item07 = new RamoAtividade()
            {
                Nome = "Pedagogia",
                Foto = "atividade",
                //Endereco = ""
            };
            ListaRamosAtividades.Add(item07);

            RamoAtividade item08 = new RamoAtividade()
            {
                Nome = "Serviços Gerais",
                Foto = "atividade",
                //Endereco = ""
            };
            ListaRamosAtividades.Add(item08);

            RamoAtividade item09 = new RamoAtividade()
            {

                Nome = "Mecanica",
                Foto = "atividade",
                //Endereco = ""
            };
            ListaRamosAtividades.Add(item09);

        }

    }

}
    

