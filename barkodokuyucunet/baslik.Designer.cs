namespace barkodokuyucunet
{
    partial class baslik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(baslik));
            this.gr1 = new System.Windows.Forms.GroupBox();
            this.ımageSlider1 = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.depobox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ofisbox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.müsteriisimbox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.musterilbl = new System.Windows.Forms.Label();
            this.Tarihlbl = new System.Windows.Forms.Label();
            this.textEdit1 = new DevExpress.XtraEditors.TimeEdit();
            this.gr1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ımageSlider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depobox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ofisbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.müsteriisimbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gr1
            // 
            this.gr1.BackColor = System.Drawing.Color.Gainsboro;
            this.gr1.Controls.Add(this.ımageSlider1);
            this.gr1.Controls.Add(this.depobox);
            this.gr1.Controls.Add(this.ofisbox);
            this.gr1.Controls.Add(this.müsteriisimbox);
            this.gr1.Controls.Add(this.label2);
            this.gr1.Controls.Add(this.label1);
            this.gr1.Controls.Add(this.musterilbl);
            this.gr1.Controls.Add(this.Tarihlbl);
            this.gr1.Controls.Add(this.textEdit1);
            this.gr1.Location = new System.Drawing.Point(0, 0);
            this.gr1.Name = "gr1";
            this.gr1.Size = new System.Drawing.Size(1084, 455);
            this.gr1.TabIndex = 0;
            this.gr1.TabStop = false;
            // 
            // ımageSlider1
            // 
            this.ımageSlider1.AllowLooping = true;
            this.ımageSlider1.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.ımageSlider1.Appearance.Options.UseBackColor = true;
            this.ımageSlider1.AutoSlide = DevExpress.XtraEditors.Controls.AutoSlide.Forward;
            this.ımageSlider1.AutoSlideInterval = 4000;
            this.ımageSlider1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ımageSlider1.CurrentImageIndex = 0;
            this.ımageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider1.Images"))));
            this.ımageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider1.Images1"))));
            this.ımageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider1.Images2"))));
            this.ımageSlider1.Location = new System.Drawing.Point(445, 54);
            this.ımageSlider1.Name = "ımageSlider1";
            this.ımageSlider1.Size = new System.Drawing.Size(247, 205);
            this.ımageSlider1.TabIndex = 12;
            this.ımageSlider1.Text = "ımageSlider1";
            // 
            // depobox
            // 
            this.depobox.Location = new System.Drawing.Point(144, 229);
            this.depobox.Name = "depobox";
            this.depobox.Properties.Appearance.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.depobox.Properties.Appearance.Options.UseFont = true;
            this.depobox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.depobox.Size = new System.Drawing.Size(274, 30);
            this.depobox.TabIndex = 10;
            this.depobox.SelectedIndexChanged += new System.EventHandler(this.depobox_SelectedIndexChanged);
            // 
            // ofisbox
            // 
            this.ofisbox.Location = new System.Drawing.Point(144, 73);
            this.ofisbox.Name = "ofisbox";
            this.ofisbox.Properties.Appearance.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ofisbox.Properties.Appearance.Options.UseFont = true;
            this.ofisbox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ofisbox.Size = new System.Drawing.Size(274, 30);
            this.ofisbox.TabIndex = 9;
            this.ofisbox.SelectedIndexChanged += new System.EventHandler(this.ofisbox_SelectedIndexChanged);
            // 
            // müsteriisimbox
            // 
            this.müsteriisimbox.Location = new System.Drawing.Point(144, 151);
            this.müsteriisimbox.Name = "müsteriisimbox";
            this.müsteriisimbox.Properties.Appearance.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.müsteriisimbox.Properties.Appearance.Options.UseFont = true;
            this.müsteriisimbox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.müsteriisimbox.Properties.DropDownRows = 10;
            this.müsteriisimbox.Properties.Sorted = true;
            this.müsteriisimbox.Size = new System.Drawing.Size(274, 30);
            this.müsteriisimbox.TabIndex = 8;
            this.müsteriisimbox.SelectedIndexChanged += new System.EventHandler(this.müsteriisimbox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Depo Kodu :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ofis Kodu :";
            // 
            // musterilbl
            // 
            this.musterilbl.AutoSize = true;
            this.musterilbl.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musterilbl.Location = new System.Drawing.Point(8, 158);
            this.musterilbl.Name = "musterilbl";
            this.musterilbl.Size = new System.Drawing.Size(126, 23);
            this.musterilbl.TabIndex = 2;
            this.musterilbl.Text = "Mağaza Kodu :";
            // 
            // Tarihlbl
            // 
            this.Tarihlbl.AutoSize = true;
            this.Tarihlbl.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tarihlbl.Location = new System.Drawing.Point(12, 22);
            this.Tarihlbl.Name = "Tarihlbl";
            this.Tarihlbl.Size = new System.Drawing.Size(73, 23);
            this.Tarihlbl.TabIndex = 0;
            this.Tarihlbl.Text = "TARİH :";
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = null;
            this.textEdit1.Location = new System.Drawing.Point(126, 15);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEdit1.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.textEdit1.Properties.MaskSettings.Set("mask", "d");
            this.textEdit1.Size = new System.Drawing.Size(184, 30);
            this.textEdit1.TabIndex = 1;
            // 
            // baslik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.gr1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "baslik";
            this.Text = "baslik";
            this.Load += new System.EventHandler(this.baslik_Load);
            this.gr1.ResumeLayout(false);
            this.gr1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ımageSlider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depobox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ofisbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.müsteriisimbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gr1;
        private System.Windows.Forms.Label Tarihlbl;
        private DevExpress.XtraEditors.TimeEdit textEdit1;
        private System.Windows.Forms.Label musterilbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.ComboBoxEdit müsteriisimbox;
        private DevExpress.XtraEditors.ComboBoxEdit ofisbox;
        private DevExpress.XtraEditors.Controls.ImageSlider ımageSlider1;
        public DevExpress.XtraEditors.ComboBoxEdit depobox;
    }
}