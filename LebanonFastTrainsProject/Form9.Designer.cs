namespace LebanonFastTrainsProject
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radButton3 = new Telerik.WinControls.UI.RadButton();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.radMenuButtonItem1 = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.radMenuButtonItem2 = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.radMenuButtonItem3 = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.radMenuButtonItem4 = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI Symbol", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(90, 79);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(263, 33);
            this.radLabel1.TabIndex = 13;
            this.radLabel1.Text = "Manage the passengers :";
            // 
            // radButton3
            // 
            this.radButton3.Location = new System.Drawing.Point(299, 264);
            this.radButton3.Name = "radButton3";
            this.radButton3.Size = new System.Drawing.Size(150, 40);
            this.radButton3.TabIndex = 12;
            this.radButton3.Text = "Remove a Passenger";
            this.radButton3.Click += new System.EventHandler(this.radButton3_Click);
            // 
            // radButton2
            // 
            this.radButton2.Location = new System.Drawing.Point(299, 180);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(150, 40);
            this.radButton2.TabIndex = 11;
            this.radButton2.Text = "Add a New Passenger";
            this.radButton2.Click += new System.EventHandler(this.radButton2_Click);
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(299, 360);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(150, 40);
            this.radButton1.TabIndex = 10;
            this.radButton1.Text = "Show All passengers";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // radMenu1
            // 
            this.radMenu1.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F);
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuButtonItem1,
            this.radMenuButtonItem2,
            this.radMenuButtonItem3,
            this.radMenuButtonItem4});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Size = new System.Drawing.Size(850, 30);
            this.radMenu1.TabIndex = 9;
            this.radMenu1.Text = "myMenu";
            // 
            // radMenuButtonItem1
            // 
            this.radMenuButtonItem1.DisplayStyle = Telerik.WinControls.DisplayStyle.ImageAndText;
            this.radMenuButtonItem1.EnableElementShadow = false;
            this.radMenuButtonItem1.Name = "radMenuButtonItem1";
            this.radMenuButtonItem1.Text = "Employees Managment";
            this.radMenuButtonItem1.UseCompatibleTextRendering = false;
            this.radMenuButtonItem1.Click += new System.EventHandler(this.radMenuButtonItem1_Click);
            // 
            // radMenuButtonItem2
            // 
            this.radMenuButtonItem2.EnableElementShadow = true;
            this.radMenuButtonItem2.EnableFocusBorder = false;
            this.radMenuButtonItem2.Name = "radMenuButtonItem2";
            this.radMenuButtonItem2.Text = "Passengers Managment";
            this.radMenuButtonItem2.UseCompatibleTextRendering = false;
            // 
            // radMenuButtonItem3
            // 
            this.radMenuButtonItem3.Name = "radMenuButtonItem3";
            this.radMenuButtonItem3.Text = "Stations/Tracks/Trains Managment";
            this.radMenuButtonItem3.UseCompatibleTextRendering = false;
            this.radMenuButtonItem3.Click += new System.EventHandler(this.radMenuButtonItem3_Click);
            // 
            // radMenuButtonItem4
            // 
            this.radMenuButtonItem4.Name = "radMenuButtonItem4";
            this.radMenuButtonItem4.Text = "Trips Managment";
            this.radMenuButtonItem4.UseCompatibleTextRendering = false;
            this.radMenuButtonItem4.Click += new System.EventHandler(this.radMenuButtonItem4_Click);
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(122, 152);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(236, 22);
            this.radLabel2.TabIndex = 14;
            this.radLabel2.Text = "To create a new Passenger\'s account:";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F);
            this.radLabel3.Location = new System.Drawing.Point(122, 236);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(236, 22);
            this.radLabel3.TabIndex = 15;
            this.radLabel3.Text = "To create a new Passenger\'s account:";
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F);
            this.radLabel4.Location = new System.Drawing.Point(122, 332);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(238, 22);
            this.radLabel4.TabIndex = 16;
            this.radLabel4.Text = "See the created passenger\'s accounts";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(500, 180);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(338, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 500);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.radButton3);
            this.Controls.Add(this.radButton2);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.radMenu1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form9";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadButton radButton3;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.RadMenuButtonItem radMenuButtonItem1;
        private Telerik.WinControls.UI.RadMenuButtonItem radMenuButtonItem2;
        private Telerik.WinControls.UI.RadMenuButtonItem radMenuButtonItem3;
        private Telerik.WinControls.UI.RadMenuButtonItem radMenuButtonItem4;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}