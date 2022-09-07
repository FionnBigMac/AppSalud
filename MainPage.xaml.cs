using AppSalud.Pages;

namespace AppSalud
{

	public partial class MainPage : ContentPage
	{


		public MainPage()
		{
			InitializeComponent();
			btnEntrar.Clicked += BtnEntrar_Clicked;
		}

		private void BtnEntrar_Clicked(object sender, EventArgs e)
		{
            if (txtNombre.Text == null || txtNombre.Text.Length == 0)
            {
                DisplayAlert("Error", "Captura tu nombre", "Ok");
            }
            else
            {
                Navigation.PushAsync(new DatosPage(txtNombre.Text.ToString()));
            }
        }
	}
}

