using MvvmCross.Core.ViewModels;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using MvvmCross.Core.Navigation;

namespace Example3TableLayout.Core.ViewModels
{
    public class FirstViewModel
        : MvxViewModel
    {
        public ObservableCollection<TableCellViewModel> TableCells { get; }
        readonly IMvxNavigationService navigationService;

        public IMvxAsyncCommand Example1NavigationCommand { get; }

        public FirstViewModel(IMvxNavigationService navigationService)
        {

            this.navigationService = navigationService;

            TableCells = new ObservableCollection<TableCellViewModel>();

            TableCells.Add(new TableCellViewModel
            {
                Title = "First Cell",
                ClickCommand = new MvxAsyncCommand(Navigate2Child1)
            });

            TableCells.Add(new TableCellViewModel
            {
                Title = "Second Cell",
                ClickCommand = new MvxAsyncCommand(Navigate2Child2)
            });

            TableCells.Add(new TableCellViewModel
            {
                Title = "Third Cell",
                ClickCommand = new MvxAsyncCommand(Navigate2Child3)
            });

        }

        async Task Navigate2Child1()
        {
            await navigationService.Navigate(typeof(Child1ViewModel));
        }
        async Task Navigate2Child2()
        {
            await navigationService.Navigate(typeof(Child2ViewModel));
        }
        async Task Navigate2Child3()
        {
            await navigationService.Navigate(typeof(Child3ViewModel));
        }
    }
}
