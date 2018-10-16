using MvvmCross.Core.ViewModels;
using System.Threading.Tasks;
using MvvmCross.Core.Navigation;

namespace Example3TableLayout.Core.ViewModels
{
    public class Child3ViewModel : MvxViewModel
    {
        readonly IMvxNavigationService navigationService;

        public Child3ViewModel(IMvxNavigationService navigationService)
        {
            this.navigationService = navigationService;

            ExampleReturnCommand = new MvxAsyncCommand(ExampleReturn);
        }

        public IMvxAsyncCommand ExampleReturnCommand { get; }

        async Task ExampleReturn()
        {
            await navigationService.Close(this);
        }
    }
}
