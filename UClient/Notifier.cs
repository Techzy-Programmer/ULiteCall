using System;
using System.Drawing;
using System.Windows.Forms;

namespace UClient
{
    public partial class Notifier : Form
    {
        private MsgResult _MRes = MsgResult.Abort;
        public MsgResult MResult
        {
            get => _MRes;
            set
            {
                _MRes = value;
                Close();
            }
        }

        private void BtnOk_Click(object _, EventArgs E)
            => MResult = MsgResult.Ok;

        private void BtnNo_Click(object _, EventArgs E)
            => MResult = MsgResult.No;

        private void BtnYes_Click(object _, EventArgs E)
            => MResult = MsgResult.Yes;

        private void BtnCancel_Click(object _, EventArgs E)
            => MResult = MsgResult.Cancel;
        
        public static MsgResult Pop(string Msg)
        {
            MsgResult DialogRes;

            using (var Dialog = new Notifier(Msg))
            {
                Dialog.ShowDialog();
                DialogRes = Dialog.MResult;
            }

            return DialogRes;
        }

        public static MsgResult Pop(string Title, string Msg, MsgType Type, MsgBtn Btn = MsgBtn.OK)
        {
            MsgResult DialogRes;

            using (var Dialog = new Notifier(Msg, Title, Type, Btn))
            {
                Dialog.ShowDialog();
                DialogRes = Dialog.MResult;
            }

            return DialogRes;
        }

        public Notifier(string DispMSG, string DispTitle = "Message-Box", MsgType MType = MsgType.Info, MsgBtn MBtn = MsgBtn.OK)
        {
            InitializeComponent();

            Text = DispTitle;
            LMessage.Text = DispMSG;
            decimal Ratio = (decimal)LMessage.Size.Width / LMessage.Size.Height;

            if (!Width.Equals(MinimumSize.Width))
                while ((double)Ratio > 3.2 && LMessage.Width > MinimumSize.Width)
                {
                    LMessage.MaximumSize = new Size(LMessage.Width - 5, 0);
                    Ratio = (decimal)LMessage.Size.Width / LMessage.Size.Height;
                }

            if (LMessage.Width < MinimumSize.Width)
            {
                var THeight = Height;
                AutoSize = false;
                Height = THeight;
                LMessage.AutoSize = false;
            }
            
            int Check = Screen.PrimaryScreen.Bounds.Height - LMessage.Height;
            if (Check <= 100) throw new OverflowException("Message length is " +
                "very large to be displayed correctly in the Message-Box.");

            switch (MType)
            {
                case MsgType.Success: BackColor = Color.FromArgb(205, 250, 210); Icon = Properties.Resources.Success; break;
                case MsgType.Question: BackColor = Color.FromArgb(200, 255, 255); Icon = Properties.Resources.Ques; break;
                case MsgType.Warning: BackColor = Color.FromArgb(245, 245, 210); Icon = Properties.Resources.Warn; break;
                case MsgType.Error: BackColor = Color.FromArgb(255, 225, 225); Icon = Properties.Resources.Error; break;
                default: BackColor = Color.FromArgb(210, 235, 250); Icon = Properties.Resources.Info; break;
            }

            switch (MBtn)
            {
                case MsgBtn.YesNo:

                    BtnCancel.Visible = false;
                    BtnOk.Visible = false;
                    BtnYes.Visible = true;
                    BtnNo.Visible = true;
                    BtnNo.Select();
                    break;

                case MsgBtn.YesNoCancel:

                    BtnCancel.Visible = true;
                    BtnOk.Visible = false;
                    BtnYes.Visible = true;
                    BtnNo.Visible = true;
                    BtnCancel.Select();
                    break;

                default:

                    BtnCancel.Visible = false;
                    BtnYes.Visible = false;
                    BtnNo.Visible = false;
                    BtnOk.Visible = true;
                    BtnOk.Select();
                    break;
            }
        }
    }

    public static class PopExt
    {
        public static MsgResult Pop(this Form Owner, string Msg)
        {
            MsgResult DialogRes;

            using (var Dialog = new Notifier(Msg))
            {
                Dialog.ShowDialog(Owner);
                DialogRes = Dialog.MResult;
            }

            return DialogRes;
        }

        public static MsgResult Pop(this Form Owner, string Title, string Msg, MsgType Type, MsgBtn Btn = MsgBtn.OK)
        {
            MsgResult DialogRes;

            using (var Dialog = new Notifier(Msg, Title, Type, Btn))
            {
                Dialog.ShowDialog(Owner);
                DialogRes = Dialog.MResult;
            }

            return DialogRes;
        }
    }

    public enum MsgResult
    {
        Ok,
        No,
        Yes,
        Abort,
        Cancel
    }

    public enum MsgType
    {
        Info,
        Error,
        Success,
        Warning,
        Question
    }

    public enum MsgBtn
    {
        OK,
        YesNo,
        YesNoCancel
    }
}
