using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class FirstPage : Form
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            int Size = Convert.ToInt32(txt_Size.Text);

            if (Size % 2 == 0 && Size < 7)
            {
                frm_MemoryGame f = new frm_MemoryGame(txt_Name.Text, Convert.ToInt32(txt_Size.Text));
                this.Hide();
                f.Show();
            }
            else
            {
                if (MessageBox.Show("The size of the playing field should be even and larger than zero and less than 7 !!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1) == DialogResult.Cancel)
                {
                    this.Close();
                }
            }
        }
    }
}
