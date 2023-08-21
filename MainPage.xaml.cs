using System.Diagnostics;
using CommunityToolkit.Maui.Views;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MainPageVM();
	}
}

