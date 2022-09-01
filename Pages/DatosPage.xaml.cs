namespace AppSalud.Pages;

public partial class DatosPage : ContentPage
{
	public DatosPage()
	{
		InitializeComponent();
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