namespace BetamartFahmi
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tambahproduk = new System.Windows.Forms.ToolStripButton();
            this.tsListofProducts = new System.Windows.Forms.ToolStripButton();
            this.tsUser = new System.Windows.Forms.ToolStripButton();
            this.tsLogin = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(60, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tambahproduk,
            this.tsListofProducts,
            this.tsUser,
            this.tsLogin});
            this.toolStrip1.Location = new System.Drawing.Point(530, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(94, 391);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tambahproduk
            // 
            this.tambahproduk.Image = ((System.Drawing.Image)(resources.GetObject("tambahproduk.Image")));
            this.tambahproduk.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tambahproduk.Margin = new System.Windows.Forms.Padding(1, 70, 0, 2);
            this.tambahproduk.Name = "tambahproduk";
            this.tambahproduk.Size = new System.Drawing.Size(90, 69);
            this.tambahproduk.Text = "Product";
            this.tambahproduk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tambahproduk.Click += new System.EventHandler(this.tambahproduk_Click);
            // 
            // tsListofProducts
            // 
            this.tsListofProducts.Image = ((System.Drawing.Image)(resources.GetObject("tsListofProducts.Image")));
            this.tsListofProducts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsListofProducts.Name = "tsListofProducts";
            this.tsListofProducts.Size = new System.Drawing.Size(91, 69);
            this.tsListofProducts.Text = "List of Products";
            this.tsListofProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsListofProducts.Click += new System.EventHandler(this.tsListofProducts_Click);
            // 
            // tsUser
            // 
            this.tsUser.Image = ((System.Drawing.Image)(resources.GetObject("tsUser.Image")));
            this.tsUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsUser.Name = "tsUser";
            this.tsUser.Size = new System.Drawing.Size(91, 69);
            this.tsUser.Text = "Manage Users";
            this.tsUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsUser.Click += new System.EventHandler(this.tsUser_Click);
            // 
            // tsLogin
            // 
            this.tsLogin.Image = global::BetaMartFahmi.Properties.Resources.login;
            this.tsLogin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsLogin.Name = "tsLogin";
            this.tsLogin.Size = new System.Drawing.Size(91, 69);
            this.tsLogin.Text = "Login";
            this.tsLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsLogin.Click += new System.EventHandler(this.tsLogin_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::BetaMartFahmi.Properties.Resources.Group_1__2_;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(9, 21);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 37);
            this.button1.TabIndex = 1;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BetaMartFahmi.Properties.Resources.iPhone_8___2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(624, 391);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BetaMart";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tambahproduk;
        private System.Windows.Forms.ToolStripButton tsUser;
        private System.Windows.Forms.ToolStripButton tsLogin;
        private System.Windows.Forms.ToolStripButton tsListofProducts;
        private System.Windows.Forms.Button button1;
    }
}

