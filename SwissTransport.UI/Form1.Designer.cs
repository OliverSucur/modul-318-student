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
            this.txtHaltestelleVon = new System.Windows.Forms.TextBox();
            this.txtHaltestelleBis = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnVerbindungenSuchen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.listHaltestelleBis = new System.Windows.Forms.ListBox();
            this.listHaltestelleVon = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHaltestelleVon
            // 
            this.txtHaltestelleVon.Location = new System.Drawing.Point(45, 27);
            this.txtHaltestelleVon.Name = "txtHaltestelleVon";
            this.txtHaltestelleVon.Size = new System.Drawing.Size(194, 20);
            this.txtHaltestelleVon.TabIndex = 0;
            this.txtHaltestelleVon.TextChanged += new System.EventHandler(this.txtHaltestelleVon_Suchen);
            // 
            // txtHaltestelleBis
            // 
            this.txtHaltestelleBis.Location = new System.Drawing.Point(347, 27);
            this.txtHaltestelleBis.Name = "txtHaltestelleBis";
            this.txtHaltestelleBis.Size = new System.Drawing.Size(194, 20);
            this.txtHaltestelleBis.TabIndex = 1;
            this.txtHaltestelleBis.TextChanged += new System.EventHandler(this.btnVerbindungenSuchen_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(45, 81);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 193);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(496, 184);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnVerbindungenSuchen
            // 
            this.btnVerbindungenSuchen.Location = new System.Drawing.Point(347, 82);
            this.btnVerbindungenSuchen.Name = "btnVerbindungenSuchen";
            this.btnVerbindungenSuchen.Size = new System.Drawing.Size(194, 23);
            this.btnVerbindungenSuchen.TabIndex = 4;
            this.btnVerbindungenSuchen.Text = "Verbindungen suchen";
            this.btnVerbindungenSuchen.UseVisualStyleBackColor = true;
            this.btnVerbindungenSuchen.Click += new System.EventHandler(this.btnVerbindungenSuchen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(613, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Erweiterte Suche";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(618, 93);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(184, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.Text = "Verbindungen ab einer Haltestelle";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(45, 394);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Weiterleiten";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(618, 133);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(184, 17);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.Text = "Ortschaft einer Haltestelle suchen";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(618, 174);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(217, 17);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.Text = "Haltestellen in der Nähe anzeigen lassen";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // listHaltestelleBis
            // 
            this.listHaltestelleBis.FormattingEnabled = true;
            this.listHaltestelleBis.Location = new System.Drawing.Point(347, 53);
            this.listHaltestelleBis.Name = "listHaltestelleBis";
            this.listHaltestelleBis.Size = new System.Drawing.Size(194, 134);
            this.listHaltestelleBis.TabIndex = 10;
            this.listHaltestelleBis.Click += new System.EventHandler(this.listHaltestelleBis_SelectedIndexChanged);
            // 
            // listHaltestelleVon
            // 
            this.listHaltestelleVon.FormattingEnabled = true;
            this.listHaltestelleVon.Location = new System.Drawing.Point(45, 53);
            this.listHaltestelleVon.Name = "listHaltestelleVon";
            this.listHaltestelleVon.Size = new System.Drawing.Size(194, 134);
            this.listHaltestelleVon.TabIndex = 11;
            this.listHaltestelleVon.Click += new System.EventHandler(this.listHaltestelleVon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 450);
            this.Controls.Add(this.listHaltestelleVon);
            this.Controls.Add(this.listHaltestelleBis);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVerbindungenSuchen);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtHaltestelleBis);
            this.Controls.Add(this.txtHaltestelleVon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHaltestelleVon;
        private System.Windows.Forms.TextBox txtHaltestelleBis;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnVerbindungenSuchen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.ListBox listHaltestelleBis;
        private System.Windows.Forms.ListBox listHaltestelleVon;
    }
}

