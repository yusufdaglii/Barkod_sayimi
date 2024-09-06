namespace barkodokuyucunet
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.barkodlbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sayimcglbt = new DevExpress.XtraEditors.SimpleButton();
            this.urunsystxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sayimtekilbt = new DevExpress.XtraEditors.SimpleButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.barkodgrid = new System.Windows.Forms.DataGridView();
            this.barkodtxt = new System.Windows.Forms.TextBox();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.bitirvegosterbt = new DevExpress.XtraEditors.SimpleButton();
            this.bitirgrid = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barkodgrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitirgrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // barkodlbl
            // 
            this.barkodlbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.barkodlbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.barkodlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.barkodlbl.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barkodlbl.ForeColor = System.Drawing.Color.Black;
            this.barkodlbl.Location = new System.Drawing.Point(6, 50);
            this.barkodlbl.Name = "barkodlbl";
            this.barkodlbl.Size = new System.Drawing.Size(175, 37);
            this.barkodlbl.TabIndex = 0;
            this.barkodlbl.Text = "BARKOD NO =";
            this.barkodlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.groupBox1.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Controls.Add(this.sayimcglbt);
            this.groupBox1.Controls.Add(this.urunsystxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.sayimtekilbt);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.barkodgrid);
            this.groupBox1.Controls.Add(this.barkodtxt);
            this.groupBox1.Controls.Add(this.barkodlbl);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(933, 302);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ÜRÜN SAYIMI";
            // 
            // sayimcglbt
            // 
            this.sayimcglbt.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.sayimcglbt.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.sayimcglbt.Appearance.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayimcglbt.Appearance.Options.UseBackColor = true;
            this.sayimcglbt.Appearance.Options.UseBorderColor = true;
            this.sayimcglbt.Appearance.Options.UseFont = true;
            this.sayimcglbt.AppearanceHovered.ForeColor = System.Drawing.Color.Red;
            this.sayimcglbt.AppearanceHovered.Options.UseBackColor = true;
            this.sayimcglbt.AppearanceHovered.Options.UseForeColor = true;
            this.sayimcglbt.AppearancePressed.ForeColor = System.Drawing.Color.Red;
            this.sayimcglbt.AppearancePressed.Options.UseBackColor = true;
            this.sayimcglbt.AppearancePressed.Options.UseForeColor = true;
            this.sayimcglbt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sayimcglbt.ImageOptions.Image")));
            this.sayimcglbt.Location = new System.Drawing.Point(223, 218);
            this.sayimcglbt.Name = "sayimcglbt";
            this.sayimcglbt.Size = new System.Drawing.Size(158, 40);
            this.sayimcglbt.TabIndex = 8;
            this.sayimcglbt.Text = "Sayıma Ekle";
            this.sayimcglbt.Click += new System.EventHandler(this.sayimcglbt_Click);
            // 
            // urunsystxt
            // 
            this.urunsystxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.urunsystxt.BackColor = System.Drawing.Color.LightGray;
            this.urunsystxt.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunsystxt.Location = new System.Drawing.Point(133, 220);
            this.urunsystxt.Multiline = true;
            this.urunsystxt.Name = "urunsystxt";
            this.urunsystxt.Size = new System.Drawing.Size(84, 33);
            this.urunsystxt.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(10, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ürün Sayısı";
            // 
            // sayimtekilbt
            // 
            this.sayimtekilbt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sayimtekilbt.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.sayimtekilbt.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.sayimtekilbt.Appearance.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayimtekilbt.Appearance.Options.UseBackColor = true;
            this.sayimtekilbt.Appearance.Options.UseBorderColor = true;
            this.sayimtekilbt.Appearance.Options.UseFont = true;
            this.sayimtekilbt.AppearanceHovered.ForeColor = System.Drawing.Color.Red;
            this.sayimtekilbt.AppearanceHovered.Options.UseBackColor = true;
            this.sayimtekilbt.AppearanceHovered.Options.UseForeColor = true;
            this.sayimtekilbt.AppearancePressed.ForeColor = System.Drawing.Color.Red;
            this.sayimtekilbt.AppearancePressed.Options.UseBackColor = true;
            this.sayimtekilbt.AppearancePressed.Options.UseForeColor = true;
            this.sayimtekilbt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sayimtekilbt.ImageOptions.Image")));
            this.sayimtekilbt.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.sayimtekilbt.Location = new System.Drawing.Point(550, 50);
            this.sayimtekilbt.Name = "sayimtekilbt";
            this.sayimtekilbt.Size = new System.Drawing.Size(158, 39);
            this.sayimtekilbt.TabIndex = 5;
            this.sayimtekilbt.Text = "Sayıma Ekle";
            this.sayimtekilbt.Click += new System.EventHandler(this.sayimtekilbt_Click);
            this.sayimtekilbt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sayimtekilbt_KeyDown);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.DarkGray;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(714, 62);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(128, 22);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "MERKEZ DEPO";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // barkodgrid
            // 
            this.barkodgrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.barkodgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.barkodgrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.barkodgrid.BackgroundColor = System.Drawing.Color.LightGray;
            this.barkodgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.barkodgrid.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.barkodgrid.Location = new System.Drawing.Point(6, 90);
            this.barkodgrid.Name = "barkodgrid";
            this.barkodgrid.RowHeadersWidth = 51;
            this.barkodgrid.RowTemplate.Height = 24;
            this.barkodgrid.Size = new System.Drawing.Size(908, 117);
            this.barkodgrid.TabIndex = 2;
            // 
            // barkodtxt
            // 
            this.barkodtxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.barkodtxt.BackColor = System.Drawing.Color.LightGray;
            this.barkodtxt.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barkodtxt.Location = new System.Drawing.Point(187, 51);
            this.barkodtxt.Multiline = true;
            this.barkodtxt.Name = "barkodtxt";
            this.barkodtxt.Size = new System.Drawing.Size(357, 37);
            this.barkodtxt.TabIndex = 1;
            this.barkodtxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bitirvegosterbt
            // 
            this.bitirvegosterbt.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.bitirvegosterbt.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.bitirvegosterbt.Appearance.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bitirvegosterbt.Appearance.Options.UseBackColor = true;
            this.bitirvegosterbt.Appearance.Options.UseBorderColor = true;
            this.bitirvegosterbt.Appearance.Options.UseFont = true;
            this.bitirvegosterbt.AppearanceHovered.ForeColor = System.Drawing.Color.Red;
            this.bitirvegosterbt.AppearanceHovered.Options.UseBackColor = true;
            this.bitirvegosterbt.AppearanceHovered.Options.UseForeColor = true;
            this.bitirvegosterbt.AppearancePressed.ForeColor = System.Drawing.Color.Red;
            this.bitirvegosterbt.AppearancePressed.Options.UseBackColor = true;
            this.bitirvegosterbt.AppearancePressed.Options.UseForeColor = true;
            this.bitirvegosterbt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bitirvegosterbt.ImageOptions.Image")));
            this.bitirvegosterbt.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.BottomCenter;
            this.bitirvegosterbt.Location = new System.Drawing.Point(306, 278);
            this.bitirvegosterbt.Name = "bitirvegosterbt";
            this.bitirvegosterbt.Size = new System.Drawing.Size(140, 63);
            this.bitirvegosterbt.TabIndex = 3;
            this.bitirvegosterbt.Text = "BİTİR VE GÖSTER";
            this.bitirvegosterbt.Click += new System.EventHandler(this.bitirvegosterbt_Click);
            // 
            // bitirgrid
            // 
            this.bitirgrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bitirgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bitirgrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.bitirgrid.BackgroundColor = System.Drawing.Color.LightGray;
            this.bitirgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bitirgrid.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.bitirgrid.Location = new System.Drawing.Point(6, 53);
            this.bitirgrid.Name = "bitirgrid";
            this.bitirgrid.RowHeadersWidth = 51;
            this.bitirgrid.RowTemplate.Height = 24;
            this.bitirgrid.Size = new System.Drawing.Size(908, 219);
            this.bitirgrid.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.simpleButton2);
            this.groupBox2.Controls.Add(this.simpleButton1);
            this.groupBox2.Controls.Add(this.bitirgrid);
            this.groupBox2.Controls.Add(this.bitirvegosterbt);
            this.groupBox2.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 320);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(933, 358);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ÜRÜNÜ BİTİR VE GÖSTER";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.simpleButton2.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseBorderColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.AppearanceHovered.ForeColor = System.Drawing.Color.Red;
            this.simpleButton2.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton2.AppearanceHovered.Options.UseForeColor = true;
            this.simpleButton2.AppearancePressed.ForeColor = System.Drawing.Color.Red;
            this.simpleButton2.AppearancePressed.Options.UseBackColor = true;
            this.simpleButton2.AppearancePressed.Options.UseForeColor = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.BottomCenter;
            this.simpleButton2.Location = new System.Drawing.Point(452, 278);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(140, 63);
            this.simpleButton2.TabIndex = 11;
            this.simpleButton2.Text = "TÜMÜNÜ GÖSTER";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.simpleButton1.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseBorderColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.AppearanceHovered.ForeColor = System.Drawing.Color.Red;
            this.simpleButton1.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton1.AppearanceHovered.Options.UseForeColor = true;
            this.simpleButton1.AppearancePressed.ForeColor = System.Drawing.Color.Red;
            this.simpleButton1.AppearancePressed.Options.UseBackColor = true;
            this.simpleButton1.AppearancePressed.Options.UseForeColor = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.BottomCenter;
            this.simpleButton1.Location = new System.Drawing.Point(774, 278);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(140, 63);
            this.simpleButton1.TabIndex = 10;
            this.simpleButton1.Text = "BİTİR VE SIFIRLA";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(954, 702);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "ÜRÜN SAYIM EKRANI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barkodgrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitirgrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label barkodlbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox barkodtxt;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.DataGridView barkodgrid;
        private DevExpress.XtraEditors.SimpleButton bitirvegosterbt;
        private System.Windows.Forms.CheckBox checkBox1;
        private DevExpress.XtraEditors.SimpleButton sayimtekilbt;
        private DevExpress.XtraEditors.SimpleButton sayimcglbt;
        private System.Windows.Forms.TextBox urunsystxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView bitirgrid;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}

