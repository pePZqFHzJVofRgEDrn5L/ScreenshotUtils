﻿namespace ScreenshotUtils.ControlExt
{
    partial class ScrollBar {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.timScroll = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timScroll
            // 
            this.timScroll.Enabled = true;
            this.timScroll.Tick += new System.EventHandler(this.timScroll_Tick);
            // 
            // LxzhScrollBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.DrawBorder = false;
            this.Name = "LxzhScrollBar";
            this.Size = new System.Drawing.Size(18, 150);
            this.Load += new System.EventHandler(this.LxzhScrollBar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timScroll;

    }
}