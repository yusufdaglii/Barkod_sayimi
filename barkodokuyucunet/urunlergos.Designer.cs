namespace barkodokuyucunet
{
    partial class urunlergos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(urunlergos));
            this.tumurungrid = new System.Windows.Forms.DataGridView();
            this.barkodtxt2 = new System.Windows.Forms.TextBox();
            this.aktarbt = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tumurungrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tumurungrid
            // 
            this.tumurungrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tumurungrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tumurungrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.tumurungrid.BackgroundColor = System.Drawing.Color.LightGray;
            this.tumurungrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tumurungrid.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.tumurungrid.Location = new System.Drawing.Point(12, 137);
            this.tumurungrid.Name = "tumurungrid";
            this.tumurungrid.RowHeadersWidth = 51;
            this.tumurungrid.RowTemplate.Height = 24;
            this.tumurungrid.Size = new System.Drawing.Size(1058, 300);
            this.tumurungrid.TabIndex = 10;
            // 
            // barkodtxt2
            // 
            this.barkodtxt2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.barkodtxt2.BackColor = System.Drawing.Color.LightGray;
            this.barkodtxt2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barkodtxt2.Location = new System.Drawing.Point(467, 443);
            this.barkodtxt2.Multiline = true;
            this.barkodtxt2.Name = "barkodtxt2";
            this.barkodtxt2.Size = new System.Drawing.Size(357, 37);
            this.barkodtxt2.TabIndex = 11;
            // 
            // aktarbt
            // 
            this.aktarbt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.aktarbt.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.aktarbt.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.aktarbt.Appearance.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aktarbt.Appearance.Options.UseBackColor = true;
            this.aktarbt.Appearance.Options.UseBorderColor = true;
            this.aktarbt.Appearance.Options.UseFont = true;
            this.aktarbt.AppearanceHovered.ForeColor = System.Drawing.Color.Red;
            this.aktarbt.AppearanceHovered.Options.UseBackColor = true;
            this.aktarbt.AppearanceHovered.Options.UseForeColor = true;
            this.aktarbt.AppearancePressed.ForeColor = System.Drawing.Color.Red;
            this.aktarbt.AppearancePressed.Options.UseBackColor = true;
            this.aktarbt.AppearancePressed.Options.UseForeColor = true;
            this.aktarbt.AutoWidthInLayoutControl = true;
            this.aktarbt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("aktarbt.ImageOptions.Image")));
            this.aktarbt.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.BottomCenter;
            this.aktarbt.Location = new System.Drawing.Point(284, 443);
            this.aktarbt.Name = "aktarbt";
            this.aktarbt.Size = new System.Drawing.Size(111, 58);
            this.aktarbt.TabIndex = 14;
            this.aktarbt.Text = "EXCEL\'E AKTAR";
            this.aktarbt.Click += new System.EventHandler(this.aktarbt_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpleButton1.Location = new System.Drawing.Point(168, 450);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(94, 29);
            this.simpleButton1.TabIndex = 15;
            this.simpleButton1.Text = "simpleButton1";
            // 
            // urunlergos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.aktarbt);
            this.Controls.Add(this.barkodtxt2);
            this.Controls.Add(this.tumurungrid);
            this.Name = "urunlergos";
            this.Text = "urunlergos";
            this.Load += new System.EventHandler(this.urunlergos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tumurungrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tumurungrid;
        private System.Windows.Forms.TextBox barkodtxt2;
        private DevExpress.XtraEditors.SimpleButton aktarbt;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}