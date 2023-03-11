using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using WpfMvvMNav.Shared.Navigations;
using WpfMvvMNav.Windows.Main.Views.Home;
using WpfMvvMNav.Windows.Main.Views.Work;

namespace WpfMvvMNav.Windows.Main
{
    internal partial class MainWindowViewModel : ObservableRecipient, IRecipient<NavigationMessage>
    {
        [ObservableProperty]
        private string? _Title;

        [ObservableProperty]
        private ObservableRecipient? _ChildContent;

        public MainWindowViewModel()
        {
            this.IsActive = true;
            GoToHomeView();
        }

        [RelayCommand]
        private void GoToHomeView()
        {
            ChildContent = new HomeViewModel();
            Title = "Open HomeView";
        }

        [RelayCommand]
        private void GoToWorkView()
        {
            ChildContent = new WorkViewModel();
            Title = "Open WorkView";
        }

        public void Receive(NavigationMessage message)
        {
            switch (message.Value)
            {
                case nameof(WorkViewModel): GoToWorkView(); break;
                case nameof(HomeViewModel): GoToHomeView(); break;
            }
        }
    }
}