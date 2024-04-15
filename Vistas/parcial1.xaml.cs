namespace hchavezT2v1.Vistas;

public partial class parcial1 : ContentPage
{
	public parcial1()
	{
		InitializeComponent();
	}

    private async void OnCalcularClicked(object sender, EventArgs e)
    {
        // Verificar si se han ingresado valores en los Entry
        if (!string.IsNullOrWhiteSpace(notaSeguimientoEntry.Text) && !string.IsNullOrWhiteSpace(examen1Entry.Text))
        {
            if (double.TryParse(notaSeguimientoEntry.Text, out double notaSeguimiento) &&
                double.TryParse(examen1Entry.Text, out double examen1))
            {
                double notaSeguimientoPonderada = notaSeguimiento * 0.3;
                double examen1Ponderado = examen1 * 0.2;

                double notaParcial = notaSeguimientoPonderada + examen1Ponderado;

                resultadoLabel.Text = $"Nombre: {nombrePicker.SelectedItem}, Nota parcial: {notaParcial}";
            }
            else
            {
                await DisplayAlert("Error", "Por favor ingrese valores válidos (1-10) para la nota de seguimiento y el examen 1.", "OK");
            }
        }
        else
        {
            await DisplayAlert("Error", "Por favor complete todos los valores.", "OK");
        }
    }

    private async void btnsiguiente_Clicked(object sender, EventArgs e)
    {
        // Verificar si se ha calculado la nota parcial
        if (!string.IsNullOrWhiteSpace(resultadoLabel.Text))
        {
            await Navigation.PushAsync(new parcial2());
        }
        else
        {
            await DisplayAlert("Error", "Por favor realice el cálculo primero.", "OK");
        }
    }



}