﻿namespace QQ_Client
{
    partial class Client
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.IP_Addr = new System.Windows.Forms.TextBox();
            this.Button_Send = new System.Windows.Forms.Button();
            this.Button_Close = new System.Windows.Forms.Button();
            this.InputText = new System.Windows.Forms.TextBox();
            this.ShowText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // IP_Addr
            // 
            this.IP_Addr.Location = new System.Drawing.Point(12, 36);
            this.IP_Addr.Name = "IP_Addr";
            this.IP_Addr.Size = new System.Drawing.Size(113, 21);
            this.IP_Addr.TabIndex = 9;
            this.IP_Addr.Text = "192.168.31.67";
            // 
            // Button_Send
            // 
            this.Button_Send.AutoSize = true;
            this.Button_Send.Location = new System.Drawing.Point(550, 547);
            this.Button_Send.Name = "Button_Send";
            this.Button_Send.Size = new System.Drawing.Size(83, 30);
            this.Button_Send.TabIndex = 8;
            this.Button_Send.Text = "发送";
            this.Button_Send.UseVisualStyleBackColor = true;
            // 
            // Button_Close
            // 
            this.Button_Close.AutoSize = true;
            this.Button_Close.BackColor = System.Drawing.SystemColors.Control;
            this.Button_Close.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Button_Close.Location = new System.Drawing.Point(466, 547);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(78, 30);
            this.Button_Close.TabIndex = 7;
            this.Button_Close.Text = "关闭";
            this.Button_Close.UseVisualStyleBackColor = false;
            // 
            // InputText
            // 
            this.InputText.BackColor = System.Drawing.Color.White;
            this.InputText.Location = new System.Drawing.Point(12, 452);
            this.InputText.Multiline = true;
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(632, 125);
            this.InputText.TabIndex = 6;
            // 
            // ShowText
            // 
            this.ShowText.BackColor = System.Drawing.Color.White;
            this.ShowText.Cursor = System.Windows.Forms.Cursors.Default;
            this.ShowText.Enabled = false;
            this.ShowText.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.ShowText.Location = new System.Drawing.Point(12, 63);
            this.ShowText.Multiline = true;
            this.ShowText.Name = "ShowText";
            this.ShowText.ReadOnly = true;
            this.ShowText.ShortcutsEnabled = false;
            this.ShowText.Size = new System.Drawing.Size(632, 354);
            this.ShowText.TabIndex = 5;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 612);
            this.Controls.Add(this.IP_Addr);
            this.Controls.Add(this.Button_Send);
            this.Controls.Add(this.Button_Close);
            this.Controls.Add(this.InputText);
            this.Controls.Add(this.ShowText);
            this.Name = "Client";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IP_Addr;
        private System.Windows.Forms.Button Button_Send;
        private System.Windows.Forms.Button Button_Close;
        private System.Windows.Forms.TextBox InputText;
        private System.Windows.Forms.TextBox ShowText;

    }
}

