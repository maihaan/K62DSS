namespace DSS.GUI
{
    partial class GMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mệnhĐềToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.luậtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.clbMenhDe = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbKetQua = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btSuyLuan = new System.Windows.Forms.Button();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mệnhĐềToolStripMenuItem,
            this.luậtToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // mệnhĐềToolStripMenuItem
            // 
            this.mệnhĐềToolStripMenuItem.Image = global::DSS.Properties.Resources.detail;
            this.mệnhĐềToolStripMenuItem.Name = "mệnhĐềToolStripMenuItem";
            this.mệnhĐềToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mệnhĐềToolStripMenuItem.Text = "Mệnh đề";
            this.mệnhĐềToolStripMenuItem.Click += new System.EventHandler(this.mệnhĐềToolStripMenuItem_Click);
            // 
            // luậtToolStripMenuItem
            // 
            this.luậtToolStripMenuItem.Image = global::DSS.Properties.Resources.TramIcon20;
            this.luậtToolStripMenuItem.Name = "luậtToolStripMenuItem";
            this.luậtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.luậtToolStripMenuItem.Text = "Luật";
            this.luậtToolStripMenuItem.Click += new System.EventHandler(this.luậtToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Image = global::DSS.Properties.Resources.close20;
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // clbMenhDe
            // 
            this.clbMenhDe.FormattingEnabled = true;
            this.clbMenhDe.Location = new System.Drawing.Point(15, 75);
            this.clbMenhDe.Name = "clbMenhDe";
            this.clbMenhDe.Size = new System.Drawing.Size(157, 319);
            this.clbMenhDe.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chọn các mệnh đề đã biết";
            // 
            // tbKetQua
            // 
            this.tbKetQua.Location = new System.Drawing.Point(179, 75);
            this.tbKetQua.Multiline = true;
            this.tbKetQua.Name = "tbKetQua";
            this.tbKetQua.Size = new System.Drawing.Size(609, 363);
            this.tbKetQua.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kết quả suy luận";
            // 
            // btSuyLuan
            // 
            this.btSuyLuan.Image = global::DSS.Properties.Resources.VideoIcon20;
            this.btSuyLuan.Location = new System.Drawing.Point(15, 400);
            this.btSuyLuan.Name = "btSuyLuan";
            this.btSuyLuan.Size = new System.Drawing.Size(157, 38);
            this.btSuyLuan.TabIndex = 4;
            this.btSuyLuan.Text = "   Suy luận";
            this.btSuyLuan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSuyLuan.UseVisualStyleBackColor = true;
            this.btSuyLuan.Click += new System.EventHandler(this.btSuyLuan_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::DSS.Properties.Resources.detail;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(74, 22);
            this.toolStripButton1.Text = "Mệnh đề";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::DSS.Properties.Resources.TramIcon20;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(50, 22);
            this.toolStripButton2.Text = "Luật";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = global::DSS.Properties.Resources.close20;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(57, 22);
            this.toolStripButton3.Text = "Thoát";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // GMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbKetQua);
            this.Controls.Add(this.btSuyLuan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clbMenhDe);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GMain";
            this.Text = "Hệ hỗ trợ ra quyết định";
            this.Load += new System.EventHandler(this.GMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mệnhĐềToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem luậtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.CheckedListBox clbMenhDe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSuyLuan;
        private System.Windows.Forms.TextBox tbKetQua;
        private System.Windows.Forms.Label label2;
    }
}