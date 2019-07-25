namespace LebanonFastTrainsProject
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.aquaTheme1 = new Telerik.WinControls.Themes.AquaTheme();
            this.breezeTheme1 = new Telerik.WinControls.Themes.BreezeTheme();
            this.desertTheme1 = new Telerik.WinControls.Themes.DesertTheme();
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.materialTealTheme1 = new Telerik.WinControls.Themes.MaterialTealTheme();
            this.windows7Theme1 = new Telerik.WinControls.Themes.Windows7Theme();
            this.windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.telerikMetroBlueTheme1 = new Telerik.WinControls.Themes.TelerikMetroBlueTheme();
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            this.office2013DarkTheme1 = new Telerik.WinControls.Themes.Office2013DarkTheme();
            this.highContrastBlackTheme1 = new Telerik.WinControls.Themes.HighContrastBlackTheme();
            this.radDesktopAlert1 = new Telerik.WinControls.UI.RadDesktopAlert(this.components);
            this.radProgressBar1 = new Telerik.WinControls.UI.RadProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radDesktopAlert1
            // 
            this.radDesktopAlert1.CaptionText = "hey";
            this.radDesktopAlert1.PopupAnimationEasing = Telerik.WinControls.RadEasingType.OutBack;
            // 
            // radProgressBar1
            // 
            this.radProgressBar1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radProgressBar1.Location = new System.Drawing.Point(177, 305);
            this.radProgressBar1.Name = "radProgressBar1";
            this.radProgressBar1.Size = new System.Drawing.Size(337, 39);
            this.radProgressBar1.TabIndex = 3;
            this.radProgressBar1.Text = "Loading The System\'s Data Base";
            this.radProgressBar1.Click += new System.EventHandler(this.radProgressBar1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Click here to know more about us";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 414);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radProgressBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Lebanon Fast Trains";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.Themes.AquaTheme aquaTheme1;
        private Telerik.WinControls.Themes.BreezeTheme breezeTheme1;
        private Telerik.WinControls.Themes.DesertTheme desertTheme1;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.Themes.Windows7Theme windows7Theme1;
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private Telerik.WinControls.Themes.TelerikMetroBlueTheme telerikMetroBlueTheme1;
        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
        private Telerik.WinControls.Themes.Office2013DarkTheme office2013DarkTheme1;
        private Telerik.WinControls.Themes.HighContrastBlackTheme highContrastBlackTheme1;
        private Telerik.WinControls.UI.RadDesktopAlert radDesktopAlert1;
        private Telerik.WinControls.UI.RadProgressBar radProgressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}

