namespace PhoenixCollaborationApp
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
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.TitleBar = new System.Windows.Forms.Panel();
            this.minimizeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.closeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.logoAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.logo = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.username1 = new System.Windows.Forms.TextBox();
            this.password1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.leftSideMenu = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sidePanelAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.leftSideMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.TitleBar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // TitleBar
            // 
            this.TitleBar.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.TitleBar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.TitleBar.Controls.Add(this.minimizeBtn);
            this.TitleBar.Controls.Add(this.closeBtn);
            this.TitleBar.Controls.Add(this.panel4);
            this.TitleBar.Controls.Add(this.bunifuImageButton3);
            this.TitleBar.Controls.Add(this.bunifuImageButton2);
            this.TitleBar.Controls.Add(this.bunifuImageButton1);
            this.sidePanelAnimator.SetDecoration(this.TitleBar, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.TitleBar, BunifuAnimatorNS.DecorationType.None);
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Margin = new System.Windows.Forms.Padding(2);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(899, 32);
            this.TitleBar.TabIndex = 5;
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.sidePanelAnimator.SetDecoration(this.minimizeBtn, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.minimizeBtn, BunifuAnimatorNS.DecorationType.None);
            this.minimizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("minimizeBtn.Image")));
            this.minimizeBtn.ImageActive = null;
            this.minimizeBtn.Location = new System.Drawing.Point(828, 9);
            this.minimizeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(22, 19);
            this.minimizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeBtn.TabIndex = 5;
            this.minimizeBtn.TabStop = false;
            this.minimizeBtn.Zoom = 10;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click_1);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.sidePanelAnimator.SetDecoration(this.closeBtn, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.closeBtn, BunifuAnimatorNS.DecorationType.None);
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.ImageActive = null;
            this.closeBtn.Location = new System.Drawing.Point(854, 9);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(33, 19);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeBtn.TabIndex = 3;
            this.closeBtn.TabStop = false;
            this.closeBtn.Zoom = 10;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // panel4
            // 
            this.sidePanelAnimator.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.panel4.Location = new System.Drawing.Point(464, 32);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(364, 492);
            this.panel4.TabIndex = 0;
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.sidePanelAnimator.SetDecoration(this.bunifuImageButton3, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.bunifuImageButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(933, 6);
            this.bunifuImageButton3.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(10, 19);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 2;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.sidePanelAnimator.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(966, 6);
            this.bunifuImageButton2.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(10, 19);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 1;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.sidePanelAnimator.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(997, 6);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(10, 19);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // logoAnimator
            // 
            this.logoAnimator.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind;
            this.logoAnimator.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.logoAnimator.DefaultAnimation = animation2;
            // 
            // logo
            // 
            this.logoAnimator.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.sidePanelAnimator.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(335, 56);
            this.logo.Margin = new System.Windows.Forms.Padding(2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(216, 79);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.logoAnimator.SetDecoration(this.button2, BunifuAnimatorNS.DecorationType.None);
            this.sidePanelAnimator.SetDecoration(this.button2, BunifuAnimatorNS.DecorationType.None);
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Window;
            this.button2.Location = new System.Drawing.Point(142, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "Login";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // username1
            // 
            this.username1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logoAnimator.SetDecoration(this.username1, BunifuAnimatorNS.DecorationType.None);
            this.sidePanelAnimator.SetDecoration(this.username1, BunifuAnimatorNS.DecorationType.None);
            this.username1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username1.Location = new System.Drawing.Point(142, 56);
            this.username1.Name = "username1";
            this.username1.Size = new System.Drawing.Size(167, 26);
            this.username1.TabIndex = 2;
            this.username1.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // password1
            // 
            this.password1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logoAnimator.SetDecoration(this.password1, BunifuAnimatorNS.DecorationType.None);
            this.sidePanelAnimator.SetDecoration(this.password1, BunifuAnimatorNS.DecorationType.None);
            this.password1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password1.Location = new System.Drawing.Point(142, 112);
            this.password1.Multiline = true;
            this.password1.Name = "password1";
            this.password1.Size = new System.Drawing.Size(167, 27);
            this.password1.TabIndex = 3;
            this.password1.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.logoAnimator.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.sidePanelAnimator.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(24, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.logoAnimator.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.sidePanelAnimator.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(24, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Password:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // leftSideMenu
            // 
            this.leftSideMenu.AccessibleName = "leftSideMenu";
            this.leftSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.leftSideMenu.Controls.Add(this.groupBox1);
            this.leftSideMenu.Controls.Add(this.logo);
            this.sidePanelAnimator.SetDecoration(this.leftSideMenu, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.leftSideMenu, BunifuAnimatorNS.DecorationType.None);
            this.leftSideMenu.Location = new System.Drawing.Point(0, 0);
            this.leftSideMenu.Margin = new System.Windows.Forms.Padding(2);
            this.leftSideMenu.Name = "leftSideMenu";
            this.leftSideMenu.Size = new System.Drawing.Size(899, 498);
            this.leftSideMenu.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.username1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.password1);
            this.sidePanelAnimator.SetDecoration(this.groupBox1, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.groupBox1, BunifuAnimatorNS.DecorationType.None);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(269, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 309);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LOGIN";
            // 
            // sidePanelAnimator
            // 
            this.sidePanelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Rotate;
            this.sidePanelAnimator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(50);
            animation1.RotateCoeff = 1F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.sidePanelAnimator.DefaultAnimation = animation1;
            // 
            // button1
            // 
            this.logoAnimator.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.sidePanelAnimator.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.ForestGreen;
            this.button1.Location = new System.Drawing.Point(142, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Change Password";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.logoAnimator.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.sidePanelAnimator.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "(OR)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 498);
            this.Controls.Add(this.TitleBar);
            this.Controls.Add(this.leftSideMenu);
            this.logoAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.sidePanelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.leftSideMenu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel TitleBar;
        private Bunifu.Framework.UI.BunifuImageButton minimizeBtn;
        private BunifuAnimatorNS.BunifuTransition sidePanelAnimator;
        private BunifuAnimatorNS.BunifuTransition logoAnimator;
        private Bunifu.Framework.UI.BunifuImageButton closeBtn;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel leftSideMenu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox password1;
        private System.Windows.Forms.TextBox username1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}