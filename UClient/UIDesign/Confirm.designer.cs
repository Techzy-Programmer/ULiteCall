
namespace UClient.UIDesign
{
    partial class Confirm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Confirm));
            this.LIncomingUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LAutoDecline = new System.Windows.Forms.Label();
            this.BtnAccept = new System.Windows.Forms.Button();
            this.BtnDecline = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LIncomingUser
            // 
            this.LIncomingUser.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LIncomingUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LIncomingUser.Location = new System.Drawing.Point(13, 16);
            this.LIncomingUser.Name = "LIncomingUser";
            this.LIncomingUser.Size = new System.Drawing.Size(281, 23);
            this.LIncomingUser.TabIndex = 0;
            this.LIncomingUser.Text = "User Name Here";
            this.LIncomingUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightPink;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wants to talk to you in Private";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LAutoDecline
            // 
            this.LAutoDecline.Font = new System.Drawing.Font("Microsoft Yi Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAutoDecline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LAutoDecline.Location = new System.Drawing.Point(13, 119);
            this.LAutoDecline.Name = "LAutoDecline";
            this.LAutoDecline.Size = new System.Drawing.Size(281, 23);
            this.LAutoDecline.TabIndex = 2;
            this.LAutoDecline.Text = "Auto Declining The Request In : 30 Sec";
            this.LAutoDecline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnAccept
            // 
            this.BtnAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.BtnAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAccept.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAccept.ForeColor = System.Drawing.Color.GreenYellow;
            this.BtnAccept.Location = new System.Drawing.Point(16, 74);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Size = new System.Drawing.Size(104, 38);
            this.BtnAccept.TabIndex = 3;
            this.BtnAccept.Text = "ACCEPT";
            this.BtnAccept.UseVisualStyleBackColor = false;
            this.BtnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // BtnDecline
            // 
            this.BtnDecline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(0)))), ((int)(((byte)(33)))));
            this.BtnDecline.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDecline.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDecline.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDecline.ForeColor = System.Drawing.Color.Orange;
            this.BtnDecline.Location = new System.Drawing.Point(186, 74);
            this.BtnDecline.Name = "BtnDecline";
            this.BtnDecline.Size = new System.Drawing.Size(104, 38);
            this.BtnDecline.TabIndex = 4;
            this.BtnDecline.Text = "DECLINE";
            this.BtnDecline.UseVisualStyleBackColor = false;
            this.BtnDecline.Click += new System.EventHandler(this.BtnDecline_Click);
            // 
            // Confirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(307, 161);
            this.Controls.Add(this.BtnDecline);
            this.Controls.Add(this.BtnAccept);
            this.Controls.Add(this.LAutoDecline);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LIncomingUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Confirm";
            this.Opacity = 0.98D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ULiteCall : Private Call Request";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LIncomingUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LAutoDecline;
        private System.Windows.Forms.Button BtnAccept;
        private System.Windows.Forms.Button BtnDecline;
    }
}