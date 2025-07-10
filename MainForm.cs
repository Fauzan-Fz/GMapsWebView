using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMapsWebView.Models;
using Microsoft.Web.WebView2.Core;
using WebView2.DevTools.Dom;

namespace GMapsWebView
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region Variable

        private string website = "https://www.google.com/maps/";
        private string Tools = "google.com";
        private int targetSet = 0;
        private int noLogs = 0;
        private bool isStopped = false;
        private bool isDebug = false;

        private WebView2DevToolsContext Page;

        private List<Data> dataList;
        private List<Data> dataDetail;

        #endregion Variable

        #region Website Logic

        private async Task startAdd()
        {
            await webView21.EnsureCoreWebView2Async(null);
        }

        public async Task startBrowser()
        {
            await startAdd();
            Page = await webView21.CoreWebView2.CreateDevToolsContextAsync();

            webView21.CoreWebView2.WebResourceRequested += CoreWebView2_WebResourceRequested;
            webView21.CoreWebView2.AddWebResourceRequestedFilter(null, CoreWebView2WebResourceContext.Image);
            webView21.CoreWebView2.Navigate(website);
        }

        private void CoreWebView2_WebResourceRequested(object sender, CoreWebView2WebResourceRequestedEventArgs e)
        {
            e.Response = webView21.CoreWebView2.Environment.CreateWebResourceResponse(null, 404, "Not Found", null);
        }

        #endregion Website Logic

        #region Fungsi

        public void AddLogs(string Status, string Text)
        {
            noLogs += 1;
            logs_text.Text = Text;
            DateTime time = DateTime.Now;
            string timeLogs = time.ToString("MM/dd/yyyy HH:mm:ss");
            dgvLogs.Rows.Add(noLogs, timeLogs, Status, Text);
            dgvLogs.Sort(dgvLogs.Columns["id_logs"], System.ComponentModel.ListSortDirection.Descending);
        }

        #endregion Fungsi

        #region Event Form

        private int test3 = 0;

        #endregion Event Form
    }
}