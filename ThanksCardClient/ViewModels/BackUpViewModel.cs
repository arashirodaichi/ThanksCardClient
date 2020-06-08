using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ThanksCardClient.ViewModels
{
    public class BackUpViewModel : BindableBase
    {
        private readonly IRegionManager regionManager;

        public BackUpViewModel(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        public BackUpViewModel()
        {

        }
        #region BackUpReturnCommand
        private DelegateCommand _BackUpReturnCommand;
        public DelegateCommand BackUpReturnCommand =>
            _BackUpReturnCommand ?? (_BackUpReturnCommand = new DelegateCommand(ExecuteBackUpReturnCommand));

        void ExecuteBackUpReturnCommand()
        {
            this.regionManager.RequestNavigate("ContentRegion", nameof(Views.Departmentmenu));
        }
        #endregion
    }
}
