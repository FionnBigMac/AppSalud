namespace AppSalud.Pages;

public partial class RecomendacionesPage : ContentPage
{
	public RecomendacionesPage(string Resultado)
	{
		InitializeComponent();
		lblCondicion.Text = Resultado;
		if (lblCondicion.Text == "Peso bajo") {
			lblRecomendacion.Text = "Revisa que tu alimentaci�n contenga las suficientes calor�as";
			lblMensaje.Text = "Recuerda que los extremos tambi�n son malos";
		}
        if (lblCondicion.Text == "Peso normal")
        {
            lblRecomendacion.Text = "Contin�a as�, no olvides mantenerte hidratad@";
            lblMensaje.Text = "Felicidades por cuidar tu salud";
        }
        if (lblCondicion.Text == "Peso alto")
        {
            lblRecomendacion.Text = "Al d�a realiza m�nimo 30 minutos de actividad deportiva, haz estiramientos que favorecen a tu circulaci�n";
            lblMensaje.Text = "La obesidad puede poner en riesgo tu vida";
        }
    }
}