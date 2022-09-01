namespace AppSalud.Pages;

public partial class IMCPage : ContentPage
{
	public IMCPage(Persona persona)
	{
		InitializeComponent();
		var IMC = persona.Peso / (persona.Altura * persona.Altura);

		if(IMC < 18.5)
		{
			imgIMC.Source = new Uri("https://www.cpen.cat/wp-content/uploads/baix-pes2.jpg");
			lblResultado.Text = "Peso bajo";
			lblResultado.BackgroundColor = Colors.Yellow; lblResultado.TextColor = Colors.Black;
		}
        if (IMC >= 18.5 && IMC < 25)
        {
            lblResultado.Text = "Peso normal";
            lblResultado.BackgroundColor = Colors.Green;
            imgIMC.Source = new Uri("https://wealthofgeeks.com/wp-content/uploads/2021/11/1242049_HealthyLifestyle_Option2_120721.jpg");
        }

        if (IMC >= 25)
        {
            lblResultado.Text = "Peso alto";
            lblResultado.BackgroundColor = Colors.Red;
            lblResultado.TextColor = Colors.White;
            imgIMC.Source = new Uri("https://i.imgflip.com/5mw1b8.jpg");
        }
    }
}