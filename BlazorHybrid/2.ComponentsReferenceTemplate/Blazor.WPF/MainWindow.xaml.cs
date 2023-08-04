using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace Blazor.WPF
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			var serviceCollection = new ServiceCollection();
            serviceCollection.AddWpfBlazorWebView();
            serviceCollection.AddBlazorWebViewDeveloperTools();


			Resources.Add("services", serviceCollection.BuildServiceProvider());

			InitializeComponent();
		}
	}
}
