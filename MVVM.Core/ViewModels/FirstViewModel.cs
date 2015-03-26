using Cirrious.MvvmCross.ViewModels;

namespace MVVM.Core.ViewModels
{
    public class FirstViewModel 
		: MvxViewModel
    {
		private string _hello = "Hello MvvmCross";
        public string Hello
		{ 
			get { return _hello; }
			set { _hello = value; RaisePropertyChanged(() => Hello); }
		}
        private string _name = "Jerry";
        public string Name
        {
            get { return _name; }
            set { _name = value; RaisePropertyChanged(() => Name); }
        }
    }
}
