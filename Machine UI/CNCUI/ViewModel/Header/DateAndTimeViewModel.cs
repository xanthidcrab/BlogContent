using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace CNCUI.View.ViewModel.Header
{
    public class DateAndTimeViewModel: BaseViewModel
    {
        private DispatcherTimer _timer;

        private string _textVar;

		public string TextVar
		{
			get { return _textVar; }
			set 
			{ 
				_textVar = value; 
				OnpropertyChange(nameof(TextVar));
			}
		}
        public DateAndTimeViewModel()
        {
            _timer = new DispatcherTimer()
            {
                Interval = TimeSpan.FromSeconds(1)
            };
            _timer.Tick += Timer_Tick;
            _timer.Start();
            TextVar = DateTime.Now.ToString("HH:mm:ss");
        }
        private void Timer_Tick(object sender, EventArgs e) 
        {
            TextVar = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
