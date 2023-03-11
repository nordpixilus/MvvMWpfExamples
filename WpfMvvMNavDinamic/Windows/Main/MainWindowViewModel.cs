using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using WpfMvvMNavDinamic.Shared.Navigations;
using WpfMvvMNavDinamic.Shared.ViewModels;
using WpfMvvMNavDinamic.Windows.Main.Views.Home;
using WpfMvvMNavDinamic.Windows.Main.Views.Work;

namespace WpfMvvMNavDinamic.Windows.Main
{
    internal partial class MainWindowViewModel : ViewModelBase, IRecipient<NavigationMessage>
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