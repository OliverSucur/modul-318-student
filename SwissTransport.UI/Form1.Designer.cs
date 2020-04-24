namespace SwissTransport.UI
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtHaltestelleVon = new System.Windows.Forms.TextBox();
            this.txtHaltestelleBis = new System.Windows.Forms.TextBox();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnVerbindungenSuchen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWeiterleiten = new System.Windows.Forms.Button();
            this.listHaltestelleBis = new System.Windows.Forms.ListBox();
            this.checkOrtschaft = new System.Windows.Forms.CheckBox();
            this.checkVerbindungen = new System.Windows.Forms.CheckBox();
            this.checkNaehe = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMeinung = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.listHaltestelleVon = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHaltestelleVon
            // 
            this.txtHaltestelleVon.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtHaltestelleVon.Location = new System.Drawing.Point(73, 100);
            this.txtHaltestelleVon.Name = "txtHaltestelleVon";
            this.txtHaltestelleVon.Size = new System.Drawing.Size(195, 20);
            this.txtHaltestelleVon.TabIndex = 0;
            this.txtHaltestelleVon.TextChanged += new System.EventHandler(this.txtHaltestelleVon_Suchen);
            // 
            // txtHaltestelleBis
            // 
            this.txtHaltestelleBis.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtHaltestelleBis.Location = new System.Drawing.Point(421, 100);
            this.txtHaltestelleBis.Name = "txtHaltestelleBis";
            this.txtHaltestelleBis.Size = new System.Drawing.Size(188, 20);
            this.txtHaltestelleBis.TabIndex = 1;
            this.txtHaltestelleBis.TextChanged += new System.EventHandler(this.txtHaltestelleBis_TextChanged);
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = "hh:mm";
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(189, 143);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(79, 20);
            this.timePicker.TabIndex = 2;
            this.timePicker.Value = new System.DateTime(2020, 4, 24, 15, 45, 54, 0);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(73, 266);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(536, 184);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnVerbindungenSuchen
            // 
            this.btnVerbindungenSuchen.Location = new System.Drawing.Point(421, 140);
            this.btnVerbindungenSuchen.Name = "btnVerbindungenSuchen";
            this.btnVerbindungenSuchen.Size = new System.Drawing.Size(188, 23);
            this.btnVerbindungenSuchen.TabIndex = 4;
            this.btnVerbindungenSuchen.Text = "Verbindungen suchen";
            this.btnVerbindungenSuchen.UseVisualStyleBackColor = true;
            this.btnVerbindungenSuchen.Click += new System.EventHandler(this.btnVerbindungenSuchen_Click);
            this.btnVerbindungenSuchen.Enter += new System.EventHandler(this.btnVerbindungenSuchen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(678, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Erweiterte Suche";
            // 
            // btnWeiterleiten
            // 
            this.btnWeiterleiten.Location = new System.Drawing.Point(74, 456);
            this.btnWeiterleiten.Name = "btnWeiterleiten";
            this.btnWeiterleiten.Size = new System.Drawing.Size(194, 23);
            this.btnWeiterleiten.TabIndex = 7;
            this.btnWeiterleiten.Text = "Suchresultate weiterleiten";
            this.btnWeiterleiten.UseVisualStyleBackColor = true;
            this.btnWeiterleiten.Click += new System.EventHandler(this.btnWeiterleiten_Click);
            // 
            // listHaltestelleBis
            // 
            this.listHaltestelleBis.FormattingEnabled = true;
            this.listHaltestelleBis.Location = new System.Drawing.Point(421, 126);
            this.listHaltestelleBis.Name = "listHaltestelleBis";
            this.listHaltestelleBis.Size = new System.Drawing.Size(188, 134);
            this.listHaltestelleBis.TabIndex = 10;
            this.listHaltestelleBis.Click += new System.EventHandler(this.listHaltestelleBis_SelectedIndexChanged);
            // 
            // checkOrtschaft
            // 
            this.checkOrtschaft.AutoSize = true;
            this.checkOrtschaft.Location = new System.Drawing.Point(683, 172);
            this.checkOrtschaft.Name = "checkOrtschaft";
            this.checkOrtschaft.Size = new System.Drawing.Size(185, 17);
            this.checkOrtschaft.TabIndex = 12;
            this.checkOrtschaft.Text = "Ortschaft einer Haltestelle suchen";
            this.checkOrtschaft.UseVisualStyleBackColor = true;
            this.checkOrtschaft.CheckedChanged += new System.EventHandler(this.checkOrtschaft_CheckedChanged);
            // 
            // checkVerbindungen
            // 
            this.checkVerbindungen.AutoSize = true;
            this.checkVerbindungen.Location = new System.Drawing.Point(683, 140);
            this.checkVerbindungen.Name = "checkVerbindungen";
            this.checkVerbindungen.Size = new System.Drawing.Size(223, 17);
            this.checkVerbindungen.TabIndex = 12;
            this.checkVerbindungen.Text = "Verbindungen ab einer Haltestelle suchen";
            this.checkVerbindungen.UseVisualStyleBackColor = true;
            this.checkVerbindungen.CheckedChanged += new System.EventHandler(this.checkVerbindungen_CheckedChanged);
            // 
            // checkNaehe
            // 
            this.checkNaehe.AutoSize = true;
            this.checkNaehe.Location = new System.Drawing.Point(683, 205);
            this.checkNaehe.Name = "checkNaehe";
            this.checkNaehe.Size = new System.Drawing.Size(218, 17);
            this.checkNaehe.TabIndex = 13;
            this.checkNaehe.Text = "Haltestellen in der Nähe anzeigen lassen";
            this.checkNaehe.UseVisualStyleBackColor = true;
            this.checkNaehe.CheckedChanged += new System.EventHandler(this.checkNaehe_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(678, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Kritik";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(680, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 26);
            this.label3.TabIndex = 15;
            this.label3.Text = "Damit wir uns laufend verbessern können, \r\nwären wir froh über Ihre Meinung.";
            // 
            // btnMeinung
            // 
            this.btnMeinung.Location = new System.Drawing.Point(683, 427);
            this.btnMeinung.Name = "btnMeinung";
            this.btnMeinung.Size = new System.Drawing.Size(205, 23);
            this.btnMeinung.TabIndex = 16;
            this.btnMeinung.Text = "Meinung abgeben";
            this.btnMeinung.UseVisualStyleBackColor = true;
            this.btnMeinung.Click += new System.EventHandler(this.btnMeinung_Click);
            // 
            // datePicker
            // 
            this.datePicker.CustomFormat = "yyyy-MM-dd";
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(73, 143);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(110, 20);
            this.datePicker.TabIndex = 17;
            this.datePicker.Value = new System.DateTime(2020, 4, 24, 15, 44, 37, 0);
            // 
            // listHaltestelleVon
            // 
            this.listHaltestelleVon.FormattingEnabled = true;
            this.listHaltestelleVon.Location = new System.Drawing.Point(73, 126);
            this.listHaltestelleVon.Name = "listHaltestelleVon";
            this.listHaltestelleVon.Size = new System.Drawing.Size(195, 134);
            this.listHaltestelleVon.TabIndex = 18;
            this.listHaltestelleVon.Click += new System.EventHandler(this.listHaltestelleVon_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(320, 43);
            this.label4.TabIndex = 19;
            this.label4.Text = "ÖV-Applikation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Von:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(379, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Nach:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(931, 513);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listHaltestelleVon);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.btnMeinung);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkNaehe);
            this.Controls.Add(this.checkVerbindungen);
            this.Controls.Add(this.checkOrtschaft);
            this.Controls.Add(this.listHaltestelleBis);
            this.Controls.Add(this.btnWeiterleiten);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVerbindungenSuchen);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.txtHaltestelleBis);
            this.Controls.Add(this.txtHaltestelleVon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ÖV-Applikation";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHaltestelleVon;
        private System.Windows.Forms.TextBox txtHaltestelleBis;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnVerbindungenSuchen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWeiterleiten;
        private System.Windows.Forms.ListBox listHaltestelleBis;
        private System.Windows.Forms.CheckBox checkOrtschaft;
        private System.Windows.Forms.CheckBox checkVerbindungen;
        private System.Windows.Forms.CheckBox checkNaehe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMeinung;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.ListBox listHaltestelleVon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

