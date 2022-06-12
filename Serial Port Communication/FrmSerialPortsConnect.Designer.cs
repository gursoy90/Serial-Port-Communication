namespace Serial_Port_Communication
{
    partial class FrmSerialPortsConnect
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
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.btnGonder = new DevExpress.XtraEditors.SimpleButton();
            this.btnYeni = new DevExpress.XtraEditors.SimpleButton();
            this.btnBaglan = new DevExpress.XtraEditors.SimpleButton();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.lblAlinan = new System.Windows.Forms.Label();
            this.lblGonderilenVeri = new System.Windows.Forms.Label();
            this.lblStopBit = new System.Windows.Forms.Label();
            this.comboStopBiti = new System.Windows.Forms.ComboBox();
            this.lblEslikBit = new System.Windows.Forms.Label();
            this.comboParity = new System.Windows.Forms.ComboBox();
            this.comboDataBit = new System.Windows.Forms.ComboBox();
            this.lblDatabit = new System.Windows.Forms.Label();
            this.comboBaudRate = new System.Windows.Forms.ComboBox();
            this.txtAlinan = new System.Windows.Forms.TextBox();
            this.lstDurum = new System.Windows.Forms.ListBox();
            this.txtGonderilen = new System.Windows.Forms.TextBox();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.lblPortSec = new System.Windows.Forms.Label();
            this.comboPortAdi = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnTemizle
            // 
            this.btnTemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnTemizle.Appearance.Options.UseFont = true;
            this.btnTemizle.Appearance.Options.UseForeColor = true;
            this.btnTemizle.Location = new System.Drawing.Point(368, 519);
            this.btnTemizle.LookAndFeel.SkinMaskColor = System.Drawing.SystemColors.ControlDark;
            this.btnTemizle.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(548, 29);
            this.btnTemizle.TabIndex = 91;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnGonder
            // 
            this.btnGonder.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGonder.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnGonder.Appearance.Options.UseFont = true;
            this.btnGonder.Appearance.Options.UseForeColor = true;
            this.btnGonder.Location = new System.Drawing.Point(368, 245);
            this.btnGonder.LookAndFeel.SkinMaskColor = System.Drawing.SystemColors.ControlDark;
            this.btnGonder.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(548, 29);
            this.btnGonder.TabIndex = 90;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeni.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnYeni.Appearance.Options.UseFont = true;
            this.btnYeni.Appearance.Options.UseForeColor = true;
            this.btnYeni.Location = new System.Drawing.Point(205, 244);
            this.btnYeni.LookAndFeel.SkinMaskColor = System.Drawing.Color.Gray;
            this.btnYeni.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(121, 30);
            this.btnYeni.TabIndex = 89;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnBaglan
            // 
            this.btnBaglan.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBaglan.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnBaglan.Appearance.Options.UseFont = true;
            this.btnBaglan.Appearance.Options.UseForeColor = true;
            this.btnBaglan.Location = new System.Drawing.Point(16, 244);
            this.btnBaglan.LookAndFeel.SkinMaskColor = System.Drawing.Color.Gray;
            this.btnBaglan.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnBaglan.Name = "btnBaglan";
            this.btnBaglan.Size = new System.Drawing.Size(183, 31);
            this.btnBaglan.TabIndex = 88;
            this.btnBaglan.Text = "Bağlan";
            this.btnBaglan.Click += new System.EventHandler(this.btnBaglan_Click);
            // 
            // lblBaslik
            // 
            this.lblBaslik.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.ForeColor = System.Drawing.Color.Black;
            this.lblBaslik.Location = new System.Drawing.Point(13, 9);
            this.lblBaslik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(903, 45);
            this.lblBaslik.TabIndex = 87;
            this.lblBaslik.Text = "Ramazan Gürsoy";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDurum
            // 
            this.lblDurum.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.Location = new System.Drawing.Point(13, 289);
            this.lblDurum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(313, 29);
            this.lblDurum.TabIndex = 86;
            this.lblDurum.Text = "DURUM";
            this.lblDurum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAlinan
            // 
            this.lblAlinan.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblAlinan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlinan.ForeColor = System.Drawing.Color.Black;
            this.lblAlinan.Location = new System.Drawing.Point(368, 290);
            this.lblAlinan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlinan.Name = "lblAlinan";
            this.lblAlinan.Size = new System.Drawing.Size(548, 29);
            this.lblAlinan.TabIndex = 77;
            this.lblAlinan.Text = "ALINAN VERİ";
            this.lblAlinan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGonderilenVeri
            // 
            this.lblGonderilenVeri.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblGonderilenVeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGonderilenVeri.ForeColor = System.Drawing.Color.Black;
            this.lblGonderilenVeri.Location = new System.Drawing.Point(368, 73);
            this.lblGonderilenVeri.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGonderilenVeri.Name = "lblGonderilenVeri";
            this.lblGonderilenVeri.Size = new System.Drawing.Size(548, 24);
            this.lblGonderilenVeri.TabIndex = 76;
            this.lblGonderilenVeri.Text = "GÖNDERİLEN VERİ";
            this.lblGonderilenVeri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStopBit
            // 
            this.lblStopBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStopBit.Location = new System.Drawing.Point(13, 172);
            this.lblStopBit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStopBit.Name = "lblStopBit";
            this.lblStopBit.Size = new System.Drawing.Size(155, 24);
            this.lblStopBit.TabIndex = 75;
            this.lblStopBit.Text = "Stop Bit";
            // 
            // comboStopBiti
            // 
            this.comboStopBiti.AutoCompleteCustomSource.AddRange(new string[] {
            "None",
            "One",
            "Two",
            "One"});
            this.comboStopBiti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboStopBiti.FormattingEnabled = true;
            this.comboStopBiti.Location = new System.Drawing.Point(176, 171);
            this.comboStopBiti.Margin = new System.Windows.Forms.Padding(4);
            this.comboStopBiti.Name = "comboStopBiti";
            this.comboStopBiti.Size = new System.Drawing.Size(150, 24);
            this.comboStopBiti.TabIndex = 82;
            // 
            // lblEslikBit
            // 
            this.lblEslikBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEslikBit.Location = new System.Drawing.Point(13, 204);
            this.lblEslikBit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEslikBit.Name = "lblEslikBit";
            this.lblEslikBit.Size = new System.Drawing.Size(155, 24);
            this.lblEslikBit.TabIndex = 74;
            this.lblEslikBit.Text = "Parity";
            // 
            // comboParity
            // 
            this.comboParity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboParity.FormattingEnabled = true;
            this.comboParity.Location = new System.Drawing.Point(176, 203);
            this.comboParity.Margin = new System.Windows.Forms.Padding(4);
            this.comboParity.Name = "comboParity";
            this.comboParity.Size = new System.Drawing.Size(150, 24);
            this.comboParity.TabIndex = 81;
            // 
            // comboDataBit
            // 
            this.comboDataBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboDataBit.FormattingEnabled = true;
            this.comboDataBit.Location = new System.Drawing.Point(176, 139);
            this.comboDataBit.Margin = new System.Windows.Forms.Padding(4);
            this.comboDataBit.Name = "comboDataBit";
            this.comboDataBit.Size = new System.Drawing.Size(150, 24);
            this.comboDataBit.TabIndex = 80;
            // 
            // lblDatabit
            // 
            this.lblDatabit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDatabit.Location = new System.Drawing.Point(13, 139);
            this.lblDatabit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatabit.Name = "lblDatabit";
            this.lblDatabit.Size = new System.Drawing.Size(155, 24);
            this.lblDatabit.TabIndex = 73;
            this.lblDatabit.Text = "Data Bit";
            // 
            // comboBaudRate
            // 
            this.comboBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBaudRate.FormattingEnabled = true;
            this.comboBaudRate.Location = new System.Drawing.Point(176, 107);
            this.comboBaudRate.Margin = new System.Windows.Forms.Padding(4);
            this.comboBaudRate.Name = "comboBaudRate";
            this.comboBaudRate.Size = new System.Drawing.Size(150, 24);
            this.comboBaudRate.TabIndex = 79;
            // 
            // txtAlinan
            // 
            this.txtAlinan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAlinan.Location = new System.Drawing.Point(368, 323);
            this.txtAlinan.Margin = new System.Windows.Forms.Padding(4);
            this.txtAlinan.Multiline = true;
            this.txtAlinan.Name = "txtAlinan";
            this.txtAlinan.ReadOnly = true;
            this.txtAlinan.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAlinan.Size = new System.Drawing.Size(548, 189);
            this.txtAlinan.TabIndex = 85;
            // 
            // lstDurum
            // 
            this.lstDurum.FormattingEnabled = true;
            this.lstDurum.Location = new System.Drawing.Point(13, 322);
            this.lstDurum.Margin = new System.Windows.Forms.Padding(4);
            this.lstDurum.Name = "lstDurum";
            this.lstDurum.Size = new System.Drawing.Size(313, 225);
            this.lstDurum.TabIndex = 83;
            // 
            // txtGonderilen
            // 
            this.txtGonderilen.Location = new System.Drawing.Point(368, 101);
            this.txtGonderilen.Margin = new System.Windows.Forms.Padding(4);
            this.txtGonderilen.Multiline = true;
            this.txtGonderilen.Name = "txtGonderilen";
            this.txtGonderilen.Size = new System.Drawing.Size(548, 128);
            this.txtGonderilen.TabIndex = 84;
            // 
            // lblBaudRate
            // 
            this.lblBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaudRate.Location = new System.Drawing.Point(13, 107);
            this.lblBaudRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(155, 24);
            this.lblBaudRate.TabIndex = 72;
            this.lblBaudRate.Text = "Speed (Baud Rate)";
            // 
            // lblPortSec
            // 
            this.lblPortSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPortSec.Location = new System.Drawing.Point(13, 75);
            this.lblPortSec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPortSec.Name = "lblPortSec";
            this.lblPortSec.Size = new System.Drawing.Size(155, 24);
            this.lblPortSec.TabIndex = 71;
            this.lblPortSec.Text = "Select Port";
            // 
            // comboPortAdi
            // 
            this.comboPortAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboPortAdi.FormattingEnabled = true;
            this.comboPortAdi.Location = new System.Drawing.Point(176, 75);
            this.comboPortAdi.Margin = new System.Windows.Forms.Padding(4);
            this.comboPortAdi.Name = "comboPortAdi";
            this.comboPortAdi.Size = new System.Drawing.Size(150, 24);
            this.comboPortAdi.TabIndex = 78;
            // 
            // FrmSerialPortsConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 556);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.btnBaglan);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.lblAlinan);
            this.Controls.Add(this.lblGonderilenVeri);
            this.Controls.Add(this.lblStopBit);
            this.Controls.Add(this.comboStopBiti);
            this.Controls.Add(this.lblEslikBit);
            this.Controls.Add(this.comboParity);
            this.Controls.Add(this.comboDataBit);
            this.Controls.Add(this.lblDatabit);
            this.Controls.Add(this.comboBaudRate);
            this.Controls.Add(this.txtAlinan);
            this.Controls.Add(this.lstDurum);
            this.Controls.Add(this.txtGonderilen);
            this.Controls.Add(this.lblBaudRate);
            this.Controls.Add(this.lblPortSec);
            this.Controls.Add(this.comboPortAdi);
            this.Name = "FrmSerialPortsConnect";
            this.Text = "Serial Port Connect";
            this.Load += new System.EventHandler(this.FrmSerialPortsConnect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private DevExpress.XtraEditors.SimpleButton btnGonder;
        private DevExpress.XtraEditors.SimpleButton btnYeni;
        private DevExpress.XtraEditors.SimpleButton btnBaglan;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label lblAlinan;
        private System.Windows.Forms.Label lblGonderilenVeri;
        private System.Windows.Forms.Label lblStopBit;
        private System.Windows.Forms.ComboBox comboStopBiti;
        private System.Windows.Forms.Label lblEslikBit;
        private System.Windows.Forms.ComboBox comboParity;
        private System.Windows.Forms.ComboBox comboDataBit;
        private System.Windows.Forms.Label lblDatabit;
        private System.Windows.Forms.ComboBox comboBaudRate;
        public System.Windows.Forms.TextBox txtAlinan;
        private System.Windows.Forms.ListBox lstDurum;
        private System.Windows.Forms.TextBox txtGonderilen;
        private System.Windows.Forms.Label lblBaudRate;
        private System.Windows.Forms.Label lblPortSec;
        private System.Windows.Forms.ComboBox comboPortAdi;
    }
}