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
            this.lblTempsCalcul = new System.Windows.Forms.Label();
            this.txtTempsCalcul = new System.Windows.Forms.TextBox();
            this.lblVent = new System.Windows.Forms.Label();
            this.lblSelection = new System.Windows.Forms.Label();
            this.lblResultats = new System.Windows.Forms.Label();
            this.radioCasA = new System.Windows.Forms.RadioButton();
            this.radioCasB = new System.Windows.Forms.RadioButton();
            this.radioCasC = new System.Windows.Forms.RadioButton();
            this.btnLancerRecherche = new System.Windows.Forms.Button();
            this.lblCasA = new System.Windows.Forms.Label();
            this.lblCasB = new System.Windows.Forms.Label();
            this.lblCasC = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mapSeaBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mapSeaBox
            // 
            this.mapSeaBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.mapSeaBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.mapSeaBox.Image = ((System.Drawing.Image)(resources.GetObject("mapSeaBox.Image")));
            this.mapSeaBox.Location = new System.Drawing.Point(200, 86);
            this.mapSeaBox.Margin = new System.Windows.Forms.Padding(2);
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
            this.label3.Location = new System.Drawing.Point(232, 431);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "x";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 462);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(369, 462);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(369, 431);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "x";
            // 
            // xInitBox
            // 
            this.xInitBox.Location = new System.Drawing.Point(249, 431);
            this.xInitBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.xInitBox.Name = "xInitBox";
            this.xInitBox.Size = new System.Drawing.Size(76, 20);
            this.xInitBox.TabIndex = 17;
            this.xInitBox.TextChanged += new System.EventHandler(this.xInitBox_TextChanged);
            // 
            // yInitBox
            // 
            this.yInitBox.Location = new System.Drawing.Point(249, 462);
            this.yInitBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.yInitBox.Name = "yInitBox";
            this.yInitBox.Size = new System.Drawing.Size(76, 20);
            this.yInitBox.TabIndex = 18;
            this.yInitBox.TextChanged += new System.EventHandler(this.yInitBox_TextChanged);
            // 
            // xDestBox
            // 
            this.xDestBox.Enabled = false;
            this.xDestBox.Location = new System.Drawing.Point(384, 429);
            this.xDestBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.xDestBox.Name = "xDestBox";
            this.xDestBox.Size = new System.Drawing.Size(76, 20);
            this.xDestBox.TabIndex = 19;
            this.xDestBox.TextChanged += new System.EventHandler(this.xDestBox_TextChanged);
            // 
            // yDestBox
            // 
            this.yDestBox.Enabled = false;
            this.yDestBox.Location = new System.Drawing.Point(384, 462);
            this.yDestBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.yDestBox.Name = "yDestBox";
            this.yDestBox.Size = new System.Drawing.Size(76, 20);
            this.yDestBox.TabIndex = 20;
            this.yDestBox.TextChanged += new System.EventHandler(this.yDestBox_TextChanged);
            // 
            // treeViewBox
            // 
            this.treeViewBox.Location = new System.Drawing.Point(556, 86);
            this.treeViewBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.treeViewBox.Name = "treeViewBox";
            this.treeViewBox.Size = new System.Drawing.Size(278, 301);
            this.treeViewBox.TabIndex = 24;
            // 
            // radioPosInit
            // 
            this.radioPosInit.AutoSize = true;
            this.radioPosInit.Checked = true;
            this.radioPosInit.Location = new System.Drawing.Point(235, 403);
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
            this.radioPosFinale.Location = new System.Drawing.Point(372, 406);
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
            this.reinitButton.Location = new System.Drawing.Point(85, 553);
            this.reinitButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.reinitButton.Name = "reinitButton";
            this.reinitButton.Size = new System.Drawing.Size(107, 35);
            this.reinitButton.TabIndex = 27;
            this.reinitButton.Text = "REINITIALISER";
            this.reinitButton.UseVisualStyleBackColor = true;
            this.reinitButton.Click += new System.EventHandler(this.reinitButton_Click);
            // 
            // lblTempsNav
            // 
            this.lblTempsNav.AutoSize = true;
            this.lblTempsNav.Location = new System.Drawing.Point(553, 410);
            this.lblTempsNav.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTempsNav.Name = "lblTempsNav";
            this.lblTempsNav.Size = new System.Drawing.Size(138, 13);
            this.lblTempsNav.TabIndex = 28;
            this.lblTempsNav.Text = "Temps total de navigation : ";
            // 
            // lblNbNoeuds
            // 
            this.lblNbNoeuds.AutoSize = true;
            this.lblNbNoeuds.Location = new System.Drawing.Point(553, 437);
            this.lblNbNoeuds.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNbNoeuds.Name = "lblNbNoeuds";
            this.lblNbNoeuds.Size = new System.Drawing.Size(197, 13);
            this.lblNbNoeuds.TabIndex = 29;
            this.lblNbNoeuds.Text = "Nombre de noeuds du chemin solution : ";
            // 
            // lblSommeNoeuds
            // 
            this.lblSommeNoeuds.AutoSize = true;
            this.lblSommeNoeuds.Location = new System.Drawing.Point(553, 465);
            this.lblSommeNoeuds.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSommeNoeuds.Name = "lblSommeNoeuds";
            this.lblSommeNoeuds.Size = new System.Drawing.Size(109, 13);
            this.lblSommeNoeuds.TabIndex = 30;
            this.lblSommeNoeuds.Text = "Somme des noeuds : ";
            // 
            // txtTempsNav
            // 
            this.txtTempsNav.Location = new System.Drawing.Point(755, 407);
            this.txtTempsNav.Margin = new System.Windows.Forms.Padding(2);
            this.txtTempsNav.Name = "txtTempsNav";
            this.txtTempsNav.Size = new System.Drawing.Size(76, 20);
            this.txtTempsNav.TabIndex = 31;
            // 
            // txtNbNoeuds
            // 
            this.txtNbNoeuds.Location = new System.Drawing.Point(755, 434);
            this.txtNbNoeuds.Margin = new System.Windows.Forms.Padding(2);
            this.txtNbNoeuds.Name = "txtNbNoeuds";
            this.txtNbNoeuds.Size = new System.Drawing.Size(76, 20);
            this.txtNbNoeuds.TabIndex = 32;
            // 
            // txtSommeNoeuds
            // 
            this.txtSommeNoeuds.Location = new System.Drawing.Point(755, 462);
            this.txtSommeNoeuds.Margin = new System.Windows.Forms.Padding(2);
            this.txtSommeNoeuds.Name = "txtSommeNoeuds";
            this.txtSommeNoeuds.Size = new System.Drawing.Size(76, 20);
            this.txtSommeNoeuds.TabIndex = 33;
            // 
            // lblTempsCalcul
            // 
            this.lblTempsCalcul.AutoSize = true;
            this.lblTempsCalcul.Location = new System.Drawing.Point(553, 492);
            this.lblTempsCalcul.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTempsCalcul.Name = "lblTempsCalcul";
            this.lblTempsCalcul.Size = new System.Drawing.Size(94, 13);
            this.lblTempsCalcul.TabIndex = 34;
            this.lblTempsCalcul.Text = "Temps de calcul : ";
            // 
            // txtTempsCalcul
            // 
            this.txtTempsCalcul.Location = new System.Drawing.Point(755, 492);
            this.txtTempsCalcul.Margin = new System.Windows.Forms.Padding(2);
            this.txtTempsCalcul.Name = "txtTempsCalcul";
            this.txtTempsCalcul.Size = new System.Drawing.Size(76, 20);
            this.txtTempsCalcul.TabIndex = 35;
            // 
            // lblVent
            // 
            this.lblVent.AutoSize = true;
            this.lblVent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblVent.Location = new System.Drawing.Point(24, 37);
            this.lblVent.Name = "lblVent";
            this.lblVent.Size = new System.Drawing.Size(120, 18);
            this.lblVent.TabIndex = 36;
            this.lblVent.Text = "Choix du vent :";
            // 
            // lblSelection
            // 
            this.lblSelection.AutoSize = true;
            this.lblSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblSelection.Location = new System.Drawing.Point(232, 37);
            this.lblSelection.Name = "lblSelection";
            this.lblSelection.Size = new System.Drawing.Size(224, 18);
            this.lblSelection.TabIndex = 37;
            this.lblSelection.Text = "Sélection des coordonnées :";
            // 
            // lblResultats
            // 
            this.lblResultats.AutoSize = true;
            this.lblResultats.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblResultats.Location = new System.Drawing.Point(666, 37);
            this.lblResultats.Name = "lblResultats";
            this.lblResultats.Size = new System.Drawing.Size(89, 18);
            this.lblResultats.TabIndex = 38;
            this.lblResultats.Text = "Résultats :";
            // 
            // radioCasA
            // 
            this.radioCasA.AutoSize = true;
            this.radioCasA.Location = new System.Drawing.Point(12, 115);
            this.radioCasA.Name = "radioCasA";
            this.radioCasA.Size = new System.Drawing.Size(134, 30);
            this.radioCasA.TabIndex = 39;
            this.radioCasA.TabStop = true;
            this.radioCasA.Text = "Vent constant 50km/h \r\nDirection 30° (nord-est)\r\n";
            this.radioCasA.UseVisualStyleBackColor = true;
            this.radioCasA.CheckedChanged += new System.EventHandler(this.selectionVent);
            // 
            // radioCasB
            // 
            this.radioCasB.AutoSize = true;
            this.radioCasB.Location = new System.Drawing.Point(12, 214);
            this.radioCasB.Name = "radioCasB";
            this.radioCasB.Size = new System.Drawing.Size(143, 95);
            this.radioCasB.TabIndex = 40;
            this.radioCasB.TabStop = true;
            this.radioCasB.Text = "Si y>150\r\nVent constant à 50km/h\r\nDirection 180° (ouest).\r\n\r\nSi y<=150\r\nVent cons" +
    "tant à 20 km/h\r\nDirection 90° (nord)";
            this.radioCasB.UseVisualStyleBackColor = true;
            this.radioCasB.CheckedChanged += new System.EventHandler(this.selectionVent);
            // 
            // radioCasC
            // 
            this.radioCasC.AutoSize = true;
            this.radioCasC.Location = new System.Drawing.Point(12, 387);
            this.radioCasC.Name = "radioCasC";
            this.radioCasC.Size = new System.Drawing.Size(143, 95);
            this.radioCasC.TabIndex = 41;
            this.radioCasC.TabStop = true;
            this.radioCasC.Text = "Si y>150\r\nVent constant à 50km/h \r\ndirection 170° (ouest)\r\n\r\nSi y<=150\r\nVent cons" +
    "tant à 20 km/h\r\nDirection 65° (nord-est)";
            this.radioCasC.UseVisualStyleBackColor = true;
            this.radioCasC.CheckedChanged += new System.EventHandler(this.selectionVent);
            // 
            // btnLancerRecherche
            // 
            this.btnLancerRecherche.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLancerRecherche.Location = new System.Drawing.Point(249, 553);
            this.btnLancerRecherche.Name = "btnLancerRecherche";
            this.btnLancerRecherche.Size = new System.Drawing.Size(254, 35);
            this.btnLancerRecherche.TabIndex = 42;
            this.btnLancerRecherche.Text = "RECHERCHER LE PLUS COURT CHEMIN";
            this.btnLancerRecherche.UseVisualStyleBackColor = false;
            this.btnLancerRecherche.Click += new System.EventHandler(this.btnLancerRecherche_Click);
            // 
            // lblCasA
            // 
            this.lblCasA.AutoSize = true;
            this.lblCasA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCasA.Location = new System.Drawing.Point(53, 99);
            this.lblCasA.Name = "lblCasA";
            this.lblCasA.Size = new System.Drawing.Size(40, 13);
            this.lblCasA.TabIndex = 43;
            this.lblCasA.Text = "Cas A";
            // 
            // lblCasB
            // 
            this.lblCasB.AutoSize = true;
            this.lblCasB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCasB.Location = new System.Drawing.Point(53, 188);
            this.lblCasB.Name = "lblCasB";
            this.lblCasB.Size = new System.Drawing.Size(40, 13);
            this.lblCasB.TabIndex = 44;
            this.lblCasB.Text = "Cas B";
            // 
            // lblCasC
            // 
            this.lblCasC.AutoSize = true;
            this.lblCasC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCasC.Location = new System.Drawing.Point(56, 368);
            this.lblCasC.Name = "lblCasC";
            this.lblCasC.Size = new System.Drawing.Size(40, 13);
            this.lblCasC.TabIndex = 45;
            this.lblCasC.Text = "Cas C";
            // 
            // AffichageGraphique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 600);
            this.Controls.Add(this.lblCasC);
            this.Controls.Add(this.lblCasB);
            this.Controls.Add(this.lblCasA);
            this.Controls.Add(this.btnLancerRecherche);
            this.Controls.Add(this.radioCasC);
            this.Controls.Add(this.radioCasB);
            this.Controls.Add(this.radioCasA);
            this.Controls.Add(this.lblResultats);
            this.Controls.Add(this.lblSelection);
            this.Controls.Add(this.lblVent);
            this.Controls.Add(this.txtTempsCalcul);
            this.Controls.Add(this.lblTempsCalcul);
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
            this.Controls.Add(this.yDestBox);
            this.Controls.Add(this.xDestBox);
            this.Controls.Add(this.yInitBox);
            this.Controls.Add(this.xInitBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mapSeaBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Label lblTempsCalcul;
        private System.Windows.Forms.TextBox txtTempsCalcul;
        private System.Windows.Forms.Label lblVent;
        private System.Windows.Forms.Label lblSelection;
        private System.Windows.Forms.Label lblResultats;
        private System.Windows.Forms.RadioButton radioCasA;
        private System.Windows.Forms.RadioButton radioCasB;
        private System.Windows.Forms.RadioButton radioCasC;
        private System.Windows.Forms.Button btnLancerRecherche;
        private System.Windows.Forms.Label lblCasA;
        private System.Windows.Forms.Label lblCasB;
        private System.Windows.Forms.Label lblCasC;
    }
}