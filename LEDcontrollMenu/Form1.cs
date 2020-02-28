using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEDcontrollMenu
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            lboMenu.Items.Add("Lasagne");
            lboMenu.Items.Add("Spagehetti");
            lboMenu.Items.Add("Pizza");
            lboMenu.Items.Add("Tortellini");
            




        }

        private void cmdShowStats_Click(object sender, EventArgs e)
        {
            string meals = "";
            foreach (string meal in lboMenu.Items)
            {
                meals += (meal +"\n");
            }

            lblStatistic.Text = "Amount: " + lboMenu.Items.Count +
                                "\nSelected Meal: " + lboMenu.SelectedItem +
                                "\nSelected Number: " + (lboMenu.SelectedIndex + 1) +
                                "\n\nAll Meals:\n" + meals;
                               
        }

        private void cmdAddMeal_Click(object sender, EventArgs e)
        {
            if(rdoTop.Checked==false && rdoBot.Checked==false)
            {
                MessageBox.Show("Item location not clear");
            }
            else if(txtNewMeal.Text=="")
            {
                MessageBox.Show("No meal label");
            }
            else if(rdoTop.Checked)
            {
                lboMenu.Items.Insert(0, txtNewMeal.Text);
            }
            else if(rdoBot.Checked)
            {
                lboMenu.Items.Add(txtNewMeal.Text);
            }
        }

        

        private void cmdDeleteSelected_Click(object sender, EventArgs e)
        {
            
            if(lboMenu.SelectedIndex == -1)
            {
                MessageBox.Show("No meal selected!");
            }
            else
            {
                
                DialogResult result = MessageBox.Show("Are you sure you want to delete this?","Delete Selected Item", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    lboMenu.Items.RemoveAt(lboMenu.SelectedIndex);
                }
                else if(result == DialogResult.Cancel)
                {
                    MessageBox.Show("Aborted");
                }
            }
        }

        private void cmdReplace_Click(object sender, EventArgs e)
        {
            if(lboMenu.SelectedIndex == -1)
            {
                MessageBox.Show("No item to replace selected");
            }
            else if(txtReplaceName.Text=="")
            {
                MessageBox.Show("No new meal declared");
            }
            else
            {
                int i = lboMenu.SelectedIndex;
                lboMenu.Items.RemoveAt(i);
                lboMenu.Items.Insert(i, txtReplaceName.Text);
                txtReplaceName.Text = "";
            }
        }

        private void cmdClearAll_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete everything?", "Delete All Data", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                lboMenu.Items.Clear();
                lblStatistic.Text = "";
                rdoTop.Checked = false;
                rdoBot.Checked = false;
                txtNewMeal.Text = "";
                txtReplaceName.Text = "";
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Aborted");
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}