
namespace Projekt_PO
{
    partial class FormDodawanie
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
            this.listBox_typ = new System.Windows.Forms.ListBox();
            this.label_wzor = new System.Windows.Forms.Label();
            this.textBox_dane = new System.Windows.Forms.TextBox();
            this.button_dodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_typ
            // 
            this.listBox_typ.FormattingEnabled = true;
            this.listBox_typ.Items.AddRange(new object[] {
            "Rama",
            "Hamulec",
            "Amortyzator Przedni",
            "Amortyzator Tylni",
            "Siodełko",
            "Kierownica",
            "Koło",
            "Przerzutka"});
            this.listBox_typ.Location = new System.Drawing.Point(25, 26);
            this.listBox_typ.Name = "listBox_typ";
            this.listBox_typ.Size = new System.Drawing.Size(120, 134);
            this.listBox_typ.TabIndex = 0;
            this.listBox_typ.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label_wzor
            // 
            this.label_wzor.AutoSize = true;
            this.label_wzor.Location = new System.Drawing.Point(165, 39);
            this.label_wzor.Name = "label_wzor";
            this.label_wzor.Size = new System.Drawing.Size(62, 13);
            this.label_wzor.TabIndex = 1;
            this.label_wzor.Text = "Wybierz typ";
            // 
            // textBox_dane
            // 
            this.textBox_dane.Location = new System.Drawing.Point(168, 76);
            this.textBox_dane.Name = "textBox_dane";
            this.textBox_dane.Size = new System.Drawing.Size(446, 20);
            this.textBox_dane.TabIndex = 2;
            // 
            // button_dodaj
            // 
            this.button_dodaj.Location = new System.Drawing.Point(352, 124);
            this.button_dodaj.Name = "button_dodaj";
            this.button_dodaj.Size = new System.Drawing.Size(75, 23);
            this.button_dodaj.TabIndex = 3;
            this.button_dodaj.Text = "Dodaj";
            this.button_dodaj.UseVisualStyleBackColor = true;
            this.button_dodaj.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormDodawanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 193);
            this.Controls.Add(this.button_dodaj);
            this.Controls.Add(this.textBox_dane);
            this.Controls.Add(this.label_wzor);
            this.Controls.Add(this.listBox_typ);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormDodawanie";
            this.Text = "Dodawanie elementów";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_typ;
        private System.Windows.Forms.Label label_wzor;
        private System.Windows.Forms.TextBox textBox_dane;
        private System.Windows.Forms.Button button_dodaj;
    }
}