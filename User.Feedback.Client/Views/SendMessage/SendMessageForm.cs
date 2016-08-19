﻿using System;
using System.Windows.Forms;

namespace User.Feedback.Client.Views.SendMessage
{
    public partial class SendMessageForm : Form, ISendMessageForm
    {
        public SendMessageFormPresenter Presenter { get; set; }

        public SendMessageForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            Presenter = new SendMessageFormPresenter(this);
        }

        public string Message
        {
            get { return messageTextBox.Text; }
            set { messageTextBox.Text = value; }
        }

        public event EventHandler MessageSent
        {
            add { sendMessageButton.Click += value; }
            remove { sendMessageButton.Click += value; }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                messageTextBox.Text = string.Empty;
                e.Cancel = true;

                Hide();
            }
        }
    }
}
