using System;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

namespace currencyConverter
{
    public partial class currencyConverter : Form
    {
        private bool isWebViewInitialized = false;

        public currencyConverter()
        {
            InitializeComponent();
            InitializeWebView(); // AGREGAR ESTO
        }

        private async void InitializeWebView()
        {
            try
            {
                // Inicializar WebView2 de forma asíncrona
                await webView21.EnsureCoreWebView2Async(null);
                isWebViewInitialized = true;

                // OPCIONAL: Navegar a la página de inicio automáticamente
                // webView21.CoreWebView2.Navigate("https://themoneyconverter.com/ES/");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al inicializar WebView2: {ex.Message}\n\n" +
                    "Asegúrate de tener instalado WebView2 Runtime desde:\n" +
                    "https://developer.microsoft.com/microsoft-edge/webview2/",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bttCurrency_Click(object sender, EventArgs e)
        {
            // Validar que WebView2 esté inicializado
            if (!isWebViewInitialized)
            {
                MessageBox.Show("WebView2 aún se está inicializando. Intenta de nuevo en un momento.",
                    "Espera", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            webView21.CoreWebView2.Navigate("https://themoneyconverter.com/ES/");
        }
    }
}