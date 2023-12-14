using CommunityToolkit.Mvvm.Input;

namespace Examen_2;

public partial class Areacirculo : ContentPage
{
	public Areacirculo()
	{
		InitializeComponent();
	}




	public const double PI = 3.1415926535897931;
	private async void OnButtonClicked(object sender, EventArgs e)
	{
		try
		{
			var Area = double.Parse(Numero1.Text);
			if (Area == 0)
			{
				MainThread.BeginInvokeOnMainThread(async() = await App.Current!.Mainpage!.DisplayAlert("ERROR", "NO SE PUEDE DEJAR VACIO");
			}
			else
			{
				var AREA = Area * 2;
				var RESULTADO = PI * AREA;
                               var Solucion = RESULTADO.ToString();
			}
		}
		catch (Exception ex)
		{
			MainThread.BeginInvokeOnMainThread(async() = await App.Current!.Mainpage!.DisplayAlert("ERROR", ex.Message, "Aceptar");
		}
		[RelayCommand]
		static void Limpiar()
		{
			Area = 0;


		}

	}
}
