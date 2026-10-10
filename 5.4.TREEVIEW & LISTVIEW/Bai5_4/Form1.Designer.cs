namespace Bai5_4
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblViewMode = new System.Windows.Forms.Label();
            this.cboViewMode = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvDepartments = new System.Windows.Forms.TreeView();
            this.imgListTree = new System.Windows.Forms.ImageList(this.components);
            this.lsvEmployees = new System.Windows.Forms.ListView();
            this.imgListLarge = new System.Windows.Forms.ImageList(this.components);
            this.imgListSmall = new System.Windows.Forms.ImageList(this.components);
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lblViewMode);
            this.panelTop.Controls.Add(this.cboViewMode);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(850, 40);
            this.panelTop.TabIndex = 0;
            // 
            // lblViewMode
            // 
            this.lblViewMode.AutoSize = true;
            this.lblViewMode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewMode.Location = new System.Drawing.Point(12, 12);
            this.lblViewMode.Name = "lblViewMode";
            this.lblViewMode.Size = new System.Drawing.Size(74, 15);
            this.lblViewMode.TabIndex = 0;
            this.lblViewMode.Text = "Chế độ xem:";
            // 
            // cboViewMode
            // 
            this.cboViewMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboViewMode.FormattingEnabled = true;
            this.cboViewMode.Location = new System.Drawing.Point(92, 9);
            this.cboViewMode.Name = "cboViewMode";
            this.cboViewMode.Size = new System.Drawing.Size(150, 21);
            this.cboViewMode.TabIndex = 0;
            this.cboViewMode.SelectedIndexChanged += new System.EventHandler(this.cboViewMode_SelectedIndexChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 40);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvDepartments);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lsvEmployees);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.splitContainer1.Size = new System.Drawing.Size(850, 440);
            this.splitContainer1.SplitterDistance = 280;
            this.splitContainer1.TabIndex = 1;
            // 
            // tvDepartments
            // 
            this.tvDepartments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvDepartments.ImageIndex = 0;
            this.tvDepartments.ImageList = this.imgListTree;
            this.tvDepartments.Location = new System.Drawing.Point(5, 5);
            this.tvDepartments.Name = "tvDepartments";
            this.tvDepartments.SelectedImageIndex = 0;
            this.tvDepartments.Size = new System.Drawing.Size(270, 430);
            this.tvDepartments.TabIndex = 0;
            this.tvDepartments.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvDepartments_AfterSelect);
            // 
            // imgListTree
            // 
            this.imgListTree.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgListTree.ImageSize = new System.Drawing.Size(16, 16);
            this.imgListTree.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lsvEmployees
            // 
            this.lsvEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvEmployees.HideSelection = false;
            this.lsvEmployees.LargeImageList = this.imgListLarge;
            this.lsvEmployees.Location = new System.Drawing.Point(5, 5);
            this.lsvEmployees.Name = "lsvEmployees";
            this.lsvEmployees.Size = new System.Drawing.Size(556, 430);
            this.lsvEmployees.SmallImageList = this.imgListSmall;
            this.lsvEmployees.TabIndex = 0;
            this.lsvEmployees.UseCompatibleStateImageBehavior = false;
            // 
            // imgListLarge
            // 
            this.imgListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListLarge.ImageStream")));
            this.imgListLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListLarge.Images.SetKeyName(0, "Screenshot 2026-10-01 162748.png");
            // 
            // imgListSmall
            // 
            this.imgListSmall.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgListSmall.ImageSize = new System.Drawing.Size(16, 16);
            this.imgListSmall.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 480);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panelTop);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trình quản lý tập tin dạng chuyên nghiệp (TreeView & ListView)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblViewMode;
        private System.Windows.Forms.ComboBox cboViewMode;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvDepartments;
        private System.Windows.Forms.ListView lsvEmployees;
        private System.Windows.Forms.ImageList imgListTree;
        private System.Windows.Forms.ImageList imgListLarge;
        private System.Windows.Forms.ImageList imgListSmall;
    }
}