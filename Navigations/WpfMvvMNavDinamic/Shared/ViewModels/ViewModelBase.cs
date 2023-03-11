using CommunityToolkit.Mvvm.ComponentModel;

namespace WpfMvvMNavDinamic.Shared.ViewModels;

public abstract partial class ViewModelBase : ObservableRecipient
{
    public ViewModelBase()
    {
        //Activate ObservableRecipient events
        IsActive = true;
    }
}
