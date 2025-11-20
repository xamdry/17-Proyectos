using System;
using System.Text;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;

namespace googleMap
{
    public partial class Frm : Form
    {
        private bool isWebViewInitialized = false;

        public Frm()
        {
            InitializeComponent();
            InitializeWebView();
        }

        private async void InitializeWebView()
        {
            try
            {
                await webView21.EnsureCoreWebView2Async(null);
                isWebViewInitialized = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al inicializar WebView2: {ex.Message}\n\n" +
                    "Descarga WebView2 Runtime desde:\n" +
                    "https://developer.microsoft.com/microsoft-edge/webview2/",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void btSeearch_Click(object sender, EventArgs e)
        {
            if (!isWebViewInitialized)
            {
                MessageBox.Show("WebView2 aún se está inicializando. Intenta de nuevo.",
                    "Espera", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string street = textBoxStreet.Text.Trim();
            string city = textBoxCity.Text.Trim();
            string state = textBoxState.Text.Trim();
            string country = textBoxCountry.Text.Trim();

            try
            {
                // Validar que al menos un campo tenga datos
                if (string.IsNullOrEmpty(street) && string.IsNullOrEmpty(city) &&
                    string.IsNullOrEmpty(state) && string.IsNullOrEmpty(country))
                {
                    MessageBox.Show("Por favor ingresa al menos una ubicación",
                        "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                StringBuilder queryAddress = new StringBuilder();

                // Construir la dirección
                if (!string.IsNullOrEmpty(street))
                {
                    queryAddress.Append(street);
                }
                if (!string.IsNullOrEmpty(city))
                {
                    if (queryAddress.Length > 0) queryAddress.Append(", ");
                    queryAddress.Append(city);
                }
                if (!string.IsNullOrEmpty(state))
                {
                    if (queryAddress.Length > 0) queryAddress.Append(", ");
                    queryAddress.Append(state);
                }
                if (!string.IsNullOrEmpty(country))
                {
                    if (queryAddress.Length > 0) queryAddress.Append(", ");
                    queryAddress.Append(country);
                }

                // Codificar la URL correctamente
                string encodedAddress = Uri.EscapeDataString(queryAddress.ToString());

                // URL correcta de Google Maps
                string googleMapsUrl = $"https://www.google.com/maps/search/{encodedAddress}";

                webView21.CoreWebView2.Navigate(googleMapsUrl);
            }
            catch (Exception exc)
            {
                MessageBox.Show($"Error al cargar el mapa: {exc.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
