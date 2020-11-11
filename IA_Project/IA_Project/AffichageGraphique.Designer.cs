namespace IA_Project
{
    partial class AffichageGraphique
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AffichageGraphique));
            this.mapSeaBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.xInitBox = new System.Windows.Forms.TextBox();
            this.yInitBox = new System.Windows.Forms.TextBox();
            this.xDestBox = new System.Windows.Forms.TextBox();
            this.yDestBox = new System.Windows.Forms.TextBox();
            this.casBButton = new System.Windows.Forms.Button();
            this.casCButton = new System.Windows.Forms.Button();
            this.casAButton = new System.Windows.Forms.Button();
            this.treeViewBox = new System.Windows.Forms.TreeView();
            this.radioPosInit = new System.Windows.Forms.RadioButton();
            this.radioPosFinale = new System.Windows.Forms.RadioButton();
            this.reinitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mapSeaBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mapSeaBox
            // 
            this.mapSeaBox.Image = ((System.Drawing.Image)(resources.GetObject("mapSeaBox.Image")));
            this.mapSeaBox.Location = new System.Drawing.Point(233, 20);
            this.mapSeaBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mapSeaBox.MaximumSize = new System.Drawing.Size(338, 375);
            this.mapSeaBox.MinimumSize = new System.Drawing.Size(338, 375);
            this.mapSeaBox.Name = "mapSeaBox";
            this.mapSeaBox.Size = new System.Drawing.Size(338, 375);
            this.mapSeaBox.TabIndex = 0;
            this.mapSeaBox.TabStop = false;
            this.mapSeaBox.Click += new System.EventHandler(this.mapSeaBox_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 488);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "x";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 536);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(435, 536);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(435, 488);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "x";
            // 
            // xInitBox
            // 
            this.xInitBox.Location = new System.Drawing.Point(253, 488);
            this.xInitBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xInitBox.Name = "xInitBox";
            this.xInitBox.Size = new System.Drawing.Size(112, 26);
            this.xInitBox.TabIndex = 17;
            this.xInitBox.TextChanged += new System.EventHandler(this.xInitBox_TextChanged);
            // 
            // yInitBox
            // 
            this.yInitBox.Location = new System.Drawing.Point(253, 536);
            this.yInitBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.yInitBox.Name = "yInitBox";
            this.yInitBox.Size = new System.Drawing.Size(112, 26);
            this.yInitBox.TabIndex = 18;
            this.yInitBox.TextChanged += new System.EventHandler(this.yInitBox_TextChanged);
            // 
            // xDestBox
            // 
            this.xDestBox.Enabled = false;
            this.xDestBox.Location = new System.Drawing.Point(458, 484);
            this.xDestBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xDestBox.Name = "xDestBox";
            this.xDestBox.Size = new System.Drawing.Size(112, 26);
            this.xDestBox.TabIndex = 19;
            this.xDestBox.TextChanged += new System.EventHandler(this.xDestBox_TextChanged);
            // 
            // yDestBox
            // 
            this.yDestBox.Enabled = false;
            this.yDestBox.Location = new System.Drawing.Point(458, 536);
            this.yDestBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.yDestBox.Name = "yDestBox";
            this.yDestBox.Size = new System.Drawing.Size(112, 26);
            this.yDestBox.TabIndex = 20;
            this.yDestBox.TextChanged += new System.EventHandler(this.yDestBox_TextChanged);
            // 
            // casBButton
            // 
            this.casBButton.Location = new System.Drawing.Point(54, 180);
            this.casBButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.casBButton.Name = "casBButton";
            this.casBButton.Size = new System.Drawing.Size(75, 46);
            this.casBButton.TabIndex = 21;
            this.casBButton.Text = "Cas B";
            this.casBButton.UseVisualStyleBackColor = true;
            this.casBButton.Click += new System.EventHandler(this.casBButton_Click);
            // 
            // casCButton
            // 
            this.casCButton.Location = new System.Drawing.Point(54, 251);
            this.casCButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.casCButton.Name = "casCButton";
            this.casCButton.Size = new System.Drawing.Size(75, 46);
            this.casCButton.TabIndex = 22;
            this.casCButton.Text = "Cas C";
            this.casCButton.UseVisualStyleBackColor = true;
            this.casCButton.Click += new System.EventHandler(this.casCButton_Click);
            // 
            // casAButton
            // 
            this.casAButton.Location = new System.Drawing.Point(54, 105);
            this.casAButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.casAButton.Name = "casAButton";
            this.casAButton.Size = new System.Drawing.Size(75, 46);
            this.casAButton.TabIndex = 23;
            this.casAButton.Text = "Cas A";
            this.casAButton.UseVisualStyleBackColor = true;
            this.casAButton.Click += new System.EventHandler(this.casAButton_Click);
            // 
            // treeViewBox
            // 
            this.treeViewBox.Location = new System.Drawing.Point(698, 61);
            this.treeViewBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.treeViewBox.Name = "treeViewBox";
            this.treeViewBox.Size = new System.Drawing.Size(416, 431);
            this.treeViewBox.TabIndex = 24;
            // 
            // radioPosInit
            // 
            this.radioPosInit.AutoSize = true;
            this.radioPosInit.Checked = true;
            this.radioPosInit.Location = new System.Drawing.Point(233, 426);
            this.radioPosInit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioPosInit.Name = "radioPosInit";
            this.radioPosInit.Size = new System.Drawing.Size(140, 24);
            this.radioPosInit.TabIndex = 25;
            this.radioPosInit.TabStop = true;
            this.radioPosInit.Text = "Position Initiale";
            this.radioPosInit.UseVisualStyleBackColor = true;
            this.radioPosInit.CheckedChanged += new System.EventHandler(this.radioPosInit_CheckedChanged);
            // 
            // radioPosFinale
            // 
            this.radioPosFinale.AutoSize = true;
            this.radioPosFinale.Location = new System.Drawing.Point(439, 426);
            this.radioPosFinale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioPosFinale.Name = "radioPosFinale";
            this.radioPosFinale.Size = new System.Drawing.Size(137, 24);
            this.radioPosFinale.TabIndex = 26;
            this.radioPosFinale.Text = "Position Finale";
            this.radioPosFinale.UseVisualStyleBackColor = true;
            this.radioPosFinale.CheckedChanged += new System.EventHandler(this.radioPosFinale_CheckedChanged);
            // 
            // reinitButton
            // 
            this.reinitButton.Location = new System.Drawing.Point(354, 605);
            this.reinitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.reinitButton.Name = "reinitButton";
            this.reinitButton.Size = new System.Drawing.Size(112, 45);
            this.reinitButton.TabIndex = 27;
            this.reinitButton.Text = "Réinitialiser";
            this.reinitButton.UseVisualStyleBackColor = true;
            this.reinitButton.Click += new System.EventHandler(this.reinitButton_Click);
            // 
            // AffichageGraphique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 691);
            this.Controls.Add(this.reinitButton);
            this.Controls.Add(this.radioPosFinale);
            this.Controls.Add(this.radioPosInit);
            this.Controls.Add(this.treeViewBox);
            this.Controls.Add(this.casAButton);
            this.Controls.Add(this.casCButton);
            this.Controls.Add(this.casBButton);
            this.Controls.Add(this.yDestBox);
            this.Controls.Add(this.xDestBox);
            this.Controls.Add(this.yInitBox);
            this.Controls.Add(this.xInitBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mapSeaBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AffichageGraphique";
            this.Text = "AffichageGraphique";
            ((System.ComponentModel.ISupportInitialize)(this.mapSeaBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mapSeaBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox xInitBox;
        private System.Windows.Forms.TextBox yInitBox;
        private System.Windows.Forms.TextBox xDestBox;
        private System.Windows.Forms.TextBox yDestBox;
        private System.Windows.Forms.Button casBButton;
        private System.Windows.Forms.Button casCButton;
        private System.Windows.Forms.Button casAButton;
        private System.Windows.Forms.TreeView treeViewBox;
        private System.Windows.Forms.RadioButton radioPosInit;
        private System.Windows.Forms.RadioButton radioPosFinale;
        private System.Windows.Forms.Button reinitButton;
    }
}