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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.positionInitialeTxt = new System.Windows.Forms.Label();
            this.positionFinaleTxt = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(318, 49);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(341, 231);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // positionInitialeTxt
            // 
            this.positionInitialeTxt.AutoSize = true;
            this.positionInitialeTxt.Location = new System.Drawing.Point(315, 299);
            this.positionInitialeTxt.Name = "positionInitialeTxt";
            this.positionInitialeTxt.Size = new System.Drawing.Size(102, 17);
            this.positionInitialeTxt.TabIndex = 9;
            this.positionInitialeTxt.Text = "Position initiale";
            this.positionInitialeTxt.Click += new System.EventHandler(this.label1_Click);
            // 
            // positionFinaleTxt
            // 
            this.positionFinaleTxt.AutoSize = true;
            this.positionFinaleTxt.Location = new System.Drawing.Point(563, 299);
            this.positionFinaleTxt.Name = "positionFinaleTxt";
            this.positionFinaleTxt.Size = new System.Drawing.Size(96, 17);
            this.positionFinaleTxt.TabIndex = 10;
            this.positionFinaleTxt.Text = "Position finale";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "x";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(559, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(559, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "x";
            // 
            // xInitBox
            // 
            this.xInitBox.Location = new System.Drawing.Point(339, 338);
            this.xInitBox.Name = "xInitBox";
            this.xInitBox.Size = new System.Drawing.Size(100, 22);
            this.xInitBox.TabIndex = 17;
            this.xInitBox.TextChanged += new System.EventHandler(this.xInitBox_TextChanged);
            // 
            // yInitBox
            // 
            this.yInitBox.Location = new System.Drawing.Point(339, 377);
            this.yInitBox.Name = "yInitBox";
            this.yInitBox.Size = new System.Drawing.Size(100, 22);
            this.yInitBox.TabIndex = 18;
            this.yInitBox.TextChanged += new System.EventHandler(this.yInitBox_TextChanged);
            // 
            // xDestBox
            // 
            this.xDestBox.Location = new System.Drawing.Point(579, 335);
            this.xDestBox.Name = "xDestBox";
            this.xDestBox.Size = new System.Drawing.Size(100, 22);
            this.xDestBox.TabIndex = 19;
            this.xDestBox.TextChanged += new System.EventHandler(this.xDestBox_TextChanged);
            // 
            // yDestBox
            // 
            this.yDestBox.Location = new System.Drawing.Point(579, 377);
            this.yDestBox.Name = "yDestBox";
            this.yDestBox.Size = new System.Drawing.Size(100, 22);
            this.yDestBox.TabIndex = 20;
            this.yDestBox.TextChanged += new System.EventHandler(this.yDestBox_TextChanged);
            // 
            // casBButton
            // 
            this.casBButton.Location = new System.Drawing.Point(48, 144);
            this.casBButton.Name = "casBButton";
            this.casBButton.Size = new System.Drawing.Size(67, 37);
            this.casBButton.TabIndex = 21;
            this.casBButton.Text = "Cas B";
            this.casBButton.UseVisualStyleBackColor = true;
            this.casBButton.Click += new System.EventHandler(this.casBButton_Click);
            // 
            // casCButton
            // 
            this.casCButton.Location = new System.Drawing.Point(48, 201);
            this.casCButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.casCButton.Name = "casCButton";
            this.casCButton.Size = new System.Drawing.Size(67, 37);
            this.casCButton.TabIndex = 22;
            this.casCButton.Text = "Cas C";
            this.casCButton.UseVisualStyleBackColor = true;
            this.casCButton.Click += new System.EventHandler(this.casCButton_Click);
            // 
            // casAButton
            // 
            this.casAButton.Location = new System.Drawing.Point(48, 84);
            this.casAButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.casAButton.Name = "casAButton";
            this.casAButton.Size = new System.Drawing.Size(67, 37);
            this.casAButton.TabIndex = 23;
            this.casAButton.Text = "Cas a";
            this.casAButton.UseVisualStyleBackColor = true;
            this.casAButton.Click += new System.EventHandler(this.casAButton_Click);
            // 
            // treeViewBox
            // 
            this.treeViewBox.Location = new System.Drawing.Point(738, 49);
            this.treeViewBox.Name = "treeViewBox";
            this.treeViewBox.Size = new System.Drawing.Size(218, 231);
            this.treeViewBox.TabIndex = 24;
            // 
            // AffichageGraphique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 429);
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
            this.Controls.Add(this.positionFinaleTxt);
            this.Controls.Add(this.positionInitialeTxt);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AffichageGraphique";
            this.Text = "AffichageGraphique";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label positionInitialeTxt;
        private System.Windows.Forms.Label positionFinaleTxt;
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
    }
}