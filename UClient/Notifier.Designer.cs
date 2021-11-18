
namespace UClient
{
    partial class Notifier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notifier));
            this.PlBtnHolder = new System.Windows.Forms.Panel();
            this.BtnOk = new System.Windows.Forms.Button();
            this.BtnYes = new System.Windows.Forms.Button();
            this.BtnNo = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LMessage = new System.Windows.Forms.Label();
            this.PlBtnHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlBtnHolder
            // 
            this.PlBtnHolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PlBtnHolder.Controls.Add(this.BtnOk);
            this.PlBtnHolder.Controls.Add(this.BtnYes);
            this.PlBtnHolder.Controls.Add(this.BtnNo);
            this.PlBtnHolder.Controls.Add(this.BtnCancel);
            this.PlBtnHolder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PlBtnHolder.Location = new System.Drawing.Point(10, 45);
            this.PlBtnHolder.Name = "PlBtnHolder";
            this.PlBtnHolder.Size = new System.Drawing.Size(244, 26);
            this.PlBtnHolder.TabIndex = 9;
            // 
            // BtnOk
            // 
            this.BtnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.BtnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOk.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnOk.FlatAppearance.BorderSize = 2;
            this.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnOk.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.BtnOk.Location = new System.Drawing.Point(6, 0);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(46, 26);
            this.BtnOk.TabIndex = 50;
            this.BtnOk.Text = "OK";
            this.BtnOk.UseVisualStyleBackColor = false;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // BtnYes
            // 
            this.BtnYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.BtnYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnYes.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnYes.FlatAppearance.BorderSize = 2;
            this.BtnYes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnYes.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnYes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.BtnYes.Location = new System.Drawing.Point(52, 0);
            this.BtnYes.Name = "BtnYes";
            this.BtnYes.Size = new System.Drawing.Size(60, 26);
            this.BtnYes.TabIndex = 51;
            this.BtnYes.Text = "Yes";
            this.BtnYes.UseVisualStyleBackColor = false;
            this.BtnYes.Visible = false;
            this.BtnYes.Click += new System.EventHandler(this.BtnYes_Click);
            // 
            // BtnNo
            // 
            this.BtnNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.BtnNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNo.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnNo.FlatAppearance.BorderSize = 2;
            this.BtnNo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnNo.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.BtnNo.Location = new System.Drawing.Point(112, 0);
            this.BtnNo.Name = "BtnNo";
            this.BtnNo.Size = new System.Drawing.Size(46, 26);
            this.BtnNo.TabIndex = 52;
            this.BtnNo.Text = "No";
            this.BtnNo.UseVisualStyleBackColor = false;
            this.BtnNo.Visible = false;
            this.BtnNo.Click += new System.EventHandler(this.BtnNo_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnCancel.FlatAppearance.BorderSize = 2;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancel.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.BtnCancel.Location = new System.Drawing.Point(158, 0);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(86, 26);
            this.BtnCancel.TabIndex = 53;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Visible = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(10, 71);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(244, 10);
            this.panel6.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(254, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 71);
            this.panel3.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 71);
            this.panel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 10);
            this.panel1.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(10, 35);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(244, 10);
            this.panel4.TabIndex = 11;
            // 
            // LMessage
            // 
            this.LMessage.AutoSize = true;
            this.LMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LMessage.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LMessage.ForeColor = System.Drawing.Color.Black;
            this.LMessage.Location = new System.Drawing.Point(10, 10);
            this.LMessage.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.LMessage.MaximumSize = new System.Drawing.Size(1200, 740);
            this.LMessage.Name = "LMessage";
            this.LMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LMessage.Size = new System.Drawing.Size(148, 19);
            this.LMessage.TabIndex = 12;
            this.LMessage.Text = "Default Info Message";
            this.LMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Notifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(235)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(264, 81);
            this.Controls.Add(this.LMessage);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.PlBtnHolder);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(280, 120);
            this.Name = "Notifier";
            this.Opacity = 0.98D;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Info Message Title";
            this.PlBtnHolder.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel PlBtnHolder;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnYes;
        private System.Windows.Forms.Button BtnNo;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label LMessage;
    }
}