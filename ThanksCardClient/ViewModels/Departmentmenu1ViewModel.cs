using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using ThanksCardClient.Models;
using ThanksCardClient.Services;

namespace ThanksCardClient.ViewModels
{
    public class DepartmentmenuViewModel : BindableBase
    {
        private readonly IRegionManager regionManager;

        public DepartmentmenuViewModel(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        #region DepartmentReturnCommand
        private DelegateCommand _DepartmentReturnCommand;
        public DelegateCommand DepartmentReturnCommand =>
            _DepartmentReturnCommand ?? (_DepartmentReturnCommand = new DelegateCommand(ExecuteDepartmentReturnCommand));

        void ExecuteDepartmentReturnCommand()
        {
            this.regionManager.RequestNavigate("ContentRegion", nameof(Views.Footer));
        }
        #endregion

    }
}
