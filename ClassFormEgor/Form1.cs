using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryEgor;
using System.Windows.Forms;


namespace ClassFormEgor
{
    public partial class Form1 : Form
    {
        CMass a;

        public Form1()
        {
            InitializeComponent();
        }

        private void Aff_full_mass_but_Click(object sender, EventArgs e)
        {
            int i = 1;
            foreach (char m in Add_full_mass_txt.Text)
            {
                if (m == ':')
                    i++;
            }
            if (Add_full_mass_txt.Text[Add_full_mass_txt.Text.Length - 1] == ':')
                i--;
            float[] massbuf = new float[i];
            string cursor = "";
            i = 0;
            for (int j = 0; j < Add_full_mass_txt.Text.Length; j++)
            {
                if (Add_full_mass_txt.Text[j] != ':')
                {
                    cursor += Add_full_mass_txt.Text[j];
                }
                else
                {
                    massbuf[i] = float.Parse(cursor);
                    cursor = "";
                    i++;
                }
            }
            if (cursor != "")
                massbuf[i] = float.Parse(cursor);
            a = new CMass(massbuf);
            for (int j = 0; j < a.getdlinaMass; j++)
            {
                rtxb.Text += a[j].ToString();
                cmb.Items.Add(j);
                if (j != a.getdlinaMass - 1)
                    rtxb.Text += ":";
            }
            Add_lenght_txt.ReadOnly = true;
            Add_full_mass_txt.ReadOnly = true;
            Add_lenght_but.Enabled = false;
            Add_full_mass_but.Enabled = false;
            Prod1_but.Enabled = true;
            Prod2_but.Enabled = true;
            Prod2_txt.ReadOnly = false;
            Prod3_but.Enabled = true;
        }

        private void Add_lenght_but_Click(object sender, EventArgs e)
        {
            a = new CMass(int.Parse(Add_lenght_txt.Text));
            Add_lenght_but.Enabled = false;
            Add_lenght_txt.ReadOnly = true;
            Add_full_mass_but.Enabled = false;
            Add_full_mass_txt.ReadOnly = true;
            Add_elm_txt.ReadOnly = false;
            Add_elm_but.Enabled = true;
        }

        private void Add_elm_but_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (char m in rtxb.Text)
            {
                if (m == ':')
                    i++;
            }
            if (i < a.getdlinaMass)
            {
                a[i] = float.Parse(Add_elm_txt.Text);
                rtxb.Text += Add_elm_txt.Text;
                Add_elm_txt.Text = "";
                if (i != a.getdlinaMass - 1)
                    rtxb.Text += ":";
                else
                {
                    for (int j = 0; j < a.getdlinaMass; j++)
                    {
                        cmb.Items.Add(j);
                    }
                    Add_lenght_txt.ReadOnly = true;
                    Add_full_mass_txt.ReadOnly = true;
                    Add_elm_txt.ReadOnly = true;
                    Add_elm_but.Enabled = false;
                    Add_lenght_but.Enabled = false;
                    Add_full_mass_but.Enabled = false;
                    Prod1_but.Enabled = true;
                    Prod2_but.Enabled = true;
                    Prod2_txt.ReadOnly = false;
                    Prod3_but.Enabled = true;
                }
            }
        }

        private void Clear_but_Click(object sender, EventArgs e)
        {
            rtxb.Text = "";
            Add_lenght_txt.ReadOnly = false;
            Add_full_mass_txt.ReadOnly = false;
            Add_elm_txt.ReadOnly = true;
            Add_elm_but.Enabled = false;
            Add_lenght_but.Enabled = true;
            Add_full_mass_but.Enabled = true;
            Prod1_but.Enabled = false;
            Prod2_but.Enabled = false;
            Prod2_txt.ReadOnly = true;
            Prod3_but.Enabled = false;
        }

        private void Prod1_but_Click(object sender, EventArgs e)
        {
            rtxb.Text += "\n";
            rtxb.Text += a.prod();
        }

        private void Prod2_but_Click(object sender, EventArgs e)
        {
            rtxb.Text += "\n";
            rtxb.Text += a.prod(int.Parse(Prod2_txt.Text));
        }

        private void Prod3_but_Click(object sender, EventArgs e)
        {
            rtxb.Text += "\n";
            rtxb.Text += a.prod(a[0], int.Parse(cmb.SelectedItem.ToString()));
        }
    }
}
