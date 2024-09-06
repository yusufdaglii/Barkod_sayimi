namespace barkodokuyucunet
{
    partial class Ozet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ozet));
            this.data3 = new System.Windows.Forms.DataGridView();
            this.aktarbt = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.data3)).BeginInit();
            this.SuspendLayout();
            // 
            // data3
            // 
            this.data3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.data3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.data3.BackgroundColor = System.Drawing.Color.LightGray;
            this.data3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data3.Location = new System.Drawing.Point(3, 253);
            this.data3.Name = "data3";
            this.data3.RowHeadersWidth = 51;
            this.data3.RowTemplate.Height = 24;
            this.data3.Size = new System.Drawing.Size(1076, 138);
            this.data3.TabIndex = 3;
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
            this.aktarbt.Location = new System.Drawing.Point(483, 397);
            this.aktarbt.Name = "aktarbt";
            this.aktarbt.Size = new System.Drawing.Size(118, 58);
            this.aktarbt.TabIndex = 15;
            this.aktarbt.Text = "EXCEL\'E AKTAR";
            this.aktarbt.Click += new System.EventHandler(this.aktarbt_Click);
            // 
            // Ozet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.aktarbt);
            this.Controls.Add(this.data3);
            this.Name = "Ozet";
            this.Text = "Ozet";
            this.Load += new System.EventHandler(this.Ozet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton aktarbt;
        public System.Windows.Forms.DataGridView data3;
    }
}