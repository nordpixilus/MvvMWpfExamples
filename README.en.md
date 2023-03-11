# WpfMvvMExamples

**MVVM WPF examples**

Binding Command and that's all the team is working on.
```
[RelayCommand]
private void GoToHomeView()
{
    ChildContent = new HomeViewModel();
}
```

Binding Property.
```
[ObservableProperty]
private string? _Title;
```

Examples use the approach **Feature-Sliced Design** (FSD)
[You can find out more here](https://feature-sliced.design/docs)

Make the location of the files convenient for you.

Here is an initial example

[Is used](https://learn.microsoft.com/ru-ru/dotnet/communitytoolkit/mvvm/) **CommunityToolkit.Mvvm**

## WpfMvvMNav

A simple implementation of WPF MVVM navigation with changing content in the window.

## WpfMvvMNavDinamic

If your project contains more than 3 views.

Implemented dynamic conversion of ViewModel to View