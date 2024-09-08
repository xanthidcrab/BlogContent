using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNCUI.View.Model.Header
{
    public class DateAndTimeModel
    {
        public DateTime Counter { get; set; }
		private string _textProperty;

		public string TextProperty
		{
			get { return _textProperty; }
			set { _textProperty = value; }
		}
       
    }
}
