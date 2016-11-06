using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void encrypt_Click(object sender, EventArgs e)
        {
            //encrypt
            int keynum = Convert.ToInt32(key.Text);
            char[] data = message.Text.ToCharArray();
            for(int x = 0; x < data.Length; x++)
            {
                data[x] = (char)(data[x] + keynum);
                //vb
                //data(x) = chr(asc(data(x)) + keynum)
            }
            cipher.Text = new string(data);
        }

        private void decrypt_Click(object sender, EventArgs e)
        {
            //decrypt
            int keynum = Convert.ToInt32(key.Text);
            char[] data = cipher.Text.ToCharArray();
            for (int x = 0; x < data.Length; x++)
            {
                data[x] = (char)(data[x] - keynum);
                //vb
                //data(x) = chr(asc(data(x)) + keynum)
            }
            message.Text = new string(data);
        }
    }
}
