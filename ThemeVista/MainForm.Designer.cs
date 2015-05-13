namespace ThemeVista
{
    partial class MainForm
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
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.FileUpload = new Telerik.WinControls.UI.RadBrowseEditor();
            this.BtnGenerate = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.FileUpload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGenerate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // FileUpload
            // 
            this.FileUpload.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileUpload.Location = new System.Drawing.Point(12, 12);
            this.FileUpload.Name = "FileUpload";
            this.FileUpload.Size = new System.Drawing.Size(185, 28);
            this.FileUpload.TabIndex = 0;
            this.FileUpload.Text = "FileUpload";
            this.FileUpload.ThemeName = "VisualStudio2012Dark";
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.Location = new System.Drawing.Point(218, 12);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(138, 28);
            this.BtnGenerate.TabIndex = 1;
            this.BtnGenerate.Text = "radButton1";
            this.BtnGenerate.ThemeName = "VisualStudio2012Dark";
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 447);
            this.Controls.Add(this.BtnGenerate);
            this.Controls.Add(this.FileUpload);
            this.Name = "MainForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "MainForm";
            this.ThemeName = "VisualStudio2012Dark";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FileUpload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGenerate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private Telerik.WinControls.UI.RadBrowseEditor FileUpload;
        private Telerik.WinControls.UI.RadButton BtnGenerate;
    }
}
