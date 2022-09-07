namespace AppSalud.Pages;

public partial class RecomendacionesPage : ContentPage
{
	public RecomendacionesPage(string Resultado)
	{
		InitializeComponent();
		lblCondicion.Text = Resultado;
		if (lblCondicion.Text == "Peso bajo") {
			lblRecomendacion.Text = "Revisa que tu alimentación contenga las suficientes calorías";
			lblMensaje.Text = "Recuerda que los extremos también son malos";
		}
        if (lblCondicion.Text == "Peso normal")
        {
            lblRecomendacion.Text = "Continúa así, no olvides mantenerte hidratad@";
            lblMensaje.Text = "Felicidades por cuidar tu salud";
        }
        if (lblCondicion.Text == "Peso alto")
        {
            lblRecomendacion.Text = "Al día realiza mínimo 30 minutos de actividad deportiva, haz estiramientos que favorecen a tu circulación";
            lblMensaje.Text = "La obesidad puede poner en riesgo tu vida";
        }
    }
}