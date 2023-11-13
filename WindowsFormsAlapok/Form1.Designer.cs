namespace WindowsFormsAlapok
{
    partial class WindowsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowsForm));
            this.Text_Forrasfajl = new System.Windows.Forms.Label();
            this.TextBox_Forrasfajl = new System.Windows.Forms.TextBox();
            this.Button_Betoltes = new System.Windows.Forms.Button();
            this.listbox_Adatok = new System.Windows.Forms.ListBox();
            this.Button_TeruletekAtlaga = new System.Windows.Forms.Button();
            this.groupBox_Mitszámolunk = new System.Windows.Forms.GroupBox();
            this.radioButton_100000nagyobb = new System.Windows.Forms.RadioButton();
            this.radioButton_legfeljebb = new System.Windows.Forms.RadioButton();
            this.button_Megszamolas = new System.Windows.Forms.Button();
            this.Text_Eredmenyfajlneve = new System.Windows.Forms.Label();
            this.textBox_Eredmenyfajl = new System.Windows.Forms.TextBox();
            this.button_Kiiras = new System.Windows.Forms.Button();
            this.label_Minvagymax = new System.Windows.Forms.Label();
            this.comboBox_Minvagymax = new System.Windows.Forms.ComboBox();
            this.button_Minmaxki = new System.Windows.Forms.Button();
            this.label_Orszagkeresese = new System.Windows.Forms.Label();
            this.textBox_Orszagkeresese = new System.Windows.Forms.TextBox();
            this.checkBox_Talalatok = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button_Kereses = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox_Mitszámolunk.SuspendLayout();
            this.SuspendLayout();
            // 
            // Text_Forrasfajl
            // 
            this.Text_Forrasfajl.AutoSize = true;
            this.Text_Forrasfajl.Location = new System.Drawing.Point(51, 34);
            this.Text_Forrasfajl.Name = "Text_Forrasfajl";
            this.Text_Forrasfajl.Size = new System.Drawing.Size(79, 13);
            this.Text_Forrasfajl.TabIndex = 0;
            this.Text_Forrasfajl.Text = "Forrásfájl neve:";
            // 
            // TextBox_Forrasfajl
            // 
            this.TextBox_Forrasfajl.Location = new System.Drawing.Point(51, 53);
            this.TextBox_Forrasfajl.Name = "TextBox_Forrasfajl";
            this.TextBox_Forrasfajl.Size = new System.Drawing.Size(169, 20);
            this.TextBox_Forrasfajl.TabIndex = 1;
            // 
            // Button_Betoltes
            // 
            this.Button_Betoltes.BackColor = System.Drawing.Color.White;
            this.Button_Betoltes.ForeColor = System.Drawing.Color.Black;
            this.Button_Betoltes.Location = new System.Drawing.Point(51, 79);
            this.Button_Betoltes.Name = "Button_Betoltes";
            this.Button_Betoltes.Size = new System.Drawing.Size(169, 21);
            this.Button_Betoltes.TabIndex = 2;
            this.Button_Betoltes.Text = "Betöltés";
            this.Button_Betoltes.UseVisualStyleBackColor = false;
            this.Button_Betoltes.Click += new System.EventHandler(this.Button_Betoltes_Click);
            // 
            // listbox_Adatok
            // 
            this.listbox_Adatok.FormattingEnabled = true;
            this.listbox_Adatok.Location = new System.Drawing.Point(51, 106);
            this.listbox_Adatok.Name = "listbox_Adatok";
            this.listbox_Adatok.Size = new System.Drawing.Size(169, 264);
            this.listbox_Adatok.TabIndex = 3;
            // 
            // Button_TeruletekAtlaga
            // 
            this.Button_TeruletekAtlaga.BackColor = System.Drawing.Color.White;
            this.Button_TeruletekAtlaga.ForeColor = System.Drawing.Color.Black;
            this.Button_TeruletekAtlaga.Location = new System.Drawing.Point(51, 376);
            this.Button_TeruletekAtlaga.Name = "Button_TeruletekAtlaga";
            this.Button_TeruletekAtlaga.Size = new System.Drawing.Size(169, 22);
            this.Button_TeruletekAtlaga.TabIndex = 4;
            this.Button_TeruletekAtlaga.Text = "Területek átlaga";
            this.Button_TeruletekAtlaga.UseVisualStyleBackColor = false;
            // 
            // groupBox_Mitszámolunk
            // 
            this.groupBox_Mitszámolunk.Controls.Add(this.radioButton_legfeljebb);
            this.groupBox_Mitszámolunk.Controls.Add(this.radioButton_100000nagyobb);
            this.groupBox_Mitszámolunk.Location = new System.Drawing.Point(280, 34);
            this.groupBox_Mitszámolunk.Name = "groupBox_Mitszámolunk";
            this.groupBox_Mitszámolunk.Size = new System.Drawing.Size(211, 67);
            this.groupBox_Mitszámolunk.TabIndex = 5;
            this.groupBox_Mitszámolunk.TabStop = false;
            this.groupBox_Mitszámolunk.Text = "Mit Számoljunk?";
            // 
            // radioButton_100000nagyobb
            // 
            this.radioButton_100000nagyobb.AutoSize = true;
            this.radioButton_100000nagyobb.Location = new System.Drawing.Point(7, 20);
            this.radioButton_100000nagyobb.Name = "radioButton_100000nagyobb";
            this.radioButton_100000nagyobb.Size = new System.Drawing.Size(163, 17);
            this.radioButton_100000nagyobb.TabIndex = 0;
            this.radioButton_100000nagyobb.TabStop = true;
            this.radioButton_100000nagyobb.Text = "100.000-nél nagyobb területű";
            this.radioButton_100000nagyobb.UseVisualStyleBackColor = true;
            // 
            // radioButton_legfeljebb
            // 
            this.radioButton_legfeljebb.AutoSize = true;
            this.radioButton_legfeljebb.Location = new System.Drawing.Point(7, 44);
            this.radioButton_legfeljebb.Name = "radioButton_legfeljebb";
            this.radioButton_legfeljebb.Size = new System.Drawing.Size(150, 17);
            this.radioButton_legfeljebb.TabIndex = 1;
            this.radioButton_legfeljebb.TabStop = true;
            this.radioButton_legfeljebb.Text = "legfeljebb 100.000 területű";
            this.radioButton_legfeljebb.UseVisualStyleBackColor = true;
            // 
            // button_Megszamolas
            // 
            this.button_Megszamolas.BackColor = System.Drawing.Color.White;
            this.button_Megszamolas.ForeColor = System.Drawing.Color.Black;
            this.button_Megszamolas.Location = new System.Drawing.Point(280, 108);
            this.button_Megszamolas.Name = "button_Megszamolas";
            this.button_Megszamolas.Size = new System.Drawing.Size(211, 21);
            this.button_Megszamolas.TabIndex = 2;
            this.button_Megszamolas.Text = "Megszámolás";
            this.button_Megszamolas.UseVisualStyleBackColor = false;
            // 
            // Text_Eredmenyfajlneve
            // 
            this.Text_Eredmenyfajlneve.AutoSize = true;
            this.Text_Eredmenyfajlneve.Location = new System.Drawing.Point(280, 132);
            this.Text_Eredmenyfajlneve.Name = "Text_Eredmenyfajlneve";
            this.Text_Eredmenyfajlneve.Size = new System.Drawing.Size(97, 13);
            this.Text_Eredmenyfajlneve.TabIndex = 0;
            this.Text_Eredmenyfajlneve.Text = "Eredményfájl neve:";
            // 
            // textBox_Eredmenyfajl
            // 
            this.textBox_Eredmenyfajl.Location = new System.Drawing.Point(280, 148);
            this.textBox_Eredmenyfajl.Name = "textBox_Eredmenyfajl";
            this.textBox_Eredmenyfajl.Size = new System.Drawing.Size(211, 20);
            this.textBox_Eredmenyfajl.TabIndex = 1;
            // 
            // button_Kiiras
            // 
            this.button_Kiiras.BackColor = System.Drawing.Color.White;
            this.button_Kiiras.ForeColor = System.Drawing.Color.Black;
            this.button_Kiiras.Location = new System.Drawing.Point(280, 174);
            this.button_Kiiras.Name = "button_Kiiras";
            this.button_Kiiras.Size = new System.Drawing.Size(211, 21);
            this.button_Kiiras.TabIndex = 2;
            this.button_Kiiras.Text = "Kiírás";
            this.button_Kiiras.UseVisualStyleBackColor = false;
            // 
            // label_Minvagymax
            // 
            this.label_Minvagymax.AutoSize = true;
            this.label_Minvagymax.Location = new System.Drawing.Point(280, 227);
            this.label_Minvagymax.Name = "label_Minvagymax";
            this.label_Minvagymax.Size = new System.Drawing.Size(127, 13);
            this.label_Minvagymax.TabIndex = 0;
            this.label_Minvagymax.Text = "Minimum vagy Maximum?";
            // 
            // comboBox_Minvagymax
            // 
            this.comboBox_Minvagymax.DisplayMember = "Minimum";
            this.comboBox_Minvagymax.FormattingEnabled = true;
            this.comboBox_Minvagymax.Items.AddRange(new object[] {
            "Minimum",
            "Maximum"});
            this.comboBox_Minvagymax.Location = new System.Drawing.Point(280, 243);
            this.comboBox_Minvagymax.Name = "comboBox_Minvagymax";
            this.comboBox_Minvagymax.Size = new System.Drawing.Size(128, 21);
            this.comboBox_Minvagymax.TabIndex = 6;
            this.comboBox_Minvagymax.Text = "Minimum";
            // 
            // button_Minmaxki
            // 
            this.button_Minmaxki.BackColor = System.Drawing.Color.White;
            this.button_Minmaxki.ForeColor = System.Drawing.Color.Black;
            this.button_Minmaxki.Location = new System.Drawing.Point(280, 270);
            this.button_Minmaxki.Name = "button_Minmaxki";
            this.button_Minmaxki.Size = new System.Drawing.Size(211, 21);
            this.button_Minmaxki.TabIndex = 2;
            this.button_Minmaxki.Text = "Minimum/Maximum kiválasztása";
            this.button_Minmaxki.UseVisualStyleBackColor = false;
            // 
            // label_Orszagkeresese
            // 
            this.label_Orszagkeresese.AutoSize = true;
            this.label_Orszagkeresese.Location = new System.Drawing.Point(280, 313);
            this.label_Orszagkeresese.Name = "label_Orszagkeresese";
            this.label_Orszagkeresese.Size = new System.Drawing.Size(89, 13);
            this.label_Orszagkeresese.TabIndex = 0;
            this.label_Orszagkeresese.Text = "Ország keresése:";
            // 
            // textBox_Orszagkeresese
            // 
            this.textBox_Orszagkeresese.Location = new System.Drawing.Point(280, 329);
            this.textBox_Orszagkeresese.Name = "textBox_Orszagkeresese";
            this.textBox_Orszagkeresese.Size = new System.Drawing.Size(211, 20);
            this.textBox_Orszagkeresese.TabIndex = 1;
            // 
            // checkBox_Talalatok
            // 
            this.checkBox_Talalatok.AutoSize = true;
            this.checkBox_Talalatok.Location = new System.Drawing.Point(280, 355);
            this.checkBox_Talalatok.Name = "checkBox_Talalatok";
            this.checkBox_Talalatok.Size = new System.Drawing.Size(164, 17);
            this.checkBox_Talalatok.TabIndex = 7;
            this.checkBox_Talalatok.Text = "Találatok kijelölése a listában";
            this.checkBox_Talalatok.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(281, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 22);
            this.button1.TabIndex = 4;
            this.button1.Text = "Területek átlaga";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button_Kereses
            // 
            this.button_Kereses.BackColor = System.Drawing.Color.White;
            this.button_Kereses.ForeColor = System.Drawing.Color.Black;
            this.button_Kereses.Location = new System.Drawing.Point(280, 378);
            this.button_Kereses.Name = "button_Kereses";
            this.button_Kereses.Size = new System.Drawing.Size(211, 22);
            this.button_Kereses.TabIndex = 4;
            this.button_Kereses.Text = "Keresés";
            this.button_Kereses.UseVisualStyleBackColor = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // WindowsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(728, 455);
            this.Controls.Add(this.checkBox_Talalatok);
            this.Controls.Add(this.comboBox_Minvagymax);
            this.Controls.Add(this.groupBox_Mitszámolunk);
            this.Controls.Add(this.button_Kereses);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Button_TeruletekAtlaga);
            this.Controls.Add(this.listbox_Adatok);
            this.Controls.Add(this.button_Minmaxki);
            this.Controls.Add(this.button_Kiiras);
            this.Controls.Add(this.button_Megszamolas);
            this.Controls.Add(this.Button_Betoltes);
            this.Controls.Add(this.textBox_Orszagkeresese);
            this.Controls.Add(this.textBox_Eredmenyfajl);
            this.Controls.Add(this.TextBox_Forrasfajl);
            this.Controls.Add(this.label_Orszagkeresese);
            this.Controls.Add(this.label_Minvagymax);
            this.Controls.Add(this.Text_Eredmenyfajlneve);
            this.Controls.Add(this.Text_Forrasfajl);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WindowsForm";
            this.Text = "Példa Windows Forms alkalmazás";
            this.groupBox_Mitszámolunk.ResumeLayout(false);
            this.groupBox_Mitszámolunk.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Text_Forrasfajl;
        private System.Windows.Forms.TextBox TextBox_Forrasfajl;
        private System.Windows.Forms.Button Button_Betoltes;
        private System.Windows.Forms.ListBox listbox_Adatok;
        private System.Windows.Forms.Button Button_TeruletekAtlaga;
        private System.Windows.Forms.GroupBox groupBox_Mitszámolunk;
        private System.Windows.Forms.RadioButton radioButton_legfeljebb;
        private System.Windows.Forms.RadioButton radioButton_100000nagyobb;
        private System.Windows.Forms.Button button_Megszamolas;
        private System.Windows.Forms.Label Text_Eredmenyfajlneve;
        private System.Windows.Forms.TextBox textBox_Eredmenyfajl;
        private System.Windows.Forms.Button button_Kiiras;
        private System.Windows.Forms.Label label_Minvagymax;
        private System.Windows.Forms.ComboBox comboBox_Minvagymax;
        private System.Windows.Forms.Button button_Minmaxki;
        private System.Windows.Forms.Label label_Orszagkeresese;
        private System.Windows.Forms.TextBox textBox_Orszagkeresese;
        private System.Windows.Forms.CheckBox checkBox_Talalatok;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_Kereses;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

