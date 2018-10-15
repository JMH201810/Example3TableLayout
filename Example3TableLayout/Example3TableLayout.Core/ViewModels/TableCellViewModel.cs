using MvvmCross.Core.ViewModels;

namespace Example3TableLayout.Core.ViewModels
{
    public class TableCellViewModel : MvxViewModel
    {
        private string _title;
        private MvxCommand _clickCommand;

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        public MvxCommand ClickCommand
        {
            get => _clickCommand;
            set => SetProperty(ref _clickCommand, value);
        }
    }
}
