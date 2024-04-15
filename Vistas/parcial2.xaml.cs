namespace hchavezT2v1.Vistas;

public partial class parcial2 : ContentPage
{
	public parcial2()
	{
		InitializeComponent();
	}

    private void OnCalcularClicked(object sender, EventArgs e)
    {
        string nombre1 = "henry chavez";

        if (double.TryParse(notaSeguimiento2Entry.Text, out double notaSeguimiento2) &&
            double.TryParse(examen2Entry.Text, out double examen2) &&
            double.TryParse(notaParcial1Entry.Text, out double notaParcial1))
        {
            double notaSeguimiento2Ponderada = notaSeguimiento2 * 0.3;
            double examen2Ponderado = examen2 * 0.2;
            double notaParcial1Dividida = notaParcial1 / 2;
            double notaParcial2 = notaSeguimiento2Ponderada + examen2Ponderado;
            double notaFinal = notaParcial1Dividida + notaParcial2;

            string estado = "";

            if (notaFinal >= 7)
            {
                estado = "Aprobado";
            }
            else if (notaFinal >= 6.9 && notaFinal < 7)
            {
                estado = "Complementario";
            }
            else
            {
                estado = "Reprobado";
            }

            // Construir el mensaje de la alerta
            string mensaje = $"Nombre: {nombre1}  \nFecha: {datePicker.Date.ToShortDateString()}\nNota parcial 1: {notaParcial1}\nNota parcial 2: {notaParcial2}\nNota final: {notaFinal}\nEstado: {estado}";

            // Mostrar la alerta con el mensaje
            DisplayAlert("Resultado", mensaje, "OK");
        }
        else
        {
            DisplayAlert("Error", "Por favor ingrese valores válidos (1-10) para todas las notas.", "OK");
        }
    }


}