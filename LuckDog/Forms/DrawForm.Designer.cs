namespace LuckDog.Forms
{
    partial class DrawForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrawForm));
            this.UnityTimer = new System.Windows.Forms.Timer(this.components);
            this.NameLabel = new System.Windows.Forms.Label();
            this.DrawButton = new LuckDog.Controls.LargeButton();
            this.SuspendLayout();
            // 
            // UnityTimer
            // 
            this.UnityTimer.Interval = 30;
            this.UnityTimer.Tick += new System.EventHandler(this.UnityTimer_Tick);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoEllipsis = true;
            this.NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel.Font = new System.Drawing.Font("微软雅黑", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NameLabel.ForeColor = System.Drawing.Color.White;
            this.NameLabel.Image = global::LuckDog.AppResource.ContainerBackground;
            this.NameLabel.Location = new System.Drawing.Point(147, 29);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(500, 155);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DrawButton
            // 
            this.DrawButton.AutoEllipsis = true;
            this.DrawButton.BackColor = System.Drawing.Color.DimGray;
            this.DrawButton.Font = new System.Drawing.Font("微软雅黑", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DrawButton.ForeColor = System.Drawing.Color.White;
            this.DrawButton.Image = ((System.Drawing.Image)(resources.GetObject("DrawButton.Image")));
            this.DrawButton.Location = new System.Drawing.Point(289, 289);
            this.DrawButton.Name = "DrawButton";
            this.DrawButton.Size = new System.Drawing.Size(236, 128);
            this.DrawButton.TabIndex = 0;
            this.DrawButton.Text = "开始";
            this.DrawButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DrawButton.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // DrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.DrawButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DrawForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Luck Dog";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.DrawForm_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.LargeButton DrawButton;
        private System.Windows.Forms.Timer UnityTimer;
        private System.Windows.Forms.Label NameLabel;
    }
}

