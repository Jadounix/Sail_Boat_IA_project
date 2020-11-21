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
            this.lblTempsNav = new System.Windows.Forms.Label();
            this.lblNbNoeuds = new System.Windows.Forms.Label();
            this.lblSommeNoeuds = new System.Windows.Forms.Label();
            this.txtTempsNav = new System.Windows.Forms.TextBox();
            this.txtNbNoeuds = new System.Windows.Forms.TextBox();
            this.txtSommeNoeuds = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mapSeaBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mapSeaBox
            // 
            this.mapSeaBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.mapSeaBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.mapSeaBox.Image = ((System.Drawing.Image)(resources.GetObject("mapSeaBox.Image")));
            this.mapSeaBox.Location = new System.Drawing.Point(154, 13);
            this.mapSeaBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mapSeaBox.MaximumSize = new System.Drawing.Size(300, 301);
            this.mapSeaBox.MinimumSize = new System.Drawing.Size(300, 301);
            this.mapSeaBox.Name = "mapSeaBox";
            this.mapSeaBox.Size = new System.Drawing.Size(300, 301);
            this.mapSeaBox.TabIndex = 0;
            this.mapSeaBox.TabStop = false;
            this.mapSeaBox.Click += new System.EventHandler(this.mapSeaBox_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 356);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "x";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 387);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 387);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 356);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "x";
            // 
            // xInitBox
            // 
            this.xInitBox.Location = new System.Drawing.Point(170, 356);
            this.xInitBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.xInitBox.Name = "xInitBox";
            this.xInitBox.Size = new System.Drawing.Size(76, 20);
            this.xInitBox.TabIndex = 17;
            this.xInitBox.TextChanged += new System.EventHandler(this.xInitBox_TextChanged);
            // 
            // yInitBox
            // 
            this.yInitBox.Location = new System.Drawing.Point(170, 387);
            this.yInitBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.yInitBox.Name = "yInitBox";
            this.yInitBox.Size = new System.Drawing.Size(76, 20);
            this.yInitBox.TabIndex = 18;
            this.yInitBox.TextChanged += new System.EventHandler(this.yInitBox_TextChanged);
            // 
            // xDestBox
            // 
            this.xDestBox.Enabled = false;
            this.xDestBox.Location = new System.Drawing.Point(305, 354);
            this.xDestBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.xDestBox.Name = "xDestBox";
            this.xDestBox.Size = new System.Drawing.Size(76, 20);
            this.xDestBox.TabIndex = 19;
            this.xDestBox.TextChanged += new System.EventHandler(this.xDestBox_TextChanged);
            // 
            // yDestBox
            // 
            this.yDestBox.Enabled = false;
            this.yDestBox.Location = new System.Drawing.Point(305, 387);
            this.yDestBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.yDestBox.Name = "yDestBox";
            this.yDestBox.Size = new System.Drawing.Size(76, 20);
            this.yDestBox.TabIndex = 20;
            this.yDestBox.TextChanged += new System.EventHandler(this.yDestBox_TextChanged);
            // 
            // casBButton
            // 
            this.casBButton.Location = new System.Drawing.Point(36, 117);
            this.casBButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.casBButton.Name = "casBButton";
            this.casBButton.Size = new System.Drawing.Size(50, 30);
            this.casBButton.TabIndex = 21;
            this.casBButton.Text = "Cas B";
            this.casBButton.UseVisualStyleBackColor = true;
            this.casBButton.Click += new System.EventHandler(this.casBButton_Click);
            // 
            // casCButton
            // 
            this.casCButton.Location = new System.Drawing.Point(36, 163);
            this.casCButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.casCButton.Name = "casCButton";
            this.casCButton.Size = new System.Drawing.Size(50, 30);
            this.casCButton.TabIndex = 22;
            this.casCButton.Text = "Cas C";
            this.casCButton.UseVisualStyleBackColor = true;
            this.casCButton.Click += new System.EventHandler(this.casCButton_Click);
            // 
            // casAButton
            // 
            this.casAButton.Location = new System.Drawing.Point(36, 68);
            this.casAButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.casAButton.Name = "casAButton";
            this.casAButton.Size = new System.Drawing.Size(50, 30);
            this.casAButton.TabIndex = 23;
            this.casAButton.Text = "Cas A";
            this.casAButton.UseVisualStyleBackColor = true;
            this.casAButton.Click += new System.EventHandler(this.casAButton_Click);
            // 
            // treeViewBox
            // 
            this.treeViewBox.Location = new System.Drawing.Point(508, 13);
            this.treeViewBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.treeViewBox.Name = "treeViewBox";
            this.treeViewBox.Size = new System.Drawing.Size(278, 301);
            this.treeViewBox.TabIndex = 24;
            // 
            // radioPosInit
            // 
            this.radioPosInit.AutoSize = true;
            this.radioPosInit.Checked = true;
            this.radioPosInit.Location = new System.Drawing.Point(156, 328);
            this.radioPosInit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radioPosInit.Name = "radioPosInit";
            this.radioPosInit.Size = new System.Drawing.Size(95, 17);
            this.radioPosInit.TabIndex = 25;
            this.radioPosInit.TabStop = true;
            this.radioPosInit.Text = "Position Initiale";
            this.radioPosInit.UseVisualStyleBackColor = true;
            this.radioPosInit.CheckedChanged += new System.EventHandler(this.radioPosInit_CheckedChanged);
            // 
            // radioPosFinale
            // 
            this.radioPosFinale.AutoSize = true;
            this.radioPosFinale.Location = new System.Drawing.Point(293, 331);
            this.radioPosFinale.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radioPosFinale.Name = "radioPosFinale";
            this.radioPosFinale.Size = new System.Drawing.Size(93, 17);
            this.radioPosFinale.TabIndex = 26;
            this.radioPosFinale.Text = "Position Finale";
            this.radioPosFinale.UseVisualStyleBackColor = true;
            this.radioPosFinale.CheckedChanged += new System.EventHandler(this.radioPosFinale_CheckedChanged);
            // 
            // reinitButton
            // 
            this.reinitButton.Location = new System.Drawing.Point(236, 428);
            this.reinitButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.reinitButton.Name = "reinitButton";
            this.reinitButton.Size = new System.Drawing.Size(75, 29);
            this.reinitButton.TabIndex = 27;
            this.reinitButton.Text = "Réinitialiser";
            this.reinitButton.UseVisualStyleBackColor = true;
            this.reinitButton.Click += new System.EventHandler(this.reinitButton_Click);
            // 
            // lblTempsNav
            // 
            this.lblTempsNav.AutoSize = true;
            this.lblTempsNav.Location = new System.Drawing.Point(505, 339);
            this.lblTempsNav.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTempsNav.Name = "lblTempsNav";
            this.lblTempsNav.Size = new System.Drawing.Size(138, 13);
            this.lblTempsNav.TabIndex = 28;
            this.lblTempsNav.Text = "Temps total de navigation : ";
            // 
            // lblNbNoeuds
            // 
            this.lblNbNoeuds.AutoSize = true;
            this.lblNbNoeuds.Location = new System.Drawing.Point(505, 366);
            this.lblNbNoeuds.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNbNoeuds.Name = "lblNbNoeuds";
            this.lblNbNoeuds.Size = new System.Drawing.Size(197, 13);
            this.lblNbNoeuds.TabIndex = 29;
            this.lblNbNoeuds.Text = "Nombre de noeuds du chemin solution : ";
            // 
            // lblSommeNoeuds
            // 
            this.lblSommeNoeuds.AutoSize = true;
            this.lblSommeNoeuds.Location = new System.Drawing.Point(505, 394);
            this.lblSommeNoeuds.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSommeNoeuds.Name = "lblSommeNoeuds";
            this.lblSommeNoeuds.Size = new System.Drawing.Size(109, 13);
            this.lblSommeNoeuds.TabIndex = 30;
            this.lblSommeNoeuds.Text = "Somme des noeuds : ";
            // 
            // txtTempsNav
            // 
            this.txtTempsNav.Location = new System.Drawing.Point(707, 336);
            this.txtTempsNav.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTempsNav.Name = "txtTempsNav";
            this.txtTempsNav.Size = new System.Drawing.Size(76, 20);
            this.txtTempsNav.TabIndex = 31;
            // 
            // txtNbNoeuds
            // 
            this.txtNbNoeuds.Location = new System.Drawing.Point(707, 363);
            this.txtNbNoeuds.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNbNoeuds.Name = "txtNbNoeuds";
            this.txtNbNoeuds.Size = new System.Drawing.Size(76, 20);
            this.txtNbNoeuds.TabIndex = 32;
            // 
            // txtSommeNoeuds
            // 
            this.txtSommeNoeuds.Location = new System.Drawing.Point(707, 391);
            this.txtSommeNoeuds.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSommeNoeuds.Name = "txtSommeNoeuds";
            this.txtSommeNoeuds.Size = new System.Drawing.Size(76, 20);
            this.txtSommeNoeuds.TabIndex = 33;
            // 
            // AffichageGraphique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 510);
            this.Controls.Add(this.txtSommeNoeuds);
            this.Controls.Add(this.txtNbNoeuds);
            this.Controls.Add(this.txtTempsNav);
            this.Controls.Add(this.lblSommeNoeuds);
            this.Controls.Add(this.lblNbNoeuds);
            this.Controls.Add(this.lblTempsNav);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label lblTempsNav;
        private System.Windows.Forms.Label lblNbNoeuds;
        private System.Windows.Forms.Label lblSommeNoeuds;
        private System.Windows.Forms.TextBox txtTempsNav;
        private System.Windows.Forms.TextBox txtNbNoeuds;
        private System.Windows.Forms.TextBox txtSommeNoeuds;
    }
}