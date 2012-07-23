﻿using System;
using System.IO;
using System.Drawing;
using System.Diagnostics;
using System.Collections;
using System.Threading;
using System.ComponentModel;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PowerSDR
{
    partial class VoiceMessages : System.Windows.Forms.Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VoiceMessages));
            this.btnOK = new System.Windows.Forms.ButtonTS();
            this.btnApply = new System.Windows.Forms.ButtonTS();
            this.btnMsg1 = new System.Windows.Forms.CheckBoxTS();
            this.btnMsg2 = new System.Windows.Forms.CheckBoxTS();
            this.btnMsg3 = new System.Windows.Forms.CheckBoxTS();
            this.txtMsg1 = new System.Windows.Forms.TextBoxTS();
            this.txtMsg2 = new System.Windows.Forms.TextBoxTS();
            this.txtMsg3 = new System.Windows.Forms.TextBoxTS();
            this.txtMsg6 = new System.Windows.Forms.TextBoxTS();
            this.txtMsg5 = new System.Windows.Forms.TextBoxTS();
            this.txtMsg4 = new System.Windows.Forms.TextBoxTS();
            this.btnMsg6 = new System.Windows.Forms.CheckBoxTS();
            this.btnMsg5 = new System.Windows.Forms.CheckBoxTS();
            this.btnMsg4 = new System.Windows.Forms.CheckBoxTS();
            this.btnRecMsg1 = new System.Windows.Forms.CheckBoxTS();
            this.btnRecMsg2 = new System.Windows.Forms.CheckBoxTS();
            this.btnRecMsg3 = new System.Windows.Forms.CheckBoxTS();
            this.btnRecMsg4 = new System.Windows.Forms.CheckBoxTS();
            this.btnRecMsg5 = new System.Windows.Forms.CheckBoxTS();
            this.btnRecMsg6 = new System.Windows.Forms.CheckBoxTS();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Image = null;
            this.btnOK.Location = new System.Drawing.Point(189, 152);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnApply
            // 
            this.btnApply.Image = null;
            this.btnApply.Location = new System.Drawing.Point(293, 152);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnMsg1
            // 
            this.btnMsg1.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnMsg1.Image = null;
            this.btnMsg1.Location = new System.Drawing.Point(62, 26);
            this.btnMsg1.Name = "btnMsg1";
            this.btnMsg1.Size = new System.Drawing.Size(24, 20);
            this.btnMsg1.TabIndex = 2;
            this.btnMsg1.Text = "1";
            this.btnMsg1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMsg1.UseVisualStyleBackColor = true;
            this.btnMsg1.CheckedChanged += new System.EventHandler(this.btnMsg1_CheckedChanged);
            // 
            // btnMsg2
            // 
            this.btnMsg2.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnMsg2.Image = null;
            this.btnMsg2.Location = new System.Drawing.Point(62, 62);
            this.btnMsg2.Name = "btnMsg2";
            this.btnMsg2.Size = new System.Drawing.Size(24, 20);
            this.btnMsg2.TabIndex = 3;
            this.btnMsg2.Text = "2";
            this.btnMsg2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMsg2.UseVisualStyleBackColor = true;
            this.btnMsg2.CheckedChanged += new System.EventHandler(this.btnMsg2_CheckedChanged);
            // 
            // btnMsg3
            // 
            this.btnMsg3.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnMsg3.Image = null;
            this.btnMsg3.Location = new System.Drawing.Point(62, 100);
            this.btnMsg3.Name = "btnMsg3";
            this.btnMsg3.Size = new System.Drawing.Size(24, 20);
            this.btnMsg3.TabIndex = 4;
            this.btnMsg3.Text = "3";
            this.btnMsg3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMsg3.UseVisualStyleBackColor = true;
            this.btnMsg3.CheckedChanged += new System.EventHandler(this.btnMsg3_CheckedChanged);
            // 
            // txtMsg1
            // 
            this.txtMsg1.Location = new System.Drawing.Point(97, 27);
            this.txtMsg1.MaxLength = 64;
            this.txtMsg1.Name = "txtMsg1";
            this.txtMsg1.Size = new System.Drawing.Size(176, 20);
            this.txtMsg1.TabIndex = 8;
            // 
            // txtMsg2
            // 
            this.txtMsg2.Location = new System.Drawing.Point(97, 62);
            this.txtMsg2.MaxLength = 64;
            this.txtMsg2.Name = "txtMsg2";
            this.txtMsg2.Size = new System.Drawing.Size(176, 20);
            this.txtMsg2.TabIndex = 9;
            // 
            // txtMsg3
            // 
            this.txtMsg3.Location = new System.Drawing.Point(97, 101);
            this.txtMsg3.MaxLength = 64;
            this.txtMsg3.Name = "txtMsg3";
            this.txtMsg3.Size = new System.Drawing.Size(176, 20);
            this.txtMsg3.TabIndex = 10;
            // 
            // txtMsg6
            // 
            this.txtMsg6.Location = new System.Drawing.Point(363, 101);
            this.txtMsg6.MaxLength = 64;
            this.txtMsg6.Name = "txtMsg6";
            this.txtMsg6.Size = new System.Drawing.Size(176, 20);
            this.txtMsg6.TabIndex = 16;
            // 
            // txtMsg5
            // 
            this.txtMsg5.Location = new System.Drawing.Point(363, 62);
            this.txtMsg5.MaxLength = 64;
            this.txtMsg5.Name = "txtMsg5";
            this.txtMsg5.Size = new System.Drawing.Size(176, 20);
            this.txtMsg5.TabIndex = 15;
            // 
            // txtMsg4
            // 
            this.txtMsg4.Location = new System.Drawing.Point(363, 27);
            this.txtMsg4.MaxLength = 64;
            this.txtMsg4.Name = "txtMsg4";
            this.txtMsg4.Size = new System.Drawing.Size(176, 20);
            this.txtMsg4.TabIndex = 14;
            // 
            // btnMsg6
            // 
            this.btnMsg6.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnMsg6.Image = null;
            this.btnMsg6.Location = new System.Drawing.Point(328, 100);
            this.btnMsg6.Name = "btnMsg6";
            this.btnMsg6.Size = new System.Drawing.Size(24, 20);
            this.btnMsg6.TabIndex = 13;
            this.btnMsg6.Text = "6";
            this.btnMsg6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMsg6.UseVisualStyleBackColor = true;
            this.btnMsg6.CheckedChanged += new System.EventHandler(this.btnMsg6_CheckedChanged);
            // 
            // btnMsg5
            // 
            this.btnMsg5.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnMsg5.Image = null;
            this.btnMsg5.Location = new System.Drawing.Point(328, 62);
            this.btnMsg5.Name = "btnMsg5";
            this.btnMsg5.Size = new System.Drawing.Size(24, 20);
            this.btnMsg5.TabIndex = 12;
            this.btnMsg5.Text = "5";
            this.btnMsg5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMsg5.UseVisualStyleBackColor = true;
            this.btnMsg5.CheckedChanged += new System.EventHandler(this.btnMsg5_CheckedChanged);
            // 
            // btnMsg4
            // 
            this.btnMsg4.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnMsg4.Image = null;
            this.btnMsg4.Location = new System.Drawing.Point(328, 27);
            this.btnMsg4.Name = "btnMsg4";
            this.btnMsg4.Size = new System.Drawing.Size(24, 20);
            this.btnMsg4.TabIndex = 11;
            this.btnMsg4.Text = "4";
            this.btnMsg4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMsg4.UseVisualStyleBackColor = true;
            this.btnMsg4.CheckedChanged += new System.EventHandler(this.btnMsg4_CheckedChanged);
            // 
            // btnRecMsg1
            // 
            this.btnRecMsg1.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnRecMsg1.Image = null;
            this.btnRecMsg1.Location = new System.Drawing.Point(17, 26);
            this.btnRecMsg1.Name = "btnRecMsg1";
            this.btnRecMsg1.Size = new System.Drawing.Size(41, 20);
            this.btnRecMsg1.TabIndex = 17;
            this.btnRecMsg1.Text = "REC";
            this.btnRecMsg1.UseVisualStyleBackColor = true;
            this.btnRecMsg1.CheckedChanged += new System.EventHandler(this.btnRecMsg1_CheckedChanged);
            // 
            // btnRecMsg2
            // 
            this.btnRecMsg2.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnRecMsg2.Image = null;
            this.btnRecMsg2.Location = new System.Drawing.Point(17, 62);
            this.btnRecMsg2.Name = "btnRecMsg2";
            this.btnRecMsg2.Size = new System.Drawing.Size(41, 20);
            this.btnRecMsg2.TabIndex = 18;
            this.btnRecMsg2.Text = "REC";
            this.btnRecMsg2.UseVisualStyleBackColor = true;
            this.btnRecMsg2.CheckedChanged += new System.EventHandler(this.btnRecMsg2_CheckedChanged);
            // 
            // btnRecMsg3
            // 
            this.btnRecMsg3.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnRecMsg3.Image = null;
            this.btnRecMsg3.Location = new System.Drawing.Point(17, 101);
            this.btnRecMsg3.Name = "btnRecMsg3";
            this.btnRecMsg3.Size = new System.Drawing.Size(41, 20);
            this.btnRecMsg3.TabIndex = 19;
            this.btnRecMsg3.Text = "REC";
            this.btnRecMsg3.UseVisualStyleBackColor = true;
            this.btnRecMsg3.CheckedChanged += new System.EventHandler(this.btnRecMsg3_CheckedChanged);
            // 
            // btnRecMsg4
            // 
            this.btnRecMsg4.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnRecMsg4.Image = null;
            this.btnRecMsg4.Location = new System.Drawing.Point(281, 27);
            this.btnRecMsg4.Name = "btnRecMsg4";
            this.btnRecMsg4.Size = new System.Drawing.Size(41, 20);
            this.btnRecMsg4.TabIndex = 20;
            this.btnRecMsg4.Text = "REC";
            this.btnRecMsg4.UseVisualStyleBackColor = true;
            this.btnRecMsg4.CheckedChanged += new System.EventHandler(this.btnRecMsg4_CheckedChanged);
            // 
            // btnRecMsg5
            // 
            this.btnRecMsg5.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnRecMsg5.Image = null;
            this.btnRecMsg5.Location = new System.Drawing.Point(281, 62);
            this.btnRecMsg5.Name = "btnRecMsg5";
            this.btnRecMsg5.Size = new System.Drawing.Size(41, 20);
            this.btnRecMsg5.TabIndex = 21;
            this.btnRecMsg5.Text = "REC";
            this.btnRecMsg5.UseVisualStyleBackColor = true;
            this.btnRecMsg5.CheckedChanged += new System.EventHandler(this.btnRecMsg5_CheckedChanged);
            // 
            // btnRecMsg6
            // 
            this.btnRecMsg6.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnRecMsg6.Image = null;
            this.btnRecMsg6.Location = new System.Drawing.Point(281, 100);
            this.btnRecMsg6.Name = "btnRecMsg6";
            this.btnRecMsg6.Size = new System.Drawing.Size(41, 20);
            this.btnRecMsg6.TabIndex = 22;
            this.btnRecMsg6.Text = "REC";
            this.btnRecMsg6.UseVisualStyleBackColor = true;
            this.btnRecMsg6.CheckedChanged += new System.EventHandler(this.btnRecMsg6_CheckedChanged);
            // 
            // VoiceMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 190);
            this.Controls.Add(this.btnRecMsg6);
            this.Controls.Add(this.btnRecMsg5);
            this.Controls.Add(this.btnRecMsg4);
            this.Controls.Add(this.btnRecMsg3);
            this.Controls.Add(this.btnRecMsg2);
            this.Controls.Add(this.btnRecMsg1);
            this.Controls.Add(this.txtMsg6);
            this.Controls.Add(this.txtMsg5);
            this.Controls.Add(this.txtMsg4);
            this.Controls.Add(this.btnMsg6);
            this.Controls.Add(this.btnMsg5);
            this.Controls.Add(this.btnMsg4);
            this.Controls.Add(this.txtMsg3);
            this.Controls.Add(this.txtMsg2);
            this.Controls.Add(this.txtMsg1);
            this.Controls.Add(this.btnMsg3);
            this.Controls.Add(this.btnMsg2);
            this.Controls.Add(this.btnMsg1);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnOK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(573, 228);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(573, 228);
            this.Name = "VoiceMessages";
            this.Text = "VoiceMessages";
            this.Load += new System.EventHandler(this.VoiceMessages_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ButtonTS btnOK;
        private System.Windows.Forms.ButtonTS btnApply;
        private System.Windows.Forms.CheckBoxTS btnMsg1;
        private System.Windows.Forms.CheckBoxTS btnMsg2;
        private System.Windows.Forms.CheckBoxTS btnMsg3;
        public TextBoxTS txtMsg1;
        public TextBoxTS txtMsg2;
        public TextBoxTS txtMsg3;
        public TextBoxTS txtMsg6;
        public TextBoxTS txtMsg5;
        public TextBoxTS txtMsg4;
        private System.Windows.Forms.CheckBoxTS btnMsg6;
        private System.Windows.Forms.CheckBoxTS btnMsg5;
        private System.Windows.Forms.CheckBoxTS btnMsg4;
        private CheckBoxTS btnRecMsg1;
        private CheckBoxTS btnRecMsg2;
        private CheckBoxTS btnRecMsg3;
        private CheckBoxTS btnRecMsg4;
        private CheckBoxTS btnRecMsg5;
        private CheckBoxTS btnRecMsg6;
    }
}