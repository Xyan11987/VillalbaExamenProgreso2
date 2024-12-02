

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace VillalbaExamenProgreso2;

public partial class PaginaRecarga : ContentPage, INotifyPropertyChanged
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

		NumeroTelefonico = aa_entry1.Text;
        NombreUsuario = aa_entry2.Text;


        if (string.IsNullOrEmpty(NumeroTelefonico) || string.IsNullOrEmpty(NombreUsuario))
		{
			DisplayAlert("Error", "Ingrese todos los datos.", "OK.")
				; return;
		}

		string fileName = $"{NombreUsuario} {NumeroTelefonico}.txt";
		string filepath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), fileName);

		string recargaInfo = $"Nombre: {NombreUsuario} \nTelefono: {NumeroTelefonico} \nRecarga Realizada: {DateTime.Now}";
		File.WriteAllText(filepath, recargaInfo ) ;

		DisplayAlert("Recarga Realizada", "La recarga se ha realizado exitosamente", "OK.");

		MostrarUltimaRecarga();
    }

	private void MostrarUltimaRecarga()
	{
		string fileName = $"{NombreUsuario} {NumeroTelefonico}.txt";
		string filepath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), fileName);

		if (File.Exists(filepath))
		{ 
			string ultimaRecarga = File.ReadAllText(filepath) ;

			aa_label3.Text = ultimaRecarga;
		}
    }

	



	
}