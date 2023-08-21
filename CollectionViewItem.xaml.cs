using System.Windows.Input;

namespace MauiApp1;

public partial class CollectionViewItem : ContentView
{
    public static readonly BindableProperty Button1CommandProperty =
        BindableProperty.Create(nameof(Button1Command), typeof(ICommand), typeof(CollectionViewItem), null, BindingMode.OneWay);
    public ICommand Button1Command
    {
        get => (ICommand)GetValue(Button1CommandProperty);
        set => SetValue(Button1CommandProperty, value);
    }

    public static readonly BindableProperty SelfHandleProperty =
    BindableProperty.Create(nameof(SelfHandle), typeof(CollectionViewItemModel), typeof(CollectionViewItem), null, BindingMode.TwoWay);
    public CollectionViewItemModel SelfHandle
    {
        get => (CollectionViewItemModel)GetValue(SelfHandleProperty);
        set => SetValue(SelfHandleProperty, value);
    }

    public CollectionViewItem()
	{
		InitializeComponent();
	}
}