﻿
namespace DirectInputExplorer
{
  partial class Form1
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.ComboBoxDevices = new System.Windows.Forms.ComboBox();
      this.ButtonEnumerateDevices = new System.Windows.Forms.Button();
      this.LabelDeviceInfo = new System.Windows.Forms.Label();
      this.TimerPoll = new System.Windows.Forms.Timer(this.components);
      this.ButtonAttatch = new System.Windows.Forms.Button();
      this.ButtonRemove = new System.Windows.Forms.Button();
      this.TabController = new System.Windows.Forms.TabControl();
      this.TabDeviceInfo = new System.Windows.Forms.TabPage();
      this.TabInput = new System.Windows.Forms.TabPage();
      this.LabelInput = new System.Windows.Forms.Label();
      this.TabFFB = new System.Windows.Forms.TabPage();
      this.TabCapabilities = new System.Windows.Forms.TabPage();
      this.ButtonCapabilities = new System.Windows.Forms.Button();
      this.LabelCapabilities = new System.Windows.Forms.Label();
      this.TabMisc = new System.Windows.Forms.TabPage();
      this.LabelDebug = new System.Windows.Forms.Label();
      this.ButtonDebug = new System.Windows.Forms.Button();
      this.TabController.SuspendLayout();
      this.TabDeviceInfo.SuspendLayout();
      this.TabInput.SuspendLayout();
      this.TabCapabilities.SuspendLayout();
      this.TabMisc.SuspendLayout();
      this.SuspendLayout();
      // 
      // ComboBoxDevices
      // 
      this.ComboBoxDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ComboBoxDevices.FormattingEnabled = true;
      this.ComboBoxDevices.Location = new System.Drawing.Point(12, 12);
      this.ComboBoxDevices.Name = "ComboBoxDevices";
      this.ComboBoxDevices.Size = new System.Drawing.Size(976, 33);
      this.ComboBoxDevices.TabIndex = 1;
      this.ComboBoxDevices.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDevices_SelectedIndexChanged);
      // 
      // ButtonEnumerateDevices
      // 
      this.ButtonEnumerateDevices.Location = new System.Drawing.Point(994, 12);
      this.ButtonEnumerateDevices.Name = "ButtonEnumerateDevices";
      this.ButtonEnumerateDevices.Size = new System.Drawing.Size(40, 33);
      this.ButtonEnumerateDevices.TabIndex = 2;
      this.ButtonEnumerateDevices.Text = "🔄";
      this.ButtonEnumerateDevices.UseVisualStyleBackColor = true;
      this.ButtonEnumerateDevices.Click += new System.EventHandler(this.ButtonEnumerateDevices_Click);
      // 
      // LabelDeviceInfo
      // 
      this.LabelDeviceInfo.AutoSize = true;
      this.LabelDeviceInfo.Location = new System.Drawing.Point(5, 5);
      this.LabelDeviceInfo.Name = "LabelDeviceInfo";
      this.LabelDeviceInfo.Size = new System.Drawing.Size(105, 25);
      this.LabelDeviceInfo.TabIndex = 3;
      this.LabelDeviceInfo.Text = "Device Info:";
      // 
      // ButtonAttatch
      // 
      this.ButtonAttatch.Location = new System.Drawing.Point(1040, 12);
      this.ButtonAttatch.Name = "ButtonAttatch";
      this.ButtonAttatch.Size = new System.Drawing.Size(100, 33);
      this.ButtonAttatch.TabIndex = 5;
      this.ButtonAttatch.Text = "Attatch";
      this.ButtonAttatch.UseVisualStyleBackColor = true;
      this.ButtonAttatch.Click += new System.EventHandler(this.ButtonAttatch_Click);
      // 
      // ButtonRemove
      // 
      this.ButtonRemove.Location = new System.Drawing.Point(1146, 12);
      this.ButtonRemove.Name = "ButtonRemove";
      this.ButtonRemove.Size = new System.Drawing.Size(100, 33);
      this.ButtonRemove.TabIndex = 6;
      this.ButtonRemove.Text = "Remove";
      this.ButtonRemove.UseVisualStyleBackColor = true;
      this.ButtonRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
      // 
      // TabController
      // 
      this.TabController.Controls.Add(this.TabDeviceInfo);
      this.TabController.Controls.Add(this.TabInput);
      this.TabController.Controls.Add(this.TabFFB);
      this.TabController.Controls.Add(this.TabCapabilities);
      this.TabController.Controls.Add(this.TabMisc);
      this.TabController.Location = new System.Drawing.Point(12, 51);
      this.TabController.Name = "TabController";
      this.TabController.SelectedIndex = 0;
      this.TabController.Size = new System.Drawing.Size(1234, 841);
      this.TabController.TabIndex = 7;
      // 
      // TabDeviceInfo
      // 
      this.TabDeviceInfo.Controls.Add(this.LabelDeviceInfo);
      this.TabDeviceInfo.Location = new System.Drawing.Point(4, 34);
      this.TabDeviceInfo.Name = "TabDeviceInfo";
      this.TabDeviceInfo.Size = new System.Drawing.Size(1226, 803);
      this.TabDeviceInfo.TabIndex = 3;
      this.TabDeviceInfo.Text = "Info";
      this.TabDeviceInfo.UseVisualStyleBackColor = true;
      // 
      // TabInput
      // 
      this.TabInput.Controls.Add(this.LabelInput);
      this.TabInput.Location = new System.Drawing.Point(4, 34);
      this.TabInput.Name = "TabInput";
      this.TabInput.Padding = new System.Windows.Forms.Padding(3);
      this.TabInput.Size = new System.Drawing.Size(1226, 803);
      this.TabInput.TabIndex = 0;
      this.TabInput.Text = "Input";
      this.TabInput.UseVisualStyleBackColor = true;
      // 
      // LabelInput
      // 
      this.LabelInput.AutoSize = true;
      this.LabelInput.Location = new System.Drawing.Point(5, 5);
      this.LabelInput.Name = "LabelInput";
      this.LabelInput.Size = new System.Drawing.Size(152, 25);
      this.LabelInput.TabIndex = 4;
      this.LabelInput.Text = "Input: Attach First";
      // 
      // TabFFB
      // 
      this.TabFFB.Location = new System.Drawing.Point(4, 34);
      this.TabFFB.Name = "TabFFB";
      this.TabFFB.Padding = new System.Windows.Forms.Padding(3);
      this.TabFFB.Size = new System.Drawing.Size(1226, 803);
      this.TabFFB.TabIndex = 1;
      this.TabFFB.Text = "FFB";
      this.TabFFB.UseVisualStyleBackColor = true;
      // 
      // TabCapabilities
      // 
      this.TabCapabilities.Controls.Add(this.ButtonCapabilities);
      this.TabCapabilities.Controls.Add(this.LabelCapabilities);
      this.TabCapabilities.Location = new System.Drawing.Point(4, 34);
      this.TabCapabilities.Name = "TabCapabilities";
      this.TabCapabilities.Size = new System.Drawing.Size(1226, 803);
      this.TabCapabilities.TabIndex = 2;
      this.TabCapabilities.Text = "Capabilities";
      this.TabCapabilities.UseVisualStyleBackColor = true;
      // 
      // ButtonCapabilities
      // 
      this.ButtonCapabilities.Location = new System.Drawing.Point(1109, 5);
      this.ButtonCapabilities.Name = "ButtonCapabilities";
      this.ButtonCapabilities.Size = new System.Drawing.Size(114, 41);
      this.ButtonCapabilities.TabIndex = 5;
      this.ButtonCapabilities.Text = "Capabilities";
      this.ButtonCapabilities.UseVisualStyleBackColor = true;
      this.ButtonCapabilities.Click += new System.EventHandler(this.ButtonCapabilities_Click);
      // 
      // LabelCapabilities
      // 
      this.LabelCapabilities.AutoSize = true;
      this.LabelCapabilities.Location = new System.Drawing.Point(5, 5);
      this.LabelCapabilities.Name = "LabelCapabilities";
      this.LabelCapabilities.Size = new System.Drawing.Size(206, 25);
      this.LabelCapabilities.TabIndex = 4;
      this.LabelCapabilities.Text = "Capabilities: Attatch First";
      // 
      // TabMisc
      // 
      this.TabMisc.Controls.Add(this.LabelDebug);
      this.TabMisc.Controls.Add(this.ButtonDebug);
      this.TabMisc.Location = new System.Drawing.Point(4, 34);
      this.TabMisc.Name = "TabMisc";
      this.TabMisc.Padding = new System.Windows.Forms.Padding(3);
      this.TabMisc.Size = new System.Drawing.Size(1226, 803);
      this.TabMisc.TabIndex = 4;
      this.TabMisc.Text = "Misc";
      this.TabMisc.UseVisualStyleBackColor = true;
      // 
      // LabelDebug
      // 
      this.LabelDebug.AutoSize = true;
      this.LabelDebug.Location = new System.Drawing.Point(6, 3);
      this.LabelDebug.Name = "LabelDebug";
      this.LabelDebug.Size = new System.Drawing.Size(112, 25);
      this.LabelDebug.TabIndex = 1;
      this.LabelDebug.Text = "Debug Stuff:";
      // 
      // ButtonDebug
      // 
      this.ButtonDebug.Location = new System.Drawing.Point(1077, 6);
      this.ButtonDebug.Name = "ButtonDebug";
      this.ButtonDebug.Size = new System.Drawing.Size(143, 55);
      this.ButtonDebug.TabIndex = 0;
      this.ButtonDebug.Text = "Debug";
      this.ButtonDebug.UseVisualStyleBackColor = true;
      this.ButtonDebug.Click += new System.EventHandler(this.ButtonDebug_Click);
      // 
      // Form1
      // 
      this.ClientSize = new System.Drawing.Size(1258, 904);
      this.Controls.Add(this.TabController);
      this.Controls.Add(this.ButtonRemove);
      this.Controls.Add(this.ButtonAttatch);
      this.Controls.Add(this.ButtonEnumerateDevices);
      this.Controls.Add(this.ComboBoxDevices);
      this.Name = "Form1";
      this.Text = "Direct Input Explorer";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.TabController.ResumeLayout(false);
      this.TabDeviceInfo.ResumeLayout(false);
      this.TabDeviceInfo.PerformLayout();
      this.TabInput.ResumeLayout(false);
      this.TabInput.PerformLayout();
      this.TabCapabilities.ResumeLayout(false);
      this.TabCapabilities.PerformLayout();
      this.TabMisc.ResumeLayout(false);
      this.TabMisc.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.ComboBox ComboBoxDevices;
    private System.Windows.Forms.Button ButtonEnumerateDevices;
    private System.Windows.Forms.Label LabelDeviceInfo;
    private System.Windows.Forms.Timer TimerPoll;
    private System.Windows.Forms.Button ButtonAttatch;
    private System.Windows.Forms.Button ButtonRemove;
    private System.Windows.Forms.TabControl TabController;
    private System.Windows.Forms.TabPage TabDeviceInfo;
    private System.Windows.Forms.TabPage TabInput;
    private System.Windows.Forms.TabPage TabFFB;
    private System.Windows.Forms.TabPage TabCapabilities;
    private System.Windows.Forms.Label LabelCapabilities;
    private System.Windows.Forms.Label LabelInput;
    private System.Windows.Forms.Button ButtonCapabilities;
    private System.Windows.Forms.TabPage TabMisc;
    private System.Windows.Forms.Label LabelDebug;
    private System.Windows.Forms.Button ButtonDebug;
  }
}

