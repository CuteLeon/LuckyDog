﻿namespace LuckDog.Controls
{
    partial class LargeButton
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // LargeButton
            // 
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LargeButton_MouseDown);
            this.MouseEnter += new System.EventHandler(this.LargeButton_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.LargeButton_MouseLeave);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LargeButton_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
