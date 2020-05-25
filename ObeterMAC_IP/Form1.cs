using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace ObeterMAC_IP
{
    public partial class Form1 : Form
    {

        //========================================================================================================================
        // Metodo que retorna o Mac
        //========================================================================================================================
        public static String OBTER_MAC()
        {
            return (from nic in NetworkInterface.GetAllNetworkInterfaces()
                where nic.OperationalStatus == OperationalStatus.Up
                select nic.GetPhysicalAddress().ToString()).FirstOrDefault();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_MAC_Click(object sender, EventArgs e)
        {
            string strMac = OBTER_MAC();

            textMAC.Text = "";
            textMAC.Text = strMac;

            //MessageBox.Show(OBTER_MAC());
        }
    }
}
