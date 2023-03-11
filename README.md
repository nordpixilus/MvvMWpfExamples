# WpfMvvMExamples

[English](README.en.md)

**MVVM WPF примеры**

Binding Command и это всё комманда работает.
```
[RelayCommand]
private void GoToHomeView()
{
    ChildContent = new HomeViewModel();
}
```

Привязка Свойства.
```
[ObservableProperty]
private string? _Title;
```


Примеры используют подход **Feature-Sliced Design** (FSD)
[Узнать подробнее можно здесь](https://feature-sliced.design/ru/docs)

Расположение файлов делайте удобным для вас.

Здесь начальный пример 

[Используется](https://learn.microsoft.com/ru-ru/dotnet/communitytoolkit/mvvm/) **CommunityToolkit.Mvvm**

## WpfMvvMNav

Простая реализация WPF MVVM навигации со сменой содержимого в окне.

## WpfMvvMNavDinamic

Если ваш проект содержит более 3 представлений.

Реализована динамическая конвертация ViewModel в View
