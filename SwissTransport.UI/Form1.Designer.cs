﻿namespace SwissTransport.UI
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
            this.button2 = new System.Windows.Forms.Button();
            this.listHaltestelleBis = new System.Windows.Forms.ListBox();
            this.listHaltestelleVon = new System.Windows.Forms.ListBox();
            this.checkOrtschaft = new System.Windows.Forms.CheckBox();
            this.checkVerbindungen = new System.Windows.Forms.CheckBox();
            this.checkNaehe = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHaltestelleVon
            // 
            this.txtHaltestelleVon.Location = new System.Drawing.Point(45, 27);
            this.txtHaltestelleVon.Name = "txtHaltestelleVon";
            this.txtHaltestelleVon.Size = new System.Drawing.Size(200, 20);
            this.txtHaltestelleVon.TabIndex = 0;
            this.txtHaltestelleVon.TextChanged += new System.EventHandler(this.txtHaltestelleVon_Suchen);
            // 
            // txtHaltestelleBis
            // 
            this.txtHaltestelleBis.Location = new System.Drawing.Point(341, 27);
            this.txtHaltestelleBis.Name = "txtHaltestelleBis";
            this.txtHaltestelleBis.Size = new System.Drawing.Size(200, 20);
            this.txtHaltestelleBis.TabIndex = 1;
            this.txtHaltestelleBis.TextChanged += new System.EventHandler(this.txtHaltestelleBis_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(45, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Weiterleiten";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // listHaltestelleBis
            // 
            this.listHaltestelleBis.FormattingEnabled = true;
            this.listHaltestelleBis.Location = new System.Drawing.Point(341, 53);
            this.listHaltestelleBis.Name = "listHaltestelleBis";
            this.listHaltestelleBis.Size = new System.Drawing.Size(200, 134);
            this.listHaltestelleBis.TabIndex = 10;
            this.listHaltestelleBis.Click += new System.EventHandler(this.listHaltestelleBis_SelectedIndexChanged);
            // 
            // listHaltestelleVon
            // 
            this.listHaltestelleVon.FormattingEnabled = true;
            this.listHaltestelleVon.Location = new System.Drawing.Point(45, 53);
            this.listHaltestelleVon.Name = "listHaltestelleVon";
            this.listHaltestelleVon.Size = new System.Drawing.Size(200, 134);
            this.listHaltestelleVon.TabIndex = 11;
            this.listHaltestelleVon.Click += new System.EventHandler(this.listHaltestelleVon_Click);
            // 
            // checkOrtschaft
            // 
            this.checkOrtschaft.AutoSize = true;
            this.checkOrtschaft.Location = new System.Drawing.Point(618, 99);
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
            this.checkVerbindungen.Location = new System.Drawing.Point(618, 67);
            this.checkVerbindungen.Name = "checkVerbindungen";
            this.checkVerbindungen.Size = new System.Drawing.Size(185, 17);
            this.checkVerbindungen.TabIndex = 12;
            this.checkVerbindungen.Text = "Verbindungen ab einer Haltestelle";
            this.checkVerbindungen.UseVisualStyleBackColor = true;
            this.checkVerbindungen.CheckedChanged += new System.EventHandler(this.checkVerbindungen_CheckedChanged);
            // 
            // checkNaehe
            // 
            this.checkNaehe.AutoSize = true;
            this.checkNaehe.Location = new System.Drawing.Point(618, 132);
            this.checkNaehe.Name = "checkNaehe";
            this.checkNaehe.Size = new System.Drawing.Size(218, 17);
            this.checkNaehe.TabIndex = 13;
            this.checkNaehe.Text = "Haltestellen in der Nähe anzeigen lassen";
            this.checkNaehe.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(880, 419);
            this.Controls.Add(this.checkNaehe);
            this.Controls.Add(this.checkVerbindungen);
            this.Controls.Add(this.checkOrtschaft);
            this.Controls.Add(this.listHaltestelleVon);
            this.Controls.Add(this.listHaltestelleBis);
            this.Controls.Add(this.button2);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listHaltestelleBis;
        private System.Windows.Forms.ListBox listHaltestelleVon;
        private System.Windows.Forms.CheckBox checkOrtschaft;
        private System.Windows.Forms.CheckBox checkVerbindungen;
        private System.Windows.Forms.CheckBox checkNaehe;
    }
}

