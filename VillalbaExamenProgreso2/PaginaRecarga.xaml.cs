

using System.ComponentModel.DataAnnotations;

namespace VillalbaExamenProgreso2;

public partial class PaginaRecarga : ContentPage
{
	public PaginaRecarga()
	{
		InitializeComponent();

		BindingContext = this;

	}

	public string NombreUsuario { get; set; }
	public string NumeroTelefonico { get; set; }

	
	private void Recargar(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(NumeroTelefonico) || string.IsNullOrEmpty(NombreUsuario))
		{
			DisplayAlert("Error", "Ingrese todos los datos.", "OK.")
				; return;
		}

    }



	
}