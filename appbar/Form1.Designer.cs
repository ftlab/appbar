using appbar.AppModel;

namespace appbar
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.appBar1 = new appbar.AppModel.AppBar();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(33, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(387, 306);
            this.panelControl1.TabIndex = 3;
            // 
            // appBar1
            // 
            this.appBar1.AllowDrag = false;
            this.appBar1.AllowSelectedItem = true;
            this.appBar1.Cursor = System.Windows.Forms.Cursors.Default;
            this.appBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.appBar1.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.appBar1.GroupTextToItemsIndent = 0;
            this.appBar1.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.appBar1.IndentBetweenGroups = 0;
            this.appBar1.IndentBetweenItems = 0;
            this.appBar1.ItemImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.appBar1.ItemPadding = new System.Windows.Forms.Padding(0);
            this.appBar1.ItemSize = 32;
            this.appBar1.ItemTextShowMode = DevExpress.XtraEditors.TileItemContentShowMode.Always;
            this.appBar1.Location = new System.Drawing.Point(0, 0);
            this.appBar1.Margin = new System.Windows.Forms.Padding(0);
            this.appBar1.Name = "appBar1";
            this.appBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.appBar1.Padding = new System.Windows.Forms.Padding(0);
            this.appBar1.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.appBar1.SelectionColorMode = DevExpress.XtraBars.Navigation.SelectionColorMode.UseItemBackColor;
            this.appBar1.ShowGroupText = false;
            this.appBar1.Size = new System.Drawing.Size(33, 306);
            this.appBar1.TabIndex = 2;
            this.appBar1.Text = "appBar1";
            this.appBar1.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Top;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 306);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.appBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AppBar appBar1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }

}

