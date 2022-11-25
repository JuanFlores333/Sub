using Plugin.CloudFirestore;
using Sub.Models;

namespace Sub;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    public void Ver()
    {
        CrossCloudFirestore.Current
        .Instance
                 .Collection("Prueba")
                 .Document("Usuarios")
                 .AddSnapshotListener((snap, error) =>
                 {
                     Usuarios rack = snap.ToObject<Usuarios>();
                     Nombre.Text = rack.Nombre;
                     Apellido_Materno.Text = rack.Apellido_Materno;
                     Apellido_Paterno.Text = rack.Apellido_Paterno;
                     Numero.Text = rack.Numero;
                 });
    }
}

