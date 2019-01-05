using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VyosSetRoutes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] routes=txtRoutes.Text.Split('\n');
            string[] gateways = txtGateway.Text.Split('\n');

            foreach(string route in routes)
            {
                foreach(string gw in gateways)
                {
                    txtScript.Text += string.Format("set protocols static route {0} next-hop {1}\r\n", route.Trim(),gw.Trim());
                }

                txtScript.Text += String.Format("comment protocols static route {0} \"{1}\"\r\n", route.Trim(),txtComment.Text);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
