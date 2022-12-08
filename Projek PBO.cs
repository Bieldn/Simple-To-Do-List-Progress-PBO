using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
using Npgsql;
using System.Data;
using System.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using Npgsql;


namespace to_do_list_PBO
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            
            dgv.Rows.Add(txtName.Text, txtTgl.Text, txtKeg.Text);

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow! == null)
            {
                dgv.CurrentRow.Cells["kegiatan"].Value = txtName.Text;
                dgv.CurrentRow.Cells["tanggal"].Value = txtTgl.Text;
                dgv.CurrentRow.Cells["keterangan"].Value = txtKeg.Text;
            }

        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow != null)
            {
                dgv.Rows.RemoveAt(dgv.CurrentRow.Index);

            }

        }
        int TxtKey;
        private void txtName_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
    }
}