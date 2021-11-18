
namespace UClient.UIDesign
{
    partial class ClientUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientUI));
            this.LStatus = new System.Windows.Forms.Label();
            this.GbxCallManager = new System.Windows.Forms.GroupBox();
            this.BtnParticipants = new System.Windows.Forms.Button();
            this.BtnVolToggle = new System.Windows.Forms.Button();
            this.BtnJoinGroup = new System.Windows.Forms.Button();
            this.PbMicLevel = new System.Windows.Forms.ProgressBar();
            this.LInform = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LDuration = new System.Windows.Forms.Label();
            this.LReceived = new System.Windows.Forms.Label();
            this.LSent = new System.Windows.Forms.Label();
            this.VolControl = new System.Windows.Forms.TrackBar();
            this.BtnEndCall = new System.Windows.Forms.Button();
            this.BtnToggleState = new System.Windows.Forms.Button();
            this.GbxCallControls = new System.Windows.Forms.GroupBox();
            this.LConStatus = new System.Windows.Forms.Label();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.BtnGO = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TbAccess = new System.Windows.Forms.TextBox();
            this.LLatency = new System.Windows.Forms.Label();
            this.GbxCallManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolControl)).BeginInit();
            this.GbxCallControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // LStatus
            // 
            this.LStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LStatus.Font = new System.Drawing.Font("Sanskrit Text", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LStatus.ForeColor = System.Drawing.Color.Yellow;
            this.LStatus.Location = new System.Drawing.Point(12, 344);
            this.LStatus.Name = "LStatus";
            this.LStatus.Size = new System.Drawing.Size(415, 25);
            this.LStatus.TabIndex = 5;
            this.LStatus.Text = "Status : Unknown";
            this.LStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GbxCallManager
            // 
            this.GbxCallManager.Controls.Add(this.LLatency);
            this.GbxCallManager.Controls.Add(this.BtnParticipants);
            this.GbxCallManager.Controls.Add(this.BtnVolToggle);
            this.GbxCallManager.Controls.Add(this.BtnJoinGroup);
            this.GbxCallManager.Controls.Add(this.PbMicLevel);
            this.GbxCallManager.Controls.Add(this.LInform);
            this.GbxCallManager.Controls.Add(this.label6);
            this.GbxCallManager.Controls.Add(this.LDuration);
            this.GbxCallManager.Controls.Add(this.LReceived);
            this.GbxCallManager.Controls.Add(this.LSent);
            this.GbxCallManager.Controls.Add(this.VolControl);
            this.GbxCallManager.Controls.Add(this.BtnEndCall);
            this.GbxCallManager.Controls.Add(this.BtnToggleState);
            this.GbxCallManager.Font = new System.Drawing.Font("Microsoft Himalaya", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxCallManager.ForeColor = System.Drawing.Color.MistyRose;
            this.GbxCallManager.Location = new System.Drawing.Point(12, 85);
            this.GbxCallManager.Name = "GbxCallManager";
            this.GbxCallManager.Size = new System.Drawing.Size(415, 256);
            this.GbxCallManager.TabIndex = 4;
            this.GbxCallManager.TabStop = false;
            this.GbxCallManager.Text = "Call Progress Handler";
            this.GbxCallManager.Visible = false;
            // 
            // BtnParticipants
            // 
            this.BtnParticipants.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(20)))), ((int)(((byte)(24)))));
            this.BtnParticipants.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnParticipants.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnParticipants.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnParticipants.Location = new System.Drawing.Point(8, 151);
            this.BtnParticipants.Name = "BtnParticipants";
            this.BtnParticipants.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnParticipants.Size = new System.Drawing.Size(204, 25);
            this.BtnParticipants.TabIndex = 15;
            this.BtnParticipants.Text = "Participants | 1";
            this.BtnParticipants.UseCompatibleTextRendering = true;
            this.BtnParticipants.UseVisualStyleBackColor = false;
            this.BtnParticipants.Click += new System.EventHandler(this.BtnParticipants_Click);
            // 
            // BtnVolToggle
            // 
            this.BtnVolToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(20)))), ((int)(((byte)(24)))));
            this.BtnVolToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVolToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolToggle.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolToggle.Location = new System.Drawing.Point(339, 91);
            this.BtnVolToggle.Name = "BtnVolToggle";
            this.BtnVolToggle.Size = new System.Drawing.Size(56, 42);
            this.BtnVolToggle.TabIndex = 14;
            this.BtnVolToggle.Text = "1.0";
            this.BtnVolToggle.UseVisualStyleBackColor = false;
            this.BtnVolToggle.Click += new System.EventHandler(this.BtnVolToggle_Click);
            // 
            // BtnJoinGroup
            // 
            this.BtnJoinGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(20)))), ((int)(((byte)(24)))));
            this.BtnJoinGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnJoinGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnJoinGroup.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnJoinGroup.ForeColor = System.Drawing.Color.White;
            this.BtnJoinGroup.Location = new System.Drawing.Point(139, 20);
            this.BtnJoinGroup.Name = "BtnJoinGroup";
            this.BtnJoinGroup.Size = new System.Drawing.Size(129, 31);
            this.BtnJoinGroup.TabIndex = 13;
            this.BtnJoinGroup.Text = "Re-Join Group";
            this.BtnJoinGroup.UseVisualStyleBackColor = false;
            this.BtnJoinGroup.Visible = false;
            this.BtnJoinGroup.Click += new System.EventHandler(this.BtnJoinGroup_Click);
            // 
            // PbMicLevel
            // 
            this.PbMicLevel.Location = new System.Drawing.Point(10, 243);
            this.PbMicLevel.Name = "PbMicLevel";
            this.PbMicLevel.Size = new System.Drawing.Size(396, 5);
            this.PbMicLevel.TabIndex = 12;
            // 
            // LInform
            // 
            this.LInform.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LInform.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LInform.Location = new System.Drawing.Point(10, 56);
            this.LInform.Name = "LInform";
            this.LInform.Size = new System.Drawing.Size(396, 16);
            this.LInform.TabIndex = 11;
            this.LInform.Text = "You Are In A Group Call";
            this.LInform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(20, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 45);
            this.label6.TabIndex = 9;
            this.label6.Text = "Speaker\r\nVolume";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LDuration
            // 
            this.LDuration.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDuration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.LDuration.Location = new System.Drawing.Point(219, 184);
            this.LDuration.Name = "LDuration";
            this.LDuration.Size = new System.Drawing.Size(187, 25);
            this.LDuration.TabIndex = 8;
            this.LDuration.Text = "Duration | 00:00";
            this.LDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LReceived
            // 
            this.LReceived.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LReceived.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LReceived.Location = new System.Drawing.Point(9, 184);
            this.LReceived.Name = "LReceived";
            this.LReceived.Size = new System.Drawing.Size(202, 25);
            this.LReceived.TabIndex = 7;
            this.LReceived.Text = "Received | 0 KB";
            this.LReceived.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LSent
            // 
            this.LSent.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LSent.Location = new System.Drawing.Point(219, 151);
            this.LSent.Name = "LSent";
            this.LSent.Size = new System.Drawing.Size(187, 25);
            this.LSent.TabIndex = 6;
            this.LSent.Text = "Sent | 0 KB";
            this.LSent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VolControl
            // 
            this.VolControl.LargeChange = 2;
            this.VolControl.Location = new System.Drawing.Point(117, 90);
            this.VolControl.Name = "VolControl";
            this.VolControl.Size = new System.Drawing.Size(208, 45);
            this.VolControl.TabIndex = 4;
            this.VolControl.Value = 10;
            this.VolControl.Scroll += new System.EventHandler(this.VolControl_Scroll);
            // 
            // BtnEndCall
            // 
            this.BtnEndCall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(20)))), ((int)(((byte)(24)))));
            this.BtnEndCall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEndCall.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEndCall.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEndCall.ForeColor = System.Drawing.Color.HotPink;
            this.BtnEndCall.Location = new System.Drawing.Point(274, 20);
            this.BtnEndCall.Name = "BtnEndCall";
            this.BtnEndCall.Size = new System.Drawing.Size(132, 31);
            this.BtnEndCall.TabIndex = 2;
            this.BtnEndCall.Text = "End Call : ESC";
            this.BtnEndCall.UseVisualStyleBackColor = false;
            this.BtnEndCall.Click += new System.EventHandler(this.BtnEndCall_Click);
            // 
            // BtnToggleState
            // 
            this.BtnToggleState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(20)))), ((int)(((byte)(24)))));
            this.BtnToggleState.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnToggleState.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnToggleState.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnToggleState.ForeColor = System.Drawing.Color.DarkKhaki;
            this.BtnToggleState.Location = new System.Drawing.Point(10, 20);
            this.BtnToggleState.Name = "BtnToggleState";
            this.BtnToggleState.Size = new System.Drawing.Size(123, 31);
            this.BtnToggleState.TabIndex = 1;
            this.BtnToggleState.Text = "UnMute : F10";
            this.BtnToggleState.UseVisualStyleBackColor = false;
            this.BtnToggleState.Click += new System.EventHandler(this.BtnToggleState_Click);
            // 
            // GbxCallControls
            // 
            this.GbxCallControls.Controls.Add(this.LConStatus);
            this.GbxCallControls.Controls.Add(this.BtnSettings);
            this.GbxCallControls.Controls.Add(this.BtnGO);
            this.GbxCallControls.Controls.Add(this.label3);
            this.GbxCallControls.Controls.Add(this.TbAccess);
            this.GbxCallControls.Font = new System.Drawing.Font("Microsoft Himalaya", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxCallControls.ForeColor = System.Drawing.Color.MistyRose;
            this.GbxCallControls.Location = new System.Drawing.Point(12, 11);
            this.GbxCallControls.Name = "GbxCallControls";
            this.GbxCallControls.Size = new System.Drawing.Size(415, 68);
            this.GbxCallControls.TabIndex = 3;
            this.GbxCallControls.TabStop = false;
            this.GbxCallControls.Text = "Call Controls";
            // 
            // LConStatus
            // 
            this.LConStatus.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LConStatus.ForeColor = System.Drawing.Color.Gold;
            this.LConStatus.Location = new System.Drawing.Point(6, 14);
            this.LConStatus.Name = "LConStatus";
            this.LConStatus.Size = new System.Drawing.Size(403, 48);
            this.LConStatus.TabIndex = 9;
            this.LConStatus.Text = "Connecting.....";
            this.LConStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LConStatus.Visible = false;
            // 
            // BtnSettings
            // 
            this.BtnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(20)))), ((int)(((byte)(24)))));
            this.BtnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSettings.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSettings.Location = new System.Drawing.Point(172, 23);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(113, 39);
            this.BtnSettings.TabIndex = 17;
            this.BtnSettings.Text = "Settings : F2";
            this.BtnSettings.UseVisualStyleBackColor = false;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // BtnGO
            // 
            this.BtnGO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(20)))), ((int)(((byte)(24)))));
            this.BtnGO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGO.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGO.Location = new System.Drawing.Point(311, 23);
            this.BtnGO.Name = "BtnGO";
            this.BtnGO.Size = new System.Drawing.Size(84, 39);
            this.BtnGO.TabIndex = 16;
            this.BtnGO.Text = "GO : F5";
            this.BtnGO.UseVisualStyleBackColor = false;
            this.BtnGO.Click += new System.EventHandler(this.BtnGO_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 11);
            this.label3.TabIndex = 15;
            this.label3.Text = "Code";
            // 
            // TbAccess
            // 
            this.TbAccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.TbAccess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbAccess.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbAccess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.TbAccess.Location = new System.Drawing.Point(19, 37);
            this.TbAccess.Name = "TbAccess";
            this.TbAccess.Size = new System.Drawing.Size(127, 25);
            this.TbAccess.TabIndex = 14;
            this.TbAccess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LLatency
            // 
            this.LLatency.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LLatency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(120)))), ((int)(((byte)(250)))));
            this.LLatency.Location = new System.Drawing.Point(11, 220);
            this.LLatency.Name = "LLatency";
            this.LLatency.Size = new System.Drawing.Size(393, 19);
            this.LLatency.TabIndex = 16;
            this.LLatency.Text = "Latency | 150 ms";
            this.LLatency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClientUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(20)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(439, 381);
            this.Controls.Add(this.LStatus);
            this.Controls.Add(this.GbxCallManager);
            this.Controls.Add(this.GbxCallControls);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ClientUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ULiteCall : The Ultra Lite VoIP Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientUI_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ClientUI_KeyDown);
            this.GbxCallManager.ResumeLayout(false);
            this.GbxCallManager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolControl)).EndInit();
            this.GbxCallControls.ResumeLayout(false);
            this.GbxCallControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LStatus;
        private System.Windows.Forms.GroupBox GbxCallManager;
        private System.Windows.Forms.Button BtnJoinGroup;
        private System.Windows.Forms.ProgressBar PbMicLevel;
        private System.Windows.Forms.Label LInform;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LDuration;
        private System.Windows.Forms.Label LReceived;
        private System.Windows.Forms.Label LSent;
        private System.Windows.Forms.TrackBar VolControl;
        private System.Windows.Forms.Button BtnEndCall;
        private System.Windows.Forms.Button BtnToggleState;
        private System.Windows.Forms.GroupBox GbxCallControls;
        private System.Windows.Forms.Label LConStatus;
        private System.Windows.Forms.Button BtnSettings;
        private System.Windows.Forms.Button BtnGO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbAccess;
        private System.Windows.Forms.Button BtnVolToggle;
        private System.Windows.Forms.Button BtnParticipants;
        private System.Windows.Forms.Label LLatency;
    }
}

