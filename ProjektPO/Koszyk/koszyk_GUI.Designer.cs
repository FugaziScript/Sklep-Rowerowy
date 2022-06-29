
namespace Projekt_PO {
    partial class koszyk_GUI {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.koszyk_zawartosc_lista = new System.Windows.Forms.DataGridView();
            this.koszyk_label_title = new System.Windows.Forms.Label();
            this.koszyk_button_kup = new System.Windows.Forms.Button();
            this.koszyk_button_wyczysc = new System.Windows.Forms.Button();
            this.koszyk_ds_lp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.koszyk_ds_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.koszyk_ds_ilosc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.koszyk_ds_cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.koszyk_ds_wartosc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.koszyk_ds_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.koszyk_zawartosc_lista)).BeginInit();
            this.SuspendLayout();
            // 
            // koszyk_zawartosc_lista
            // 
            this.koszyk_zawartosc_lista.AllowUserToAddRows = false;
            this.koszyk_zawartosc_lista.AllowUserToDeleteRows = false;
            this.koszyk_zawartosc_lista.AllowUserToResizeRows = false;
            this.koszyk_zawartosc_lista.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DGV_CellBeginEdit);
            this.koszyk_zawartosc_lista.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellEndEdit);
            this.koszyk_zawartosc_lista.SelectionChanged += new System.EventHandler(this.DGV_SelectionChanged);
            this.koszyk_zawartosc_lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.koszyk_zawartosc_lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.koszyk_ds_lp,
            this.koszyk_ds_name,
            this.koszyk_ds_ilosc,
            this.koszyk_ds_cena,
            this.koszyk_ds_wartosc,
            this.koszyk_ds_ID});
            this.koszyk_zawartosc_lista.Location = new System.Drawing.Point(12, 36);
            this.koszyk_zawartosc_lista.Name = "koszyk_zawartosc_lista";
            this.koszyk_zawartosc_lista.RowHeadersVisible = false;
            this.koszyk_zawartosc_lista.Size = new System.Drawing.Size(489, 248);
            this.koszyk_zawartosc_lista.TabIndex = 0;
            // 
            // koszyk_label_title
            // 
            this.koszyk_label_title.AutoSize = true;
            this.koszyk_label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.koszyk_label_title.Location = new System.Drawing.Point(13, 13);
            this.koszyk_label_title.Name = "koszyk_label_title";
            this.koszyk_label_title.Size = new System.Drawing.Size(166, 20);
            this.koszyk_label_title.TabIndex = 1;
            this.koszyk_label_title.Text = "Zawartość koszyka:";
            // 
            // koszyk_button_kup
            // 
            this.koszyk_button_kup.Location = new System.Drawing.Point(17, 290);
            this.koszyk_button_kup.Name = "koszyk_button_kup";
            this.koszyk_button_kup.Size = new System.Drawing.Size(75, 23);
            this.koszyk_button_kup.TabIndex = 2;
            this.koszyk_button_kup.Text = "KUP";
            this.koszyk_button_kup.UseVisualStyleBackColor = true;
            this.koszyk_button_kup.Click += new System.EventHandler(this.koszyk_button_kup_Click);
            // 
            // koszyk_button_wyczysc
            // 
            this.koszyk_button_wyczysc.Location = new System.Drawing.Point(117, 290);
            this.koszyk_button_wyczysc.Name = "koszyk_button_wyczysc";
            this.koszyk_button_wyczysc.Size = new System.Drawing.Size(75, 23);
            this.koszyk_button_wyczysc.TabIndex = 3;
            this.koszyk_button_wyczysc.Text = "Wyczyść";
            this.koszyk_button_wyczysc.UseVisualStyleBackColor = true;
            this.koszyk_button_wyczysc.Click += new System.EventHandler(this.koszyk_button_wyczysc_Click);
            // 
            // koszyk_ds_lp
            // 
            this.koszyk_ds_lp.HeaderText = "Lp.:";
            this.koszyk_ds_lp.Name = "koszyk_ds_lp";
            this.koszyk_ds_lp.ReadOnly = true;
            this.koszyk_ds_lp.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.koszyk_ds_lp.Width = 30;
            // 
            // koszyk_ds_name
            // 
            this.koszyk_ds_name.HeaderText = "Nazwa:";
            this.koszyk_ds_name.Name = "koszyk_ds_name";
            this.koszyk_ds_name.ReadOnly = true;
            // 
            // koszyk_ds_ilosc
            // 
            this.koszyk_ds_ilosc.HeaderText = "Ilość:";
            this.koszyk_ds_ilosc.Name = "koszyk_ds_ilosc";
            this.koszyk_ds_ilosc.Width = 50;
            // 
            // koszyk_ds_cena
            // 
            this.koszyk_ds_cena.HeaderText = "Cena:";
            this.koszyk_ds_cena.Name = "koszyk_ds_cena";
            this.koszyk_ds_cena.ReadOnly = true;
            this.koszyk_ds_cena.Width = 70;
            // 
            // koszyk_ds_wartosc
            // 
            this.koszyk_ds_wartosc.HeaderText = "Wartość:";
            this.koszyk_ds_wartosc.Name = "koszyk_ds_wartosc";
            this.koszyk_ds_wartosc.ReadOnly = true;
            this.koszyk_ds_wartosc.Width = 70;
            // 
            // koszyk_ds_ID
            // 
            this.koszyk_ds_ID.HeaderText = "ID:";
            this.koszyk_ds_ID.Name = "koszyk_ds_ID";
            this.koszyk_ds_ID.ReadOnly = true;
            this.koszyk_ds_ID.Visible = false;
            // 
            // koszyk_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 317);
            this.Controls.Add(this.koszyk_button_wyczysc);
            this.Controls.Add(this.koszyk_button_kup);
            this.Controls.Add(this.koszyk_label_title);
            this.Controls.Add(this.koszyk_zawartosc_lista);
            this.Name = "koszyk_GUI";
            this.Text = "Koszyk";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.koszyk_GUI_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.koszyk_zawartosc_lista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView koszyk_zawartosc_lista;
        private System.Windows.Forms.Label koszyk_label_title;
        private System.Windows.Forms.Button koszyk_button_kup;
        private System.Windows.Forms.Button koszyk_button_wyczysc;
        private System.Windows.Forms.DataGridViewTextBoxColumn koszyk_ds_lp;
        private System.Windows.Forms.DataGridViewTextBoxColumn koszyk_ds_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn koszyk_ds_ilosc;
        private System.Windows.Forms.DataGridViewTextBoxColumn koszyk_ds_cena;
        private System.Windows.Forms.DataGridViewTextBoxColumn koszyk_ds_wartosc;
        private System.Windows.Forms.DataGridViewTextBoxColumn koszyk_ds_ID;
    }
}