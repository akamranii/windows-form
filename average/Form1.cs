using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                float v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, total, avg;
                v1 = float.Parse(box1.Text);
                v2 = float.Parse(box2.Text);
                v3 = float.Parse(box3.Text);
                v4 = float.Parse(box4.Text);
                v5 = float.Parse(box5.Text);
                v6 = float.Parse(box6.Text);
                v7 = float.Parse(box7.Text);
                v8 = float.Parse(box8.Text);
                v9 = float.Parse(box9.Text);
                v10 = float.Parse(box10.Text);
                v11 = float.Parse(box11.Text);
                v12 = float.Parse(box12.Text);
                v13 = float.Parse(box13.Text);
                v14 = float.Parse(box14.Text);
                v15 = float.Parse(box15.Text);
                v16 = float.Parse(box16.Text);
                v17 = float.Parse(box17.Text);
                v18 = float.Parse(box18.Text);
                v19 = float.Parse(box19.Text);
                v20 = float.Parse(box20.Text);
                total = v1 + v2 + v3 + v4 + v5 + v6 + v7 + v8 + v9 + v10 + v11 + v12 + v13 + v14 + v15 + v16 + v17 + v18 + v19 + v20;
                avg = total / 20;
                box21.Text = "" + total;
                box22.Text = "" + avg;
                listBox1.Items.Clear();
                listBox1.Items.Add(e.ToString());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            box1.Text = "";
            box2.Text = "";
            box3.Text = "";
            box4.Text = "";
            box5.Text = "";
            box6.Text = "";
            box7.Text = "";
            box8.Text = "";
            box9.Text = "";
            box10.Text = "";
            box11.Text = "";
            box12.Text = "";
            box13.Text = "";
            box14.Text = "";
            box15.Text = "";
            box16.Text = "";
            box17.Text = "";
            box18.Text = "";
            box19.Text = "";
            box20.Text = "";
            box21.Text = "";
            box22.Text = "";
        }
    }
}
