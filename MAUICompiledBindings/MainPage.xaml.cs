using MAUICompiledBindings.Models;

namespace MAUICompiledBindings;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
        BindingContext = new EmptyClass() { Nome = "Dan" };
        InitializeComponent();
	}


}


