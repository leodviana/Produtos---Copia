using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace Produtos.ViewModels
{
    public class PesquisaPageViewModel : BindableBase
    {
        readonly INavigationService _navigationService;
        public PesquisaPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        //public DelegateCommand PesquisaCommand => new DelegateCommand(Pesquisa_convenio);
        public DelegateCommand aplicafiltrocommand => new DelegateCommand(aplicafiltro);
                              // aplicafiltrocommand
       

        private void aplicafiltro()
        {
            _navigationService.GoBackAsync(null,true);
        }
    }
}
