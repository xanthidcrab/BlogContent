using CNCUI.View.Model.Header;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace CNCUI.View.ViewModel.Header
{
    public class LogoViewModel : BaseViewModel
    {
        private LogoModel _logo;
        public LogoModel Logo
        {
            get
            { return _logo; }
            set
            {
                _logo = value;
                OnpropertyChange(nameof(Logo));
            }
        }
        public LogoViewModel()
        {
            Logo = new LogoModel();
            Logo.SelectedLogo = "D:\\Desktop\\blog\\Codes\\Machine UI\\CNCUI\\Assets\\OZGENC.png"; 
        }

       
    }
}
