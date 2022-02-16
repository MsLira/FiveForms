using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MLiraACP2_1
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void lbl_Descrip_Click(object sender, EventArgs e)
        {

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Linked_List myForm = new Linked_List();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
