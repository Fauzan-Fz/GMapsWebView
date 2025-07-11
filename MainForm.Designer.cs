namespace GMapsWebView
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pageProses = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnStop = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.num_JumlahData = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.checkbox_Debug = new System.Windows.Forms.CheckBox();
            this.checkBox_Image = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.pageResult = new System.Windows.Forms.TabPage();
            this.dgvHasil = new System.Windows.Forms.DataGridView();
            this.Nama_Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone_Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email_Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Website_Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating_Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ulasan_Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alamat_Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageLog = new System.Windows.Forms.TabPage();
            this.dgvLogs = new System.Windows.Forms.DataGridView();
            this.id_logs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeStamp_logs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type_Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_logs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.logs_text = new System.Windows.Forms.Label();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.Export_Excel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.pageProses.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_JumlahData)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.pageResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHasil)).BeginInit();
            this.pageLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.webView21, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.28328F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.71672F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1325, 649);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.pageProses);
            this.tabControl1.Controls.Add(this.pageResult);
            this.tabControl1.Controls.Add(this.pageLog);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(4, 419);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(28, 8);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1317, 176);
            this.tabControl1.TabIndex = 0;
            // 
            // pageProses
            // 
            this.pageProses.Controls.Add(this.Export_Excel);
            this.pageProses.Controls.Add(this.tableLayoutPanel3);
            this.pageProses.Location = new System.Drawing.Point(4, 4);
            this.pageProses.Margin = new System.Windows.Forms.Padding(4);
            this.pageProses.Name = "pageProses";
            this.pageProses.Padding = new System.Windows.Forms.Padding(4);
            this.pageProses.Size = new System.Drawing.Size(1309, 128);
            this.pageProses.TabIndex = 0;
            this.pageProses.Text = "Proses";
            this.pageProses.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.48148F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.18518F));
            this.tableLayoutPanel3.Controls.Add(this.btnStop, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.num_JumlahData, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnStart, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(8, 30);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(720, 142);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Red;
            this.btnStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStop.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Location = new System.Drawing.Point(506, 75);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(210, 63);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 71);
            this.label3.TabIndex = 0;
            this.label3.Text = "Target List";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 71);
            this.label4.TabIndex = 1;
            this.label4.Text = "Opsi";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // num_JumlahData
            // 
            this.num_JumlahData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num_JumlahData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_JumlahData.Location = new System.Drawing.Point(244, 18);
            this.num_JumlahData.Margin = new System.Windows.Forms.Padding(4, 18, 4, 4);
            this.num_JumlahData.Name = "num_JumlahData";
            this.num_JumlahData.Size = new System.Drawing.Size(254, 34);
            this.num_JumlahData.TabIndex = 2;
            this.num_JumlahData.ValueChanged += new System.EventHandler(this.JumlahSetTarget);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.checkbox_Debug, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.checkBox_Image, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(241, 72);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(259, 69);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // checkbox_Debug
            // 
            this.checkbox_Debug.AutoSize = true;
            this.checkbox_Debug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkbox_Debug.Location = new System.Drawing.Point(4, 4);
            this.checkbox_Debug.Margin = new System.Windows.Forms.Padding(4);
            this.checkbox_Debug.Name = "checkbox_Debug";
            this.checkbox_Debug.Size = new System.Drawing.Size(121, 61);
            this.checkbox_Debug.TabIndex = 0;
            this.checkbox_Debug.Text = "Debug";
            this.checkbox_Debug.UseVisualStyleBackColor = true;
            this.checkbox_Debug.CheckedChanged += new System.EventHandler(this.Debug_Check);
            // 
            // checkBox_Image
            // 
            this.checkBox_Image.AutoSize = true;
            this.checkBox_Image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox_Image.Location = new System.Drawing.Point(133, 4);
            this.checkBox_Image.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_Image.Name = "checkBox_Image";
            this.checkBox_Image.Size = new System.Drawing.Size(122, 61);
            this.checkBox_Image.TabIndex = 1;
            this.checkBox_Image.Text = "Muat Gambar";
            this.checkBox_Image.UseVisualStyleBackColor = true;
            this.checkBox_Image.CheckedChanged += new System.EventHandler(this.Image_Load);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(506, 4);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(210, 63);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.StartScrape);
            // 
            // pageResult
            // 
            this.pageResult.Controls.Add(this.dgvHasil);
            this.pageResult.Location = new System.Drawing.Point(4, 4);
            this.pageResult.Margin = new System.Windows.Forms.Padding(4);
            this.pageResult.Name = "pageResult";
            this.pageResult.Padding = new System.Windows.Forms.Padding(4);
            this.pageResult.Size = new System.Drawing.Size(1309, 128);
            this.pageResult.TabIndex = 1;
            this.pageResult.Text = "Hasil";
            this.pageResult.UseVisualStyleBackColor = true;
            // 
            // dgvHasil
            // 
            this.dgvHasil.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHasil.BackgroundColor = System.Drawing.Color.White;
            this.dgvHasil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHasil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nama_Result,
            this.Phone_Result,
            this.Email_Result,
            this.Website_Result,
            this.Rating_Result,
            this.Ulasan_Result,
            this.Alamat_Result});
            this.dgvHasil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHasil.Location = new System.Drawing.Point(4, 4);
            this.dgvHasil.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHasil.Name = "dgvHasil";
            this.dgvHasil.RowHeadersWidth = 51;
            this.dgvHasil.Size = new System.Drawing.Size(1301, 120);
            this.dgvHasil.TabIndex = 0;
            // 
            // Nama_Result
            // 
            this.Nama_Result.HeaderText = "Nama";
            this.Nama_Result.MinimumWidth = 6;
            this.Nama_Result.Name = "Nama_Result";
            // 
            // Phone_Result
            // 
            this.Phone_Result.HeaderText = "Phone";
            this.Phone_Result.MinimumWidth = 6;
            this.Phone_Result.Name = "Phone_Result";
            // 
            // Email_Result
            // 
            this.Email_Result.HeaderText = "Email";
            this.Email_Result.MinimumWidth = 6;
            this.Email_Result.Name = "Email_Result";
            // 
            // Website_Result
            // 
            this.Website_Result.HeaderText = "Website";
            this.Website_Result.MinimumWidth = 6;
            this.Website_Result.Name = "Website_Result";
            // 
            // Rating_Result
            // 
            this.Rating_Result.HeaderText = "Rating";
            this.Rating_Result.MinimumWidth = 6;
            this.Rating_Result.Name = "Rating_Result";
            // 
            // Ulasan_Result
            // 
            this.Ulasan_Result.HeaderText = "Ulasan";
            this.Ulasan_Result.MinimumWidth = 6;
            this.Ulasan_Result.Name = "Ulasan_Result";
            // 
            // Alamat_Result
            // 
            this.Alamat_Result.HeaderText = "Alamat";
            this.Alamat_Result.MinimumWidth = 6;
            this.Alamat_Result.Name = "Alamat_Result";
            // 
            // pageLog
            // 
            this.pageLog.Controls.Add(this.dgvLogs);
            this.pageLog.Location = new System.Drawing.Point(4, 4);
            this.pageLog.Margin = new System.Windows.Forms.Padding(4);
            this.pageLog.Name = "pageLog";
            this.pageLog.Padding = new System.Windows.Forms.Padding(4);
            this.pageLog.Size = new System.Drawing.Size(1309, 128);
            this.pageLog.TabIndex = 2;
            this.pageLog.Text = "Logs";
            this.pageLog.UseVisualStyleBackColor = true;
            // 
            // dgvLogs
            // 
            this.dgvLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLogs.BackgroundColor = System.Drawing.Color.White;
            this.dgvLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_logs,
            this.TimeStamp_logs,
            this.Type_Result,
            this.Data_logs});
            this.dgvLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLogs.Location = new System.Drawing.Point(4, 4);
            this.dgvLogs.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLogs.Name = "dgvLogs";
            this.dgvLogs.RowHeadersWidth = 51;
            this.dgvLogs.Size = new System.Drawing.Size(1301, 120);
            this.dgvLogs.TabIndex = 0;
            // 
            // id_logs
            // 
            this.id_logs.HeaderText = "id";
            this.id_logs.MinimumWidth = 6;
            this.id_logs.Name = "id_logs";
            this.id_logs.Visible = false;
            // 
            // TimeStamp_logs
            // 
            this.TimeStamp_logs.HeaderText = "Waktu";
            this.TimeStamp_logs.MinimumWidth = 6;
            this.TimeStamp_logs.Name = "TimeStamp_logs";
            // 
            // Type_Result
            // 
            this.Type_Result.HeaderText = "Jenis";
            this.Type_Result.MinimumWidth = 6;
            this.Type_Result.Name = "Type_Result";
            // 
            // Data_logs
            // 
            this.Data_logs.HeaderText = "Data";
            this.Data_logs.MinimumWidth = 6;
            this.Data_logs.Name = "Data_logs";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.logs_text, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 603);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1317, 42);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Maps";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // logs_text
            // 
            this.logs_text.AutoSize = true;
            this.logs_text.BackColor = System.Drawing.Color.Silver;
            this.logs_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logs_text.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logs_text.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.logs_text.Location = new System.Drawing.Point(83, 0);
            this.logs_text.Name = "logs_text";
            this.logs_text.Size = new System.Drawing.Size(1231, 42);
            this.logs_text.TabIndex = 1;
            this.logs_text.Text = "Open Application";
            this.logs_text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView21.Location = new System.Drawing.Point(4, 4);
            this.webView21.Margin = new System.Windows.Forms.Padding(4);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(1317, 407);
            this.webView21.TabIndex = 2;
            this.webView21.ZoomFactor = 1D;
            // 
            // Export_Excel
            // 
            this.Export_Excel.BackColor = System.Drawing.Color.Green;
            this.Export_Excel.ForeColor = System.Drawing.Color.White;
            this.Export_Excel.Location = new System.Drawing.Point(745, 39);
            this.Export_Excel.Name = "Export_Excel";
            this.Export_Excel.Size = new System.Drawing.Size(225, 58);
            this.Export_Excel.TabIndex = 3;
            this.Export_Excel.Text = "Export ke excel";
            this.Export_Excel.UseVisualStyleBackColor = false;
            this.Export_Excel.Click += new System.EventHandler(this.Export_Excel_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 649);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.pageProses.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_JumlahData)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.pageResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHasil)).EndInit();
            this.pageLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage pageProses;
        private System.Windows.Forms.TabPage pageResult;
        private System.Windows.Forms.TabPage pageLog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label logs_text;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown num_JumlahData;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.CheckBox checkbox_Debug;
        private System.Windows.Forms.CheckBox checkBox_Image;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.DataGridView dgvHasil;
        private System.Windows.Forms.DataGridView dgvLogs;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama_Result;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone_Result;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email_Result;
        private System.Windows.Forms.DataGridViewTextBoxColumn Website_Result;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rating_Result;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ulasan_Result;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alamat_Result;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_logs;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeStamp_logs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type_Result;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_logs;
        private System.Windows.Forms.Button Export_Excel;
    }
}

