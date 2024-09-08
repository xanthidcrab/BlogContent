using CNCUI.Model.Header;
using CNCUI.View.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNCUI.ViewModel.Header
{
    public class MachineModeViewModel : BaseViewModel
    {
        private MachineModeModel _machineMode;

        public MachineModeModel MachineModeModel
        {
            get
            {
                return _machineMode;
            }
            set
            {
                _machineMode = value;
                OnpropertyChange(nameof(MachineModeModel));
            }

        }
        public MachineModeViewModel()
        {
              MachineModeModel = new MachineModeModel();
        }
    }
}
