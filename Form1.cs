using Dogman.Controller;
using Dogman.Model;

namespace Dogman
{
    public partial class frmInicio : Form
    {
        private IControllerDogman controller = new ControllerDogman();
        private List<DogManModel> personajes = new List<DogManModel>();

        public frmInicio()
        {
            InitializeComponent();

        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
                CargarPersonajes();
                CargarComboBox();
        }

        private void CargarComboBox()
        {
            try
            {
                personajes = controller.ObtenerPersonajes(); // Obtener los personajes desde el controlador

                cBpersonaje.DisplayMember = "Nombre";  // Mostrar el nombre en el ComboBox
                cBpersonaje.ValueMember = "Imagen_Url"; // Guardar la URL de la imagen
                cBpersonaje.DataSource = personajes;   // Asignar la lista al ComboBox
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los personajes: " + ex.Message);
            }
        }

        private async Task CargarImagen(string url)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(url) || !Uri.IsWellFormedUriString(url, UriKind.Absolute))
                {
                    throw new Exception("URL de imagen no válida.");
                }

                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (!response.IsSuccessStatusCode)
                    {
                        throw new Exception($"Error al obtener la imagen. Código HTTP: {response.StatusCode}");
                    }

                    byte[] imageBytes = await response.Content.ReadAsByteArrayAsync();

                    using (var ms = new System.IO.MemoryStream(imageBytes))
                    {
                        pBPersonajes.Image = Image.FromStream(ms);
                    }
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show("Error de conexión al obtener la imagen: " + ex.Message);
                pBPersonajes.Image = null;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("La imagen descargada no es válida: " + ex.Message);
                pBPersonajes.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la imagen: " + ex.Message);
                pBPersonajes.Image = null;
            }
        }

        private void CargarPersonajes()
        {
            try
            {
                dGVPersonaje.DataSource = controller.ObtenerPersonajes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private async void cBpersonaje_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? imageUrl = cBpersonaje.SelectedValue as string;

            if (!string.IsNullOrEmpty(imageUrl))
            {
                await CargarImagen(imageUrl);
            }
            else
            {
                pBPersonajes.Image = null;
            }
        }
    

        
    }
}
