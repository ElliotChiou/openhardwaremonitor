﻿/*
  
  Version: MPL 1.1/GPL 2.0/LGPL 2.1

  The contents of this file are subject to the Mozilla Public License Version
  1.1 (the "License"); you may not use this file except in compliance with
  the License. You may obtain a copy of the License at
 
  http://www.mozilla.org/MPL/

  Software distributed under the License is distributed on an "AS IS" basis,
  WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
  for the specific language governing rights and limitations under the License.

  The Original Code is the Open Hardware Monitor code.

  The Initial Developer of the Original Code is 
  Michael Möller <m.moeller@gmx.ch>.
  Portions created by the Initial Developer are Copyright (C) 2009-2010
  the Initial Developer. All Rights Reserved.

  Contributor(s):

  Alternatively, the contents of this file may be used under the terms of
  either the GNU General Public License Version 2 or later (the "GPL"), or
  the GNU Lesser General Public License Version 2.1 or later (the "LGPL"),
  in which case the provisions of the GPL or the LGPL are applicable instead
  of those above. If you wish to allow use of your version of this file only
  under the terms of either the GPL or the LGPL, and not to allow others to
  use your version of this file under the terms of the MPL, indicate your
  decision by deleting the provisions above and replace them with the notice
  and other provisions required by the GPL or the LGPL. If you do not delete
  the provisions above, a recipient may use your version of this file under
  the terms of any one of the MPL, the GPL or the LGPL.
 
*/

namespace OpenHardwareMonitor.GUI {
  partial class CrashReportForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.sendButton = new System.Windows.Forms.Button();
      this.exitButton = new System.Windows.Forms.Button();
      this.commentTextBox = new System.Windows.Forms.TextBox();
      this.titleLabel = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.commentPanel = new System.Windows.Forms.Panel();
      this.reportPanel = new System.Windows.Forms.Panel();
      this.reportTextBox = new System.Windows.Forms.TextBox();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.commentPanel.SuspendLayout();
      this.reportPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // sendButton
      // 
      this.sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.sendButton.Location = new System.Drawing.Point(467, 412);
      this.sendButton.Name = "sendButton";
      this.sendButton.Size = new System.Drawing.Size(75, 23);
      this.sendButton.TabIndex = 1;
      this.sendButton.Text = "Send";
      this.sendButton.UseVisualStyleBackColor = true;
      this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
      // 
      // exitButton
      // 
      this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.exitButton.Location = new System.Drawing.Point(548, 412);
      this.exitButton.Name = "exitButton";
      this.exitButton.Size = new System.Drawing.Size(75, 23);
      this.exitButton.TabIndex = 2;
      this.exitButton.Text = "Exit";
      this.exitButton.UseVisualStyleBackColor = true;
      // 
      // commentTextBox
      // 
      this.commentTextBox.AcceptsReturn = true;
      this.commentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.commentTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.commentTextBox.Location = new System.Drawing.Point(4, 4);
      this.commentTextBox.Multiline = true;
      this.commentTextBox.Name = "commentTextBox";
      this.commentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.commentTextBox.Size = new System.Drawing.Size(604, 77);
      this.commentTextBox.TabIndex = 0;
      // 
      // titleLabel
      // 
      this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.titleLabel.BackColor = System.Drawing.SystemColors.Window;
      this.titleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.titleLabel.Location = new System.Drawing.Point(-1, -1);
      this.titleLabel.Name = "titleLabel";
      this.titleLabel.Padding = new System.Windows.Forms.Padding(10);
      this.titleLabel.Size = new System.Drawing.Size(637, 52);
      this.titleLabel.TabIndex = 4;
      this.titleLabel.Text = "Open Hardware Monitor has encountered a problem and needs to close. We are sorry " +
          "for the inconvenience.";
      // 
      // label3
      // 
      this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.label3.AutoEllipsis = true;
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(9, 63);
      this.label3.Margin = new System.Windows.Forms.Padding(3, 12, 3, 8);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(571, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "To help diagnose and fix the problem, you can send a crash report. The following " +
          "report has been created automatically.";
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.label1.AutoEllipsis = true;
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(9, 290);
      this.label1.Margin = new System.Windows.Forms.Padding(3, 12, 3, 8);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(233, 13);
      this.label1.TabIndex = 6;
      this.label1.Text = "You can add additional information to the report.";
      // 
      // commentPanel
      // 
      this.commentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.commentPanel.BackColor = System.Drawing.SystemColors.Window;
      this.commentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.commentPanel.Controls.Add(this.commentTextBox);
      this.commentPanel.Location = new System.Drawing.Point(12, 314);
      this.commentPanel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
      this.commentPanel.Name = "commentPanel";
      this.commentPanel.Padding = new System.Windows.Forms.Padding(4, 4, 1, 4);
      this.commentPanel.Size = new System.Drawing.Size(611, 87);
      this.commentPanel.TabIndex = 7;
      // 
      // reportPanel
      // 
      this.reportPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.reportPanel.BackColor = System.Drawing.SystemColors.Window;
      this.reportPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.reportPanel.Controls.Add(this.reportTextBox);
      this.reportPanel.Controls.Add(this.textBox1);
      this.reportPanel.Location = new System.Drawing.Point(12, 87);
      this.reportPanel.Name = "reportPanel";
      this.reportPanel.Padding = new System.Windows.Forms.Padding(4, 4, 1, 4);
      this.reportPanel.Size = new System.Drawing.Size(611, 188);
      this.reportPanel.TabIndex = 8;
      // 
      // reportTextBox
      // 
      this.reportTextBox.BackColor = System.Drawing.SystemColors.Window;
      this.reportTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.reportTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.reportTextBox.Location = new System.Drawing.Point(4, 4);
      this.reportTextBox.Multiline = true;
      this.reportTextBox.Name = "reportTextBox";
      this.reportTextBox.ReadOnly = true;
      this.reportTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.reportTextBox.Size = new System.Drawing.Size(604, 178);
      this.reportTextBox.TabIndex = 9;
      this.reportTextBox.TabStop = false;
      // 
      // textBox1
      // 
      this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.textBox1.Location = new System.Drawing.Point(4, 4);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(604, 178);
      this.textBox1.TabIndex = 2;
      // 
      // CrashReportForm
      // 
      this.AcceptButton = this.sendButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.exitButton;
      this.ClientSize = new System.Drawing.Size(635, 447);
      this.ControlBox = false;
      this.Controls.Add(this.reportPanel);
      this.Controls.Add(this.commentPanel);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.titleLabel);
      this.Controls.Add(this.exitButton);
      this.Controls.Add(this.sendButton);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "CrashReportForm";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Open Hardware Monitor";
      this.commentPanel.ResumeLayout(false);
      this.commentPanel.PerformLayout();
      this.reportPanel.ResumeLayout(false);
      this.reportPanel.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button sendButton;
    private System.Windows.Forms.Button exitButton;
    private System.Windows.Forms.TextBox commentTextBox;
    private System.Windows.Forms.Label titleLabel;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel commentPanel;
    private System.Windows.Forms.Panel reportPanel;
    private System.Windows.Forms.TextBox reportTextBox;
    private System.Windows.Forms.TextBox textBox1;
  }
}