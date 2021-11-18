using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UClient.UIDesign
{
    public partial class Confirm : Form
    {
        private int WaitDelay = 1000;
        public bool HasAccepted { get; set; } = false;

        public Confirm(string ReqUser)
        {
            InitializeComponent();
            LIncomingUser.Text = ReqUser;
            CountTimeout();
        }

        private async void CountTimeout()
        {
            int TOut = 30;
            while (TOut > -1)
            {
                TOut--;
                await Task.Delay(WaitDelay);
                LAutoDecline.Text = $"Auto Declining The Request In : {TOut} Sec";
            }

            Close();
        }

        private void BtnAccept_Click(object _, EventArgs __)
        {
            HasAccepted = true;
            WaitDelay = 5000;
            Close();
        }

        private void BtnDecline_Click(object _, EventArgs __) => Close();

        public static bool Request(Form Sender, string ID)
        {
            bool HasConfirmed = false;
            //var Search = Participant.ConnectedOnes
                //.FirstOrDefault(P => P.ID == ID);

            //if (Sender.IsHandleCreated)
            //{
            //    Sender.Invoke(new MethodInvoker(() =>
            //    {
            //        if (Search != default(Participant))
            //        {
            //            using (var ReqDialog = new Confirm(Search.Name))
            //            {
            //                ReqDialog.ShowDialog(Sender);
            //                HasConfirmed = ReqDialog.HasAccepted;
            //            }

            //            if (HasConfirmed) UClient.Tools.Universal.PrivPartner = Search;
            //        }
            //    }));
            //}

            return HasConfirmed;
        }
    }
}
