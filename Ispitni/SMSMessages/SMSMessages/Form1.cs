using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SMSMessages
{
    public partial class Form1 : Form
    {
        List<Contact> contacts;

        Contact selectedContact;

        public Form1()
        {
            InitializeComponent();
            initContacts();
        }

        void initContacts()
        {
            contacts = new List<Contact>();
            Contact c = new Contact();
            c.Name = "John Doe";
            c.Number = "077123456";
            contacts.Add(c);
            c = new Contact();
            c.Name = "Jane Doe";
            c.Number = "076123456";
            contacts.Add(c);
            c = new Contact();
            c.Name = "Jack Nickolson";
            c.Number = "070550660";
            contacts.Add(c);
            c = new Contact();
            c.Name = "Al Pachino";
            c.Number = "071072073";
            contacts.Add(c);
            fill();
        }

        void fill()
        {
            string search = tbSearch.Text;
            lbNumbers.Items.Clear();
            btnAddMessage.Enabled = false;
            selectedContact = null;
            foreach (Contact c in contacts)
            {
                if (search == null || search.Trim().Length == 0)
                {
                    lbNumbers.Items.Add(c);
                }
                else
                {
                    if (c.Match(search))
                    {
                        lbNumbers.Items.Add(c);
                    }
                }
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            fill();
        }

        private void lbNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAddMessage.Enabled = lbNumbers.SelectedIndex != -1;
            if (lbNumbers.SelectedIndex != -1)
            {
                selectedContact = lbNumbers.SelectedItem as Contact;
                fillMessages();
            }
            else
            {
                selectedContact = null;
            }
            
        }

        private void btnAddMessage_Click(object sender, EventArgs e)
        {
            Message msg = new Message();
            if (msg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                selectedContact.Messages.Add(msg.MessageText);
                fillMessages();
                fill();
            }
        }

        void fillMessages()
        {
            if (selectedContact != null)
            {
                lbMessages.Items.Clear();
                foreach (string msg in selectedContact.Messages)
                {
                    lbMessages.Items.Add(msg);
                }
            }
        }



    }
}
