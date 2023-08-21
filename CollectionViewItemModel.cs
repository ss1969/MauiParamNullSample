using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiApp1;

public partial class CollectionViewItemModel : ObservableObject
{
    [ObservableProperty] private int value;
}