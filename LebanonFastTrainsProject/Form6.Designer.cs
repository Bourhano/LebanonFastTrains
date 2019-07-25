namespace LebanonFastTrainsProject
{
    partial class Form6
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.radMenuButtonItem1 = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.radMenuButtonItem2 = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.radMenuButtonItem3 = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.radMenuButtonItem4 = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.dg = new Telerik.WinControls.UI.RadGridView();
            this.gridViewTemplate1 = new Telerik.WinControls.UI.GridViewTemplate();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTemplate1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
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
            this.radMenu1.TabIndex = 4;
            this.radMenu1.Text = "myMenu";
            // 
            // radMenuButtonItem1
            // 
            this.radMenuButtonItem1.EnableElementShadow = true;
            this.radMenuButtonItem1.Name = "radMenuButtonItem1";
            this.radMenuButtonItem1.Text = "Employees Managment";
            this.radMenuButtonItem1.UseCompatibleTextRendering = false;
            this.radMenuButtonItem1.Click += new System.EventHandler(this.radMenuButtonItem1_Click);
            // 
            // radMenuButtonItem2
            // 
            this.radMenuButtonItem2.Name = "radMenuButtonItem2";
            this.radMenuButtonItem2.Text = "Passengers Managment";
            this.radMenuButtonItem2.UseCompatibleTextRendering = false;
            this.radMenuButtonItem2.Click += new System.EventHandler(this.radMenuButtonItem2_Click);
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
            // dg
            // 
            this.dg.Location = new System.Drawing.Point(301, 186);
            // 
            // 
            // 
            this.dg.MasterTemplate.AllowAddNewRow = false;
            this.dg.MasterTemplate.Templates.AddRange(new Telerik.WinControls.UI.GridViewTemplate[] {
            this.gridViewTemplate1});
            this.dg.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.dg.Name = "dg";
            this.dg.ReadOnly = true;
            this.dg.Size = new System.Drawing.Size(346, 218);
            this.dg.TabIndex = 5;
            this.dg.Text = "radGridView1";
            // 
            // gridViewTemplate1
            // 
            this.gridViewTemplate1.AllowDeleteRow = false;
            this.gridViewTemplate1.AllowEditRow = false;
            this.gridViewTemplate1.AutoExpandGroups = true;
            this.gridViewTemplate1.EnableAlternatingRowColor = true;
            this.gridViewTemplate1.ViewDefinition = tableViewDefinition1;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 500);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.radMenu1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form6";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTemplate1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.RadMenuButtonItem radMenuButtonItem1;
        private Telerik.WinControls.UI.RadMenuButtonItem radMenuButtonItem2;
        private Telerik.WinControls.UI.RadMenuButtonItem radMenuButtonItem3;
        private Telerik.WinControls.UI.RadMenuButtonItem radMenuButtonItem4;
        private Telerik.WinControls.UI.RadGridView dg;
        private Telerik.WinControls.UI.GridViewTemplate gridViewTemplate1;
    }
}