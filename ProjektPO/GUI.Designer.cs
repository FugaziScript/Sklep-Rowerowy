
namespace Projekt_PO
{
    partial class GUI
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Przedmioty");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Przednie");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Tylnie");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Amortyzatory", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Ramy");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Koła");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Siodełka");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Kierownice");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Hamulce");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Przerzutki");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Części", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Bidony");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Kaski");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Liczniki");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Narzędzia");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Oświetlenie");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Pokrowce");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Rękawiczki");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Stopki");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Lusterka");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Akcesoria", new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20});
            this.treeView_kategorie = new System.Windows.Forms.TreeView();
            this.listView_container = new System.Windows.Forms.ListView();
            this.button_doKoszyka = new System.Windows.Forms.Button();
            this.button_kup = new System.Windows.Forms.Button();
            this.label_ilosc = new System.Windows.Forms.Label();
            this.textBox_ilosc = new System.Windows.Forms.TextBox();
            this.pictureBox_koszyk = new System.Windows.Forms.PictureBox();
            this.textBox_szukaj = new System.Windows.Forms.TextBox();
            this.button_szukaj = new System.Windows.Forms.Button();
            this.button_orders = new System.Windows.Forms.Button();
            this.button_dodaj = new System.Windows.Forms.Button();
            this.textBox_orders = new System.Windows.Forms.TextBox();
            this.button_zwieksz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_koszyk)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView_kategorie
            // 
            this.treeView_kategorie.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.treeView_kategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.treeView_kategorie.Location = new System.Drawing.Point(12, 93);
            this.treeView_kategorie.Name = "treeView_kategorie";
            treeNode1.Name = "Przedmioty";
            treeNode1.Text = "Przedmioty";
            treeNode2.Name = "AmorP";
            treeNode2.Text = "Przednie";
            treeNode3.Name = "AmorT";
            treeNode3.Text = "Tylnie";
            treeNode4.Name = "Amor";
            treeNode4.Text = "Amortyzatory";
            treeNode5.Name = "Ramy";
            treeNode5.Text = "Ramy";
            treeNode6.Name = "Kola";
            treeNode6.Text = "Koła";
            treeNode7.Name = "Siodelka";
            treeNode7.Text = "Siodełka";
            treeNode8.Name = "Kierownice";
            treeNode8.Text = "Kierownice";
            treeNode9.Name = "Hamulce";
            treeNode9.Text = "Hamulce";
            treeNode10.Name = "Przerzutki";
            treeNode10.Text = "Przerzutki";
            treeNode11.Name = "Czesci";
            treeNode11.Text = "Części";
            treeNode12.Name = "Bidony";
            treeNode12.Text = "Bidony";
            treeNode13.Name = "Kaski";
            treeNode13.Text = "Kaski";
            treeNode14.Name = "Liczniki";
            treeNode14.Text = "Liczniki";
            treeNode15.Name = "Narzedzia";
            treeNode15.Text = "Narzędzia";
            treeNode16.Name = "Oswietlenie";
            treeNode16.Text = "Oświetlenie";
            treeNode17.Name = "Pokrowce";
            treeNode17.Text = "Pokrowce";
            treeNode18.Name = "Rekawiczki";
            treeNode18.Text = "Rękawiczki";
            treeNode19.Name = "Stopki";
            treeNode19.Text = "Stopki";
            treeNode20.Name = "Lusterka";
            treeNode20.Text = "Lusterka";
            treeNode21.Name = "Akcesoria";
            treeNode21.Text = "Akcesoria";
            this.treeView_kategorie.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode11,
            treeNode21});
            this.treeView_kategorie.Size = new System.Drawing.Size(130, 458);
            this.treeView_kategorie.TabIndex = 0;
            this.treeView_kategorie.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_kategorie_AfterSelect);
            // 
            // listView_container
            // 
            this.listView_container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_container.FullRowSelect = true;
            this.listView_container.GridLines = true;
            this.listView_container.HideSelection = false;
            this.listView_container.Location = new System.Drawing.Point(158, 93);
            this.listView_container.Name = "listView_container";
            this.listView_container.Size = new System.Drawing.Size(687, 458);
            this.listView_container.TabIndex = 1;
            this.listView_container.UseCompatibleStateImageBehavior = false;
            // 
            // button_doKoszyka
            // 
            this.button_doKoszyka.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_doKoszyka.Location = new System.Drawing.Point(853, 232);
            this.button_doKoszyka.Name = "button_doKoszyka";
            this.button_doKoszyka.Size = new System.Drawing.Size(75, 38);
            this.button_doKoszyka.TabIndex = 3;
            this.button_doKoszyka.Text = "Dodaj do Koszyka";
            this.button_doKoszyka.UseVisualStyleBackColor = true;
            this.button_doKoszyka.Click += new System.EventHandler(this.button_doKoszyka_Click);
            // 
            // button_kup
            // 
            this.button_kup.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_kup.Location = new System.Drawing.Point(853, 192);
            this.button_kup.Name = "button_kup";
            this.button_kup.Size = new System.Drawing.Size(75, 23);
            this.button_kup.TabIndex = 4;
            this.button_kup.Text = "Kup";
            this.button_kup.UseVisualStyleBackColor = true;
            this.button_kup.Click += new System.EventHandler(this.button_kup_Click);
            // 
            // label_ilosc
            // 
            this.label_ilosc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_ilosc.AutoSize = true;
            this.label_ilosc.Location = new System.Drawing.Point(873, 141);
            this.label_ilosc.Name = "label_ilosc";
            this.label_ilosc.Size = new System.Drawing.Size(32, 13);
            this.label_ilosc.TabIndex = 5;
            this.label_ilosc.Text = "Ilość:";
            // 
            // textBox_ilosc
            // 
            this.textBox_ilosc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox_ilosc.Location = new System.Drawing.Point(867, 157);
            this.textBox_ilosc.Name = "textBox_ilosc";
            this.textBox_ilosc.Size = new System.Drawing.Size(47, 20);
            this.textBox_ilosc.TabIndex = 6;
            this.textBox_ilosc.Text = "1";
            // 
            // pictureBox_koszyk
            // 
            this.pictureBox_koszyk.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox_koszyk.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pictureBox_koszyk.Image = global::Projekt.Properties.Resources.koszyk;
            this.pictureBox_koszyk.Location = new System.Drawing.Point(853, 12);
            this.pictureBox_koszyk.Name = "pictureBox_koszyk";
            this.pictureBox_koszyk.Size = new System.Drawing.Size(75, 62);
            this.pictureBox_koszyk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_koszyk.TabIndex = 2;
            this.pictureBox_koszyk.TabStop = false;
            this.pictureBox_koszyk.Click += new System.EventHandler(this.pictureBox_koszyk_Click);
            // 
            // textBox_szukaj
            // 
            this.textBox_szukaj.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_szukaj.Location = new System.Drawing.Point(316, 49);
            this.textBox_szukaj.Name = "textBox_szukaj";
            this.textBox_szukaj.Size = new System.Drawing.Size(251, 20);
            this.textBox_szukaj.TabIndex = 8;
            // 
            // button_szukaj
            // 
            this.button_szukaj.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_szukaj.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_szukaj.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_szukaj.Location = new System.Drawing.Point(573, 42);
            this.button_szukaj.Name = "button_szukaj";
            this.button_szukaj.Size = new System.Drawing.Size(75, 32);
            this.button_szukaj.TabIndex = 9;
            this.button_szukaj.Text = "Szukaj";
            this.button_szukaj.UseVisualStyleBackColor = false;
            this.button_szukaj.Click += new System.EventHandler(this.button_szukaj_Click);
            // 
            // button_orders
            // 
            this.button_orders.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_orders.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_orders.Location = new System.Drawing.Point(12, 21);
            this.button_orders.Name = "button_orders";
            this.button_orders.Size = new System.Drawing.Size(95, 23);
            this.button_orders.TabIndex = 11;
            this.button_orders.Text = "Zamówienia";
            this.button_orders.UseVisualStyleBackColor = false;
            this.button_orders.Click += new System.EventHandler(this.button_orders_Click);
            // 
            // button_dodaj
            // 
            this.button_dodaj.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_dodaj.Location = new System.Drawing.Point(13, 51);
            this.button_dodaj.Name = "button_dodaj";
            this.button_dodaj.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_dodaj.Size = new System.Drawing.Size(94, 23);
            this.button_dodaj.TabIndex = 12;
            this.button_dodaj.Text = "Dodaj Element";
            this.button_dodaj.UseVisualStyleBackColor = true;
            this.button_dodaj.Click += new System.EventHandler(this.button_dodaj_Click);
            // 
            // textBox_orders
            // 
            this.textBox_orders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_orders.Location = new System.Drawing.Point(212, 93);
            this.textBox_orders.Multiline = true;
            this.textBox_orders.Name = "textBox_orders";
            this.textBox_orders.ReadOnly = true;
            this.textBox_orders.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_orders.Size = new System.Drawing.Size(595, 458);
            this.textBox_orders.TabIndex = 14;
            this.textBox_orders.Visible = false;
            // 
            // button_zwieksz
            // 
            this.button_zwieksz.Location = new System.Drawing.Point(853, 402);
            this.button_zwieksz.Name = "button_zwieksz";
            this.button_zwieksz.Size = new System.Drawing.Size(75, 23);
            this.button_zwieksz.TabIndex = 15;
            this.button_zwieksz.Text = "Dodaj";
            this.button_zwieksz.UseVisualStyleBackColor = true;
            this.button_zwieksz.Click += new System.EventHandler(this.button_zwieksz_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projekt.Properties.Resources.tlo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(938, 589);
            this.Controls.Add(this.button_zwieksz);
            this.Controls.Add(this.textBox_orders);
            this.Controls.Add(this.button_dodaj);
            this.Controls.Add(this.button_orders);
            this.Controls.Add(this.button_szukaj);
            this.Controls.Add(this.textBox_szukaj);
            this.Controls.Add(this.textBox_ilosc);
            this.Controls.Add(this.label_ilosc);
            this.Controls.Add(this.button_kup);
            this.Controls.Add(this.button_doKoszyka);
            this.Controls.Add(this.pictureBox_koszyk);
            this.Controls.Add(this.listView_container);
            this.Controls.Add(this.treeView_kategorie);
            this.Name = "GUI";
            this.Text = "Magazyn Sprzętu Rowerowego";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_koszyk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView_kategorie;
        private System.Windows.Forms.ListView listView_container;
        private System.Windows.Forms.PictureBox pictureBox_koszyk;
        private System.Windows.Forms.Button button_doKoszyka;
        private System.Windows.Forms.Button button_kup;
        private System.Windows.Forms.Label label_ilosc;
        private System.Windows.Forms.TextBox textBox_ilosc;
        private System.Windows.Forms.TextBox textBox_szukaj;
        private System.Windows.Forms.Button button_szukaj;
        private System.Windows.Forms.Button button_orders;
        private System.Windows.Forms.Button button_dodaj;
        private System.Windows.Forms.TextBox textBox_orders;
        private System.Windows.Forms.Button button_zwieksz;
    }
}

