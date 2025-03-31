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

        private void BAgregar_Click(object sender, EventArgs e)

        {
            // Crear una instancia del modelo de personaje
            DogManModel nuevoPersonaje = new DogManModel
            {
                Nombre = TBNombre.Text,
                Tipo = TBTipo.Text,
                Habilidad_Especial = TBHabilidad.Text,
                Imagen_Url = TBURL.Text
            };

            // Verificar si todos los campos están completos
            if (string.IsNullOrEmpty(nuevoPersonaje.Nombre) || string.IsNullOrEmpty(nuevoPersonaje.Tipo) || string.IsNullOrEmpty(nuevoPersonaje.Habilidad_Especial) || string.IsNullOrEmpty(nuevoPersonaje.Imagen_Url))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de agregar un personaje.");
                return;
            }

            // Llamar al controlador para agregar el personaje
            var agregado = controller.InsertarPersonaje(nuevoPersonaje);

            // Mostrar un mensaje dependiendo del resultado
            if (agregado)
            {
                MessageBox.Show("Personaje agregado con éxito.");
                LimpiarCampos(); // Limpiar los campos después de agregar
                ActualizarDataGridView(); // Actualizar el DataGridView
            }
            else
            {
                MessageBox.Show("Error al agregar el personaje.");
            }

        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            // Validar que el campo no esté vacío
            if (string.IsNullOrWhiteSpace(TBEliminar.Text))
            {
                MessageBox.Show("Por favor ingrese un ID de personaje válido.");
                return;
            }

            // Validar que sea un número válido
            if (!int.TryParse(TBEliminar.Text, out int id))
            {
                MessageBox.Show("El ID debe ser un número entero válido.");
                return;
            }

            // Confirmar con el usuario antes de eliminar
            DialogResult confirmacion = MessageBox.Show(
                $"¿Está seguro que desea eliminar el personaje con ID {id}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmacion != DialogResult.Yes)
            {
                return;
            }

            try
            {
                bool eliminado = controller.EliminarPersonaje(id);
                if (eliminado)
                {
                    CargarPersonajes();
                    CargarComboBox();
                    MessageBox.Show("Personaje eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontró el personaje con el ID ingresado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar personaje: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void BMostrar_Click(object sender, EventArgs e)
        {
            CargarPersonajes();
            CargarComboBox();
        }


        private void BActualizar_Click_1(object sender, EventArgs e)
        {
            // Verificar si el Id está especificado
            if (string.IsNullOrEmpty(TBIdPersonaje.Text))
            {
                MessageBox.Show("Por favor, ingrese un Id de personaje para actualizar.");
                
                return;
            }

            // Obtener el ID del personaje y los nuevos datos
            int idPersonaje = Convert.ToInt32(TBIdPersonaje.Text);
            DogManModel personajeActualizado = new DogManModel
            {
                Nombre = TBNombre.Text,
                Tipo = TBTipo.Text,
                Habilidad_Especial = TBHabilidad.Text,
                Imagen_Url = TBURL.Text

            };

            // Verificar si todos los campos están completos
            if (string.IsNullOrEmpty(personajeActualizado.Nombre) || string.IsNullOrEmpty(personajeActualizado.Tipo) || string.IsNullOrEmpty(personajeActualizado.Habilidad_Especial) || string.IsNullOrEmpty(personajeActualizado.Imagen_Url))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de actualizar el personaje.");
                return;
            }

            // Llamar al controlador para actualizar el personaje
            bool actualizado = controller.ActualizarPersonaje(idPersonaje, personajeActualizado);

            // Mostrar un mensaje dependiendo del resultado
            if (actualizado)
            {
                MessageBox.Show("Personaje actualizado con éxito.");
                LimpiarCampos(); // Limpiar los campos después de actualizar
                ActualizarDataGridView(); // Actualizar el DataGridView
                CargarComboBox();
            }
            else
            {
                MessageBox.Show("Error al actualizar el personaje.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void ActualizarDataGridView()
        {
            dGVPersonaje.DataSource = controller.ObtenerPersonajes(); // Actualizar los datos del DataGridView
        }

        private void LimpiarCampos()
        {
            // Limpiar todos los campos de entrada
            TBNombre.Clear();
            TBTipo.Clear();
            TBHabilidad.Clear();
            TBURL.Clear();
            TBIdPersonaje.Clear();
            TBEliminar.Clear();
        }

    }
}
