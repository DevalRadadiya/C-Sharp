using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace WindowsFormsApplication8
{
    
    public partial class Form1 : Form
    {
        SqlConnection con;
        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection(@"D:\Sem5\C#\Program\WindowsFormsApplication8\WindowsFormsApplication8\Form1.cs");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
