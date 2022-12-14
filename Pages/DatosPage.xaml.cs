using AppSalud.Models;

namespace AppSalud.Pages;

public partial class DatosPage : ContentPage
{
	public DatosPage(string nombre)
	{
		InitializeComponent();
		lblNombre.Text = nombre;
		btnIMC.Clicked += BtnIMC_Clicked;
	}

	private void BtnIMC_Clicked(object sender, EventArgs e)
	{
		Persona persona = new Persona();
		persona.Nombre = lblNombre.Text;
		persona.Edad = int.Parse(txtEdad.Text);
		persona.Peso = float.Parse(txtPeso.Text);
		persona.Altura = float.Parse(txtAltura.Text);

		Navigation.PushAsync(new IMCPage(persona));
	}
}