
namespace UClient.UIDesign
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.LName = new System.Windows.Forms.Label();
            this.TBName = new System.Windows.Forms.TextBox();
            this.LOptimize = new System.Windows.Forms.Label();
            this.RBtnPerformance = new System.Windows.Forms.RadioButton();
            this.RBtnLow = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.LBMicrophone = new System.Windows.Forms.ListBox();
            this.CBJoinState = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Font = new System.Drawing.Font("Courier New", 11.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(160)))), ((int)(((byte)(180)))));
            this.LName.Location = new System.Drawing.Point(12, 19);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(118, 18);
            this.LName.TabIndex = 0;
            this.LName.Text = "Your Name :";
            // 
            // TBName
            // 
            this.TBName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(200)))), ((int)(((byte)(180)))));
            this.TBName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
            this.TBName.Location = new System.Drawing.Point(146, 13);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(206, 29);
            this.TBName.TabIndex = 1;
            this.TBName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LOptimize
            // 
            this.LOptimize.AutoSize = true;
            this.LOptimize.Font = new System.Drawing.Font("Courier New", 11.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOptimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(160)))), ((int)(((byte)(180)))));
            this.LOptimize.Location = new System.Drawing.Point(12, 114);
            this.LOptimize.Name = "LOptimize";
            this.LOptimize.Size = new System.Drawing.Size(268, 18);
            this.LOptimize.TabIndex = 2;
            this.LOptimize.Text = "Optimize Application For :";
            // 
            // RBtnPerformance
            // 
            this.RBtnPerformance.AutoSize = true;
            this.RBtnPerformance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RBtnPerformance.FlatAppearance.BorderSize = 2;
            this.RBtnPerformance.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtnPerformance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(250)))), ((int)(((byte)(180)))));
            this.RBtnPerformance.Location = new System.Drawing.Point(15, 135);
            this.RBtnPerformance.Name = "RBtnPerformance";
            this.RBtnPerformance.Size = new System.Drawing.Size(146, 23);
            this.RBtnPerformance.TabIndex = 3;
            this.RBtnPerformance.Text = "Better Performance";
            this.RBtnPerformance.UseVisualStyleBackColor = true;
            // 
            // RBtnLow
            // 
            this.RBtnLow.AutoSize = true;
            this.RBtnLow.Checked = true;
            this.RBtnLow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RBtnLow.FlatAppearance.BorderSize = 2;
            this.RBtnLow.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtnLow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(250)))), ((int)(((byte)(180)))));
            this.RBtnLow.Location = new System.Drawing.Point(208, 135);
            this.RBtnLow.Name = "RBtnLow";
            this.RBtnLow.Size = new System.Drawing.Size(131, 23);
            this.RBtnLow.TabIndex = 4;
            this.RBtnLow.TabStop = true;
            this.RBtnLow.Text = "Low Bandwidth";
            this.RBtnLow.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 11.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(160)))), ((int)(((byte)(180)))));
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select Mic :";
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(0)))));
            this.BtnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnReset.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.ForeColor = System.Drawing.Color.Khaki;
            this.BtnReset.Location = new System.Drawing.Point(160, 224);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(170, 38);
            this.BtnReset.TabIndex = 12;
            this.BtnReset.Text = "Reset Defaults";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(0)))));
            this.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSave.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.Khaki;
            this.BtnSave.Location = new System.Drawing.Point(34, 224);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(104, 38);
            this.BtnSave.TabIndex = 11;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // LBMicrophone
            // 
            this.LBMicrophone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(200)))), ((int)(((byte)(180)))));
            this.LBMicrophone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBMicrophone.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBMicrophone.FormattingEnabled = true;
            this.LBMicrophone.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.LBMicrophone.ItemHeight = 18;
            this.LBMicrophone.Items.AddRange(new object[] {
            "No Mic"});
            this.LBMicrophone.Location = new System.Drawing.Point(146, 67);
            this.LBMicrophone.Name = "LBMicrophone";
            this.LBMicrophone.Size = new System.Drawing.Size(206, 20);
            this.LBMicrophone.TabIndex = 13;
            // 
            // CBJoinState
            // 
            this.CBJoinState.AutoSize = true;
            this.CBJoinState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.CBJoinState.Checked = true;
            this.CBJoinState.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBJoinState.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBJoinState.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBJoinState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(200)))), ((int)(((byte)(180)))));
            this.CBJoinState.Location = new System.Drawing.Point(68, 176);
            this.CBJoinState.Name = "CBJoinState";
            this.CBJoinState.Size = new System.Drawing.Size(228, 24);
            this.CBJoinState.TabIndex = 14;
            this.CBJoinState.Text = "Mute When Joining Group Calls";
            this.CBJoinState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CBJoinState.UseCompatibleTextRendering = true;
            this.CBJoinState.UseVisualStyleBackColor = false;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(364, 275);
            this.Controls.Add(this.CBJoinState);
            this.Controls.Add(this.LBMicrophone);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RBtnLow);
            this.Controls.Add(this.RBtnPerformance);
            this.Controls.Add(this.LOptimize);
            this.Controls.Add(this.TBName);
            this.Controls.Add(this.LName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.Opacity = 0.98D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ULiteCall : Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.Label LOptimize;
        private System.Windows.Forms.RadioButton RBtnPerformance;
        private System.Windows.Forms.RadioButton RBtnLow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.ListBox LBMicrophone;
        private System.Windows.Forms.CheckBox CBJoinState;
    }
}