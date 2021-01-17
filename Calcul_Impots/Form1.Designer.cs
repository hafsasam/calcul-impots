namespace Calcul_Impots
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.notMarried = new System.Windows.Forms.RadioButton();
            this.marrie = new System.Windows.Forms.RadioButton();
            this.child = new System.Windows.Forms.NumericUpDown();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.salary = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.tax = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.calc = new Bunifu.Framework.UI.BunifuFlatButton();
            this.clear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.exit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.child)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.notMarried);
            this.groupBox1.Controls.Add(this.marrie);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(135, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "married";
            this.groupBox1.Text = "Etes-vous marié(e) ?";
            // 
            // notMarried
            // 
            this.notMarried.AutoSize = true;
            this.notMarried.Checked = true;
            this.notMarried.Location = new System.Drawing.Point(187, 44);
            this.notMarried.Name = "notMarried";
            this.notMarried.Size = new System.Drawing.Size(56, 22);
            this.notMarried.TabIndex = 0;
            this.notMarried.TabStop = true;
            this.notMarried.Text = "Non";
            this.notMarried.UseVisualStyleBackColor = true;
            this.notMarried.CheckedChanged += new System.EventHandler(this.notMarried_CheckedChanged);
            // 
            // marrie
            // 
            this.marrie.AutoSize = true;
            this.marrie.Location = new System.Drawing.Point(39, 44);
            this.marrie.Name = "marrie";
            this.marrie.Size = new System.Drawing.Size(52, 22);
            this.marrie.TabIndex = 0;
            this.marrie.Text = "Oui";
            this.marrie.UseVisualStyleBackColor = true;
            this.marrie.CheckedChanged += new System.EventHandler(this.marrie_CheckedChanged);
            // 
            // child
            // 
            this.child.Location = new System.Drawing.Point(322, 243);
            this.child.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.child.Name = "child";
            this.child.Size = new System.Drawing.Size(56, 20);
            this.child.TabIndex = 1;
            this.child.ValueChanged += new System.EventHandler(this.child_ValueChanged);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(135, 247);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(123, 16);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Nombre d\'enfants";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(135, 296);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(103, 16);
            this.bunifuCustomLabel2.TabIndex = 2;
            this.bunifuCustomLabel2.Text = "Salaire annuel";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(135, 345);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(101, 16);
            this.bunifuCustomLabel3.TabIndex = 2;
            this.bunifuCustomLabel3.Text = "Impôt à payer";
            // 
            // salary
            // 
            this.salary.BorderColor = System.Drawing.Color.Transparent;
            this.salary.Location = new System.Drawing.Point(322, 292);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(106, 20);
            this.salary.TabIndex = 4;
            this.salary.TextChanged += new System.EventHandler(this.salary_TextChanged);
            // 
            // tax
            // 
            this.tax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(74)))), ((int)(((byte)(64)))));
            this.tax.BorderColor = System.Drawing.Color.Transparent;
            this.tax.Location = new System.Drawing.Point(322, 341);
            this.tax.Name = "tax";
            this.tax.Size = new System.Drawing.Size(106, 20);
            this.tax.TabIndex = 4;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Effacer";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(328, 510);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(196, 63);
            this.bunifuFlatButton2.TabIndex = 5;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // calc
            // 
            this.calc.Activecolor = System.Drawing.Color.Transparent;
            this.calc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.calc.BackColor = System.Drawing.Color.Transparent;
            this.calc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.calc.BorderRadius = 0;
            this.calc.ButtonText = "Calculer";
            this.calc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calc.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calc.ForeColor = System.Drawing.SystemColors.GrayText;
            this.calc.Iconcolor = System.Drawing.Color.Transparent;
            this.calc.Iconimage = ((System.Drawing.Image)(resources.GetObject("calc.Iconimage")));
            this.calc.Iconimage_right = null;
            this.calc.Iconimage_right_Selected = null;
            this.calc.Iconimage_Selected = null;
            this.calc.IconZoom = 55D;
            this.calc.IsTab = false;
            this.calc.Location = new System.Drawing.Point(39, 418);
            this.calc.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.calc.Name = "calc";
            this.calc.Normalcolor = System.Drawing.Color.Transparent;
            this.calc.OnHovercolor = System.Drawing.Color.Transparent;
            this.calc.OnHoverTextColor = System.Drawing.Color.DimGray;
            this.calc.selected = false;
            this.calc.Size = new System.Drawing.Size(185, 49);
            this.calc.TabIndex = 5;
            this.calc.Textcolor = System.Drawing.Color.White;
            this.calc.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // clear
            // 
            this.clear.Activecolor = System.Drawing.Color.Transparent;
            this.clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clear.BackColor = System.Drawing.Color.Transparent;
            this.clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.clear.BorderRadius = 40;
            this.clear.ButtonText = "Effacer";
            this.clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clear.Iconcolor = System.Drawing.Color.Transparent;
            this.clear.Iconimage = ((System.Drawing.Image)(resources.GetObject("clear.Iconimage")));
            this.clear.Iconimage_right = null;
            this.clear.Iconimage_right_Selected = null;
            this.clear.Iconimage_Selected = null;
            this.clear.IconZoom = 55D;
            this.clear.IsTab = false;
            this.clear.Location = new System.Drawing.Point(224, 418);
            this.clear.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.clear.Name = "clear";
            this.clear.Normalcolor = System.Drawing.Color.Transparent;
            this.clear.OnHovercolor = System.Drawing.Color.Transparent;
            this.clear.OnHoverTextColor = System.Drawing.Color.DimGray;
            this.clear.selected = false;
            this.clear.Size = new System.Drawing.Size(172, 49);
            this.clear.TabIndex = 6;
            this.clear.Textcolor = System.Drawing.Color.White;
            this.clear.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // exit
            // 
            this.exit.Activecolor = System.Drawing.Color.Transparent;
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exit.BorderRadius = 40;
            this.exit.ButtonText = "Quitter";
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.exit.Iconcolor = System.Drawing.Color.Transparent;
            this.exit.Iconimage = ((System.Drawing.Image)(resources.GetObject("exit.Iconimage")));
            this.exit.Iconimage_right = null;
            this.exit.Iconimage_right_Selected = null;
            this.exit.Iconimage_Selected = null;
            this.exit.IconZoom = 55D;
            this.exit.IsTab = false;
            this.exit.Location = new System.Drawing.Point(405, 418);
            this.exit.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.exit.Name = "exit";
            this.exit.Normalcolor = System.Drawing.Color.Transparent;
            this.exit.OnHovercolor = System.Drawing.Color.Transparent;
            this.exit.OnHoverTextColor = System.Drawing.Color.Black;
            this.exit.selected = false;
            this.exit.Size = new System.Drawing.Size(233, 49);
            this.exit.TabIndex = 5;
            this.exit.Textcolor = System.Drawing.Color.White;
            this.exit.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 401);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 100);
            this.panel1.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(574, 319);
            this.panel3.TabIndex = 9;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.Linen;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(184, 19);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(194, 28);
            this.bunifuCustomLabel4.TabIndex = 2;
            this.bunifuCustomLabel4.Text = "Calcul d\'impôts";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.bunifuCustomLabel4);
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(577, 69);
            this.panel2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(577, 500);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.tax);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.child);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Impots";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.child)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton notMarried;
        private System.Windows.Forms.RadioButton marrie;
        private System.Windows.Forms.NumericUpDown child;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox salary;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox tax;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton calc;
        private Bunifu.Framework.UI.BunifuFlatButton clear;
        private Bunifu.Framework.UI.BunifuFlatButton exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.Panel panel2;
    }
}

