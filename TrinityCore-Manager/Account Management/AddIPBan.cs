﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace TrinityCore_Manager
{
    public partial class AddIPBan : DevComponents.DotNetBar.Office2007Form
    {
        public AddIPBan()
        {
            InitializeComponent();
        }

        // NOT FINISHED; NEEDS WORK
        private void banButton_Click(object sender, EventArgs e)
        {
            //TCManager.Instance.AuthDatabase.IpAccountBan(ipAddressBanInput.Value, banTimeTextBox.Text, banReasonTextBox.Text);
        }
    }
}
