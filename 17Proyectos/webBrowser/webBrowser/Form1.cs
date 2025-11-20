using System;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

namespace webBrowser
{
    public partial class frmMain : Form
    {
        private bool isWebViewInitialized = false;

        public frmMain()
        {
            InitializeComponent();
            InitializeWebView();
        }

        private async void InitializeWebView()
        {
            try
            {
                // Inicializar WebView2
                await webView21.EnsureCoreWebView2Async(null);
                isWebViewInitialized = true;

                // Configurar página de inicio
                webView21.CoreWebView2.Navigate("https://www.google.com");

                // Evento cuando la navegación se completa
                webView21.CoreWebView2.NavigationCompleted += WebView21_NavigationCompleted;

                // Actualizar URL en la barra de direcciones al navegar
                webView21.CoreWebView2.SourceChanged += WebView21_SourceChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al inicializar WebView2: {ex.Message}\n\n" +
                    "Descarga WebView2 Runtime desde:\n" +
                    "https://developer.microsoft.com/microsoft-edge/webview2/",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Actualizar título y URL cuando cambia la página
        private void WebView21_SourceChanged(object sender, CoreWebView2SourceChangedEventArgs e)
        {
            cLocation.Text = webView21.Source.ToString();
        }

        // Actualizar título cuando termina de cargar
        private async void WebView21_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            if (e.IsSuccess)
            {
                string title = await webView21.CoreWebView2.ExecuteScriptAsync("document.title");
                // Remover comillas del resultado
                title = title.Trim('"');
                this.Text = string.IsNullOrEmpty(title) ? "XAM Browser" : $"XAM - {title}";
            }
        }

        private void cLocation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Navigate(cLocation.Text);
                e.SuppressKeyPress = true; // Evitar el "ding" al presionar Enter
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            if (isWebViewInitialized && webView21.CoreWebView2.CanGoBack)
            {
                webView21.CoreWebView2.GoBack();
            }
        }

        private void BtForward_Click(object sender, EventArgs e)
        {
            if (isWebViewInitialized && webView21.CoreWebView2.CanGoForward)
            {
                webView21.CoreWebView2.GoForward();
            }
        }

        private void btGo_Click(object sender, EventArgs e)
        {
            Navigate(cLocation.Text);
        }

        private void Navigate(string url)
        {
            if (!isWebViewInitialized)
            {
                MessageBox.Show("WebView2 aún se está inicializando. Espera un momento.",
                    "Espera", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrWhiteSpace(url))
            {
                return;
            }

            // Agregar https:// si no tiene protocolo
            if (!url.StartsWith("http://") && !url.StartsWith("https://"))
            {
                // Si parece una URL, agregar https://
                if (url.Contains(".") && !url.Contains(" "))
                {
                    url = "https://" + url;
                }
                else
                {
                    // Si no parece una URL, buscar en Google
                    url = $"https://www.google.com/search?q={Uri.EscapeDataString(url)}";
                }
            }

            try
            {
                webView21.CoreWebView2.Navigate(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al navegar: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // OPCIONAL: Agregar botón de refresh
        private void btRefresh_Click(object sender, EventArgs e)
        {
            if (isWebViewInitialized)
            {
                webView21.CoreWebView2.Reload();
            }
        }

        // OPCIONAL: Agregar botón de home
        private void btHome_Click(object sender, EventArgs e)
        {
            if (isWebViewInitialized)
            {
                webView21.CoreWebView2.Navigate("https://www.google.com");
            }
        }

        // Remover evento click de webView21 (no es necesario)
        // private void webView21_Click(object sender, EventArgs e) { }
    }
}