﻿
namespace Lab03___02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.heThongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dinhDangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbFont = new System.Windows.Forms.ToolStripComboBox();
            this.tsbSize = new System.Windows.Forms.ToolStripComboBox();
            this.richText = new System.Windows.Forms.RichTextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.InDam = new System.Windows.Forms.ToolStripButton();
            this.Nghieng = new System.Windows.Forms.ToolStripButton();
            this.GachChan = new System.Windows.Forms.ToolStripButton();
            this.taoVanBanMoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moTapTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.luuNoiDungVanBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heThongToolStripMenuItem,
            this.dinhDangToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1518, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // heThongToolStripMenuItem
            // 
            this.heThongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taoVanBanMoiToolStripMenuItem,
            this.moTapTinToolStripMenuItem,
            this.luuNoiDungVanBanToolStripMenuItem,
            this.thoatToolStripMenuItem});
            this.heThongToolStripMenuItem.Name = "heThongToolStripMenuItem";
            this.heThongToolStripMenuItem.Size = new System.Drawing.Size(103, 29);
            this.heThongToolStripMenuItem.Text = "Hệ thống";
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(349, 34);
            this.thoatToolStripMenuItem.Text = "Thoát";
            // 
            // dinhDangToolStripMenuItem
            // 
            this.dinhDangToolStripMenuItem.Name = "dinhDangToolStripMenuItem";
            this.dinhDangToolStripMenuItem.Size = new System.Drawing.Size(111, 29);
            this.dinhDangToolStripMenuItem.Text = "Định dạng";
            this.dinhDangToolStripMenuItem.Click += new System.EventHandler(this.dinhDangToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.tsbFont,
            this.tsbSize,
            this.InDam,
            this.Nghieng,
            this.GachChan});
            this.toolStrip1.Location = new System.Drawing.Point(0, 33);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1518, 33);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbFont
            // 
            this.tsbFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tsbFont.Name = "tsbFont";
            this.tsbFont.Size = new System.Drawing.Size(180, 33);
            this.tsbFont.SelectedIndexChanged += new System.EventHandler(this.tsbFont_SelectedIndexChanged);
            // 
            // tsbSize
            // 
            this.tsbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tsbSize.Name = "tsbSize";
            this.tsbSize.Size = new System.Drawing.Size(180, 33);
            this.tsbSize.SelectedIndexChanged += new System.EventHandler(this.tsbFont_SelectedIndexChanged);
            // 
            // richText
            // 
            this.richText.Location = new System.Drawing.Point(0, 80);
            this.richText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richText.Name = "richText";
            this.richText.Size = new System.Drawing.Size(974, 566);
            this.richText.TabIndex = 3;
            this.richText.Text = "";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Lab03___02.Properties.Resources.giấy;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.taoVanBanMoiToolStripMenuItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.luuNoiDungVanBanToolStripMenuItem_Click);
            // 
            // InDam
            // 
            this.InDam.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.InDam.Image = ((System.Drawing.Image)(resources.GetObject("InDam.Image")));
            this.InDam.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.InDam.Name = "InDam";
            this.InDam.Size = new System.Drawing.Size(34, 28);
            this.InDam.Text = "toolStripButton3";
            this.InDam.Click += new System.EventHandler(this.InDam_Click);
            // 
            // Nghieng
            // 
            this.Nghieng.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Nghieng.Image = ((System.Drawing.Image)(resources.GetObject("Nghieng.Image")));
            this.Nghieng.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Nghieng.Name = "Nghieng";
            this.Nghieng.Size = new System.Drawing.Size(34, 28);
            this.Nghieng.Text = "toolStripButton4";
            this.Nghieng.Click += new System.EventHandler(this.Nghieng_Click);
            // 
            // GachChan
            // 
            this.GachChan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GachChan.Image = global::Lab03___02.Properties.Resources.underline_text_option_25433;
            this.GachChan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GachChan.Name = "GachChan";
            this.GachChan.Size = new System.Drawing.Size(34, 28);
            this.GachChan.Text = "toolStripButton5";
            this.GachChan.Click += new System.EventHandler(this.GachChan_Click);
            // 
            // taoVanBanMoiToolStripMenuItem
            // 
            this.taoVanBanMoiToolStripMenuItem.Image = global::Lab03___02.Properties.Resources.giấy;
            this.taoVanBanMoiToolStripMenuItem.Name = "taoVanBanMoiToolStripMenuItem";
            this.taoVanBanMoiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.taoVanBanMoiToolStripMenuItem.Size = new System.Drawing.Size(349, 34);
            this.taoVanBanMoiToolStripMenuItem.Text = "Tạo văn bản mới";
            this.taoVanBanMoiToolStripMenuItem.Click += new System.EventHandler(this.taoVanBanMoiToolStripMenuItem_Click);
            // 
            // moTapTinToolStripMenuItem
            // 
            this.moTapTinToolStripMenuItem.Image = global::Lab03___02.Properties.Resources.Mở_tập_tin;
            this.moTapTinToolStripMenuItem.Name = "moTapTinToolStripMenuItem";
            this.moTapTinToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.moTapTinToolStripMenuItem.Size = new System.Drawing.Size(349, 34);
            this.moTapTinToolStripMenuItem.Text = "Mở tập tin";
            this.moTapTinToolStripMenuItem.Click += new System.EventHandler(this.moTapTinToolStripMenuItem_Click);
            // 
            // luuNoiDungVanBanToolStripMenuItem
            // 
            this.luuNoiDungVanBanToolStripMenuItem.Image = global::Lab03___02.Properties.Resources.lưu;
            this.luuNoiDungVanBanToolStripMenuItem.Name = "luuNoiDungVanBanToolStripMenuItem";
            this.luuNoiDungVanBanToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.luuNoiDungVanBanToolStripMenuItem.Size = new System.Drawing.Size(349, 34);
            this.luuNoiDungVanBanToolStripMenuItem.Text = "Lưu nội dung văn bản";
            this.luuNoiDungVanBanToolStripMenuItem.Click += new System.EventHandler(this.luuNoiDungVanBanToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1518, 669);
            this.Controls.Add(this.richText);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem heThongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dinhDangToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem taoVanBanMoiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moTapTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem luuNoiDungVanBanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox tsbFont;
        private System.Windows.Forms.ToolStripComboBox tsbSize;
        private System.Windows.Forms.ToolStripButton InDam;
        private System.Windows.Forms.ToolStripButton Nghieng;
        private System.Windows.Forms.ToolStripButton GachChan;
        private System.Windows.Forms.RichTextBox richText;
    }
}

