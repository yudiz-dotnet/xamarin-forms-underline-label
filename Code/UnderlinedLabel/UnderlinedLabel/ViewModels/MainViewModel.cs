namespace UnderlinedLabel.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private string _LabelWithUnderline, _LabelWithoutUnderline;

        public string LabelWithoutUnderline
        {
            get { return _LabelWithoutUnderline; }
            set { _LabelWithoutUnderline = value; NotifyPropertyChanged("LabelWithoutUnderline"); }
        }

        public string LabelWithUnderline
        {
            get { return _LabelWithUnderline; }
            set { _LabelWithUnderline = value; NotifyPropertyChanged("LabelWithUnderline"); }
        }

        public MainViewModel()
        {
            LabelWithoutUnderline = "Without Underline";
            LabelWithUnderline = "With Underline";
        }
    }
}
