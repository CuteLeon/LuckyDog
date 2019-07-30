namespace LuckDog.Forms
{
    partial class StartUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartUpForm));
            this.HerosPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.DrawButton = new LuckDog.Controls.LargeButton();
            this.SkinPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // HerosPanel
            // 
            this.HerosPanel.AutoScroll = true;
            this.HerosPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(83)))), ((int)(((byte)(125)))));
            this.HerosPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.HerosPanel.Location = new System.Drawing.Point(0, 0);
            this.HerosPanel.Name = "HerosPanel";
            this.HerosPanel.Size = new System.Drawing.Size(341, 491);
            this.HerosPanel.TabIndex = 0;
            this.HerosPanel.Visible = false;
            // 
            // DrawButton
            // 
            this.DrawButton.AutoEllipsis = true;
            this.DrawButton.BackColor = System.Drawing.Color.DimGray;
            this.DrawButton.Font = new System.Drawing.Font("微软雅黑", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DrawButton.ForeColor = System.Drawing.Color.White;
            this.DrawButton.Image = ((System.Drawing.Image)(resources.GetObject("DrawButton.Image")));
            this.DrawButton.Location = new System.Drawing.Point(392, 286);
            this.DrawButton.Name = "DrawButton";
            this.DrawButton.Size = new System.Drawing.Size(236, 128);
            this.DrawButton.TabIndex = 1;
            this.DrawButton.Text = "抽奖";
            this.DrawButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DrawButton.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // SkinPanel
            // 
            this.SkinPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(83)))), ((int)(((byte)(125)))));
            this.SkinPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.SkinPanel.Location = new System.Drawing.Point(726, 0);
            this.SkinPanel.Name = "SkinPanel";
            this.SkinPanel.Size = new System.Drawing.Size(80, 491);
            this.SkinPanel.TabIndex = 2;
            this.SkinPanel.Visible = false;
            // 
            // StartUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LuckDog.AppResource.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(806, 491);
            this.Controls.Add(this.SkinPanel);
            this.Controls.Add(this.DrawButton);
            this.Controls.Add(this.HerosPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Luck Dog";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.StartUpForm_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel HerosPanel;
        private Controls.LargeButton DrawButton;
        private System.Windows.Forms.FlowLayoutPanel SkinPanel;
    }
}