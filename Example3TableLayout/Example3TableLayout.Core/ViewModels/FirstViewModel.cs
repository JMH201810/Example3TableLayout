using MvvmCross.Core.ViewModels;
using System.Collections.ObjectModel;

namespace Example3TableLayout.Core.ViewModels
{
    public class FirstViewModel
        : MvxViewModel
    {
        public ObservableCollection<TableCellViewModel> TableCells { get; }

        public FirstViewModel()
        {
            TableCells = new ObservableCollection<TableCellViewModel>();

            TableCells.Add(new TableCellViewModel
            {
                Title = "First Cell",
                ClickCommand = null//new MvxCommand(Navigate2Child1)
            });

            TableCells.Add(new TableCellViewModel
            {
                Title = "Second Cell",
                ClickCommand = null//new MvxCommand(Navigate2Child2)
            });

            TableCells.Add(new TableCellViewModel
            {
                Title = "Third Cell",
                ClickCommand = null//new MvxCommand(Navigate2Child3)
            });

        }
    }
}
