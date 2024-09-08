using CNCUI.Model.Header;
using CNCUI.View.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNCUI.ViewModel.Header
{
    public class UserViewModel:BaseViewModel
    {
		private UserModel _usr;

		public UserModel Usr
		{
			get { return _usr; }
			set { _usr = value;
				OnpropertyChange(nameof(UserModel));
			}
		}
        public UserViewModel()
        {
			Usr = new UserModel();
			Usr.Name = "HARUN CORP";
        }
    }
}
