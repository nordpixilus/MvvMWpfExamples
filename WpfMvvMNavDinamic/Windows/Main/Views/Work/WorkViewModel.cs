using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using WpfMvvMNavDinamic.Shared.Navigations;
using WpfMvvMNavDinamic.Shared.ViewModels;
using WpfMvvMNavDinamic.Windows.Main.Views.Home;

namespace WpfMvvMNavDinamic.Windows.Main.Views.Work
{
    internal partial class WorkViewModel : ViewModelBase
    {
        public string TextLabel { get; set; } = "WorkView";
        public string TextButton { get; set; } = "GoToHomeView";

        [RelayCommand]
        private void GoToHomeView()
        {
            Messenger.Send(new NavigationMessage(nameof(HomeViewModel)));
            //WeakReferenceMessenger.Default.Send(new NavigationMessage(nameof(HomeViewModel)));
        }
    }
}