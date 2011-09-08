﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HtHistory.Core.DataBridges.ChppBridges.ChppFileAccessors;

namespace HtHistory
{
    public partial class AuthorizeDialog : Form
    {
        public AuthorizeDialog()
        {
            InitializeComponent();
        }

        private ChppOnlineAccessor _accessor = new ChppOnlineAccessor();
        public string AccessToken { get; private set; }
        public string AccessTokenSecret { get; private set; }

        private void AuthorizeDialog_Load(object sender, EventArgs e)
        {
            linkLabelRequestUri.Text = _accessor.GetAuthorizeUrl();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            try
            {
                string[] token_info = _accessor.Authorize(textBoxPIN.Text);
                AccessToken = token_info[0];
                AccessTokenSecret = token_info[1];
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("This failed. Please try again.\n\n{0}", ex), "Error");
            }
        }

        private void linkLabelRequestUri_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabelRequestUri.Text);
        }
    }
}
