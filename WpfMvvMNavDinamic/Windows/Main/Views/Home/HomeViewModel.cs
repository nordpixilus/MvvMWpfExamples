using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using WpfMvvMNavDinamic.Shared.Navigations;
using WpfMvvMNavDinamic.Shared.ViewModels;
using WpfMvvMNavDinamic.Windows.Main.Views.Work;

namespace WpfMvvMNavDinamic.Windows.Main.Views.Home
{
    internal partial class HomeViewModel : ViewModelBase
    {
        public string TextLabel { get; set; } = "HomeView";
        public string TextButton { get; set; } = "GoToWorkView";

        [RelayCommand]
        private void GoToWorkView()
        {
            Messenger.Send(new NavigationMessage(nameof(WorkViewModel)));
            //WeakReferenceMessenger.Default.Send(new NavigationMessage(nameof(WorkViewModel)));
        }
    }
}