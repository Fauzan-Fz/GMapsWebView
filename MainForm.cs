using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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

        public async void startBrowser()
        {
            await startAdd();
            Page = await webView21.CoreWebView2.CreateDevToolsContextAsync();

            webView21.CoreWebView2.WebResourceRequested += CoreWebView2_WebResourceRequested;
            webView21.CoreWebView2.AddWebResourceRequestedFilter(null, CoreWebView2WebResourceContext.Image);
            webView21.CoreWebView2.Navigate($"{website}");
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

        public void AddResult(Data DT)
        {
            dgvHasil.Rows.Add(DT.Name, DT.Phone, DT.Email, DT.Website, DT.Rating, DT.Reviews, DT.Address);
        }

        #endregion Fungsi

        #region Event Form

        private void MainForm_Load(object sender, EventArgs e)
        {
            targetSet = (int)num_JumlahData.Value;
            btn_Export_Excel.Visible = false;

            startBrowser();
            AddLogs("Info", "Siap untuk memulai");
        }

        private void Image_Load(object sender, EventArgs e)
        {
            webView21.CoreWebView2.CallDevToolsProtocolMethodAsync("Network.clearBrowserCache", "{}");
            if (this.checkBox_Image.CheckState == CheckState.Unchecked)
            {
                webView21.CoreWebView2.WebResourceRequested += CoreWebView2_WebResourceRequested;
                webView21.CoreWebView2.AddWebResourceRequestedFilter(null, CoreWebView2WebResourceContext.Image);
                webView21.CoreWebView2.Reload();
            }
            else
            {
                webView21.CoreWebView2.WebResourceRequested -= CoreWebView2_WebResourceRequested;
                webView21.CoreWebView2.Reload();
            }
        }

        private void JumlahSetTarget(object sender, EventArgs e)
        {
            targetSet = (int)num_JumlahData.Value;
        }

        private void Debug_Check(object sender, EventArgs e)
        {
            if (this.checkbox_Debug.CheckState == CheckState.Checked)
            {
                isDebug = true;
            }
            else
            {
                isDebug = false;
            }
        }

        private async void StartScrape(object sender, EventArgs e)
        {
            try
            {
                await StartScrape();
            }
            catch (Exception ex)
            {
                AddLogs("Error", $"Start Scrape {ex}");
            }
        }

        private void Export_Excel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook | *.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var workbook = new ClosedXML.Excel.XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("Hasil Scrape");

                            // Header
                            for (int i = 0; i < dgvHasil.Columns.Count; i++)
                            {
                                worksheet.Cell(1, i + 1).Value = dgvHasil.Columns[i].HeaderText;
                            }

                            // Data
                            for (int i = 0; i < dgvHasil.Rows.Count; i++)
                            {
                                for (int j = 0; j < dgvHasil.Columns.Count; j++)
                                {
                                    worksheet.Cell(i + 2, j + 1).Value = dgvHasil.Rows[i].Cells[j].Value?.ToString();
                                }
                            }

                            workbook.SaveAs(sfd.FileName);
                        }
                        MessageBox.Show("Export ke Excel berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gagal export ke Excel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void StopScrape(object sender, EventArgs e)
        {
            if (isStopped == false)
            {
                isStopped = true;
            }
            else
            {
                isStopped = false;
            }
        }

        #endregion Event Form

        #region Logic Scrape

        private async Task StartScrape()
        {
            int Step = 0;
            try
            {
                Step = 1;
                dataList = new List<Data>();
                dataDetail = new List<Data>();
                btn_Export_Excel.Visible = false;

                Step = 2;
                if (targetSet == 0)
                {
                    MessageBox.Show("Tolong Isi Target Data Terlebih Dahulu", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Step = 3;
                await GetListMaps();

                Step = 4;
                if (dataList.Count() == 0)
                {
                    MessageBox.Show($"List Kosong / Tidak Ditemukan", "Stop Scrape", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    AddLogs("Error", "List Kosong / Tidak Ditemukan");
                    return;
                }

                Step = 7;
                foreach (var item in dataList)
                {
                    await GetDetail(item);
                }

                Step = 8;
                AddLogs("Start Scrape", $"Berhasil Scrape : {website}");
                MessageBox.Show($"Berhasil Scrape : {website}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Step = 9;
                btn_Export_Excel.Visible = true;
            }
            catch (Exception ex)
            {
                AddLogs("Error", $"Start Scrape {Step} , {ex}");
            }
        }

        public async Task GetListMaps()
        {
            int Step = 0;
            try
            {
                Step = 1;
                await Task.Delay(3500);

                Step = 2;
                var container = await Page.WaitForXPathAsync("//div[contains(@role, 'feed')]", new WaitForSelectorOptions { Visible = true });
                if (container == null)
                {
                    AddLogs("error", "tidak ditemukan list data");
                    return;
                }

                Step = 3;
                int index = 0;
                while (dataList.Count < targetSet)
                {
                    Step = 4;
                    var DT = new Data();

                    Step = 5;
                    var itemsList = await container.XPathAsync("./div/div");
                    if (index >= itemsList.Length)
                    {
                        await container.EvaluateFunctionAsync(@"feed => {feed.scrollTop = feed.scrollHeight;}", container);
                        await Task.Delay(2000);
                        continue;
                    }

                    Step = 6;
                    var item = itemsList[index++];
                    await item.EvaluateFunctionAsync("e => e.scrollIntoView({ block: 'end' })");
                    await Task.Delay(1500);

                    Step = 7;
                    var name = await item.XPathAsync("./a");
                    if (name == null)
                    {
                        AddLogs("Error", "Tidak ditemukan element");
                    }
                    if (name.Length > 0)
                    {
                        Step = 8;
                        DT.Url = await name[0].EvaluateFunctionAsync<string>("a => a.href", name[0]);
                        DT.Name = await name[0].EvaluateFunctionAsync<string>("a => a.ariaLabel", name[0]);

                        Step = 9;
                        if (!string.IsNullOrEmpty(DT.Url))
                        {
                            dataList.Add(DT);
                            if (isDebug) AddLogs("Data List", $"{dataList.Count}. {DT.Name} - {DT.Url}");
                        }
                    }
                }

                AddLogs("Output", $"Tercapai target {dataList.Count} data.");
            }
            catch (Exception ex)
            {
                AddLogs("Error", $"GetListMaps {Step} {ex}");
            }
        }

        public async Task GetDetail(Data DTL)
        {
            int Step = 0;
            try
            {
                if (isStopped)
                {
                    AddLogs("Error", $"Stop Scrape");
                    return;
                }

                Step = 1; //Data
                var DT = new Data();

                Step = 2;
                webView21.CoreWebView2.Navigate(DTL.Url);
                await Task.Delay(4000);

                Step = 3;
                var detailLocation = await Page.WaitForXPathAsync("//div[contains(@role, 'main')]", new WaitForSelectorOptions { Visible = true });
                if (detailLocation == null)
                {
                    AddLogs("Error", "Detail Tidak Ditemukan Saat Ini");
                    return;
                }

                Step = 4;
                var review = await detailLocation.XPathAsync(".//span[contains(@aria-label, 'ulasan')]");
                if (review.Length > 0)
                {
                    DT.Reviews = await review[0].EvaluateFunctionAsync<string>("e => e.textContent", review[0]);
                }

                Step = 4;
                var name = await detailLocation.XPathAsync(".//h1");
                if (name.Length > 0)
                {
                    DT.Name = await name[0].EvaluateFunctionAsync<string>("e => e.textContent", name[0]);
                    //string extId = await name[0].EvaluateFunctionAsync<string>("e => e.textContent", name[0]);
                }

                Step = 5;
                var regionInformation = await Page.WaitForXPathAsync("//div[contains(@role, 'region')][2]", new WaitForSelectorOptions { Visible = true });
                if (regionInformation == null)
                {
                    AddLogs("Error", "Detail Informasi Tidak Ditemukan Saat Ini");
                    return;
                }

                Step = 6;
                var address = await regionInformation.XPathAsync(".//button[contains(@data-item-id, 'address')]");
                if (address.Length > 0)
                {
                    DT.Address = await address[0].EvaluateFunctionAsync<string>("e => e.ariaLabel", address[0]);
                }

                Step = 7;
                var website = await regionInformation.XPathAsync(".//a[contains(@data-item-id, 'authority')]");
                if (website.Length > 0)
                {
                    DT.Website = await website[0].EvaluateFunctionAsync<string>("e => e.href", website[0]);
                }

                Step = 8;
                var phone = await regionInformation.XPathAsync(".//button[contains(@data-item-id, 'phone')]");
                if (phone.Length > 0)
                {
                    DT.Phone = await phone[0].EvaluateFunctionAsync<string>("e => e.textContent", phone[0]);
                }

                if (isStopped)
                {
                    AddLogs("Error", $"Stop Scrape : {website}");
                    return;
                }

                Step = 10;
                if (!string.IsNullOrEmpty(DT.Name))
                {
                    Step = 11;
                    var dataSama = dataDetail.Where(c => c.Name == DT.Name).Count();

                    if (dataSama <= 0)
                    {
                        Step = 12;
                        AddResult(DT);

                        if (isDebug)
                        {
                            AddLogs("Result", DT.SerializeJson());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                AddLogs("Error", $"Get Detail {Step}, {ex}");
            }
        }

        #endregion Logic Scrape
    }
}