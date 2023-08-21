using System.Collections.ObjectModel;
using System.Diagnostics;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiApp1;

public partial class MainPageVM : ObservableObject
{
    public MainPageVM()
    {
        CVItems = new()
        {
            new (){ Value = 1},
        };
    }

    [ObservableProperty] private ObservableCollection<CollectionViewItemModel> _CVItems;
    [ObservableProperty] private string _Result;

    [RelayCommand(CanExecute = nameof(CanCVItemButton))]
    private void CVItemButton(CollectionViewItemModel m)
    {
        Trace.WriteLine($"Parameter shouldn't be NULL, in Debug it's not NULL, but in Release it's NULL");
        Result = ($"CVItemButton() Paramter is NULL => {m == null}");
    }

    private bool CanCVItemButton(CollectionViewItemModel m)
    {
        Trace.WriteLine($"CanCVItemButton() received an NULL parameter => {m == null}");
        return true;
    }

}