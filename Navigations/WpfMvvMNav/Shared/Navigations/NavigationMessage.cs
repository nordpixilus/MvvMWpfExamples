using CommunityToolkit.Mvvm.Messaging.Messages;

namespace WpfMvvMNav.Shared.Navigations
{
    internal class NavigationMessage : ValueChangedMessage<string>
    {
        internal NavigationMessage(string value) : base(value) { }
    }
}