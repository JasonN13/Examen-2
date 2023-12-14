using CommunityToolkit.Mvvm.Input;

namespace Examen_2;

public partial class AreaRectangulo : ContentPage
{
	public AreaRectangulo()
	{
		InitializeComponent();
	}
   

    private async void OnButtonClicked(object sender, EventArgs e)
    {

        try
        {
            var BASE = double.Parse(Numero1.Text);
            var Altura = double.Parse(Numero2.Text);
            if (Altura ==0)
            {
                MainThread.BeginInvokeOnMainThread(async() = await App.Current!.Mainpage!.DisplayAlert("ERROR", "NO SE PUEDE DEJAR VACIO");
            }
            else
            {
                var RESULTADO = BASE * Altura;
                var Solucion = RESULTADO.ToString();
}
		}
         catch   (Exception ex) 
		{
    MainThread.BeginInvokeOnMainThread(async() = await App.Current!.Mainpage!.DisplayAlert("ERROR", ex.Message, "Aceptar");
}
    }
    [RelayCommand]
    public void CLEAN()
    {
        Numero1 = 0;
        Numero2 = 0;


    }

}