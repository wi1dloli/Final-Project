using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ChocolateSauce.Enabled = false;
            StrawberrySauce.Enabled = false;
            

        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        double totalPrice = 0;
        double iceCreamCost = 2;
        double saucePrice = .5;
        double topingPrice = .75;
        int topingCount = 0;
        int sauceCount = 0;
        string sauceWarn = "Maximum Sauce Reached";
        string toppingWarn = "Max Toppings Reached";


        private void button1_Click_1(object sender, EventArgs e)
        {

                if (VanillaIce.Checked == true)
                {
                    StrawberrySauce.Enabled = true;
                    textBox2.Text = $"${iceCreamCost} has been added to your total.";
                    totalPrice = totalPrice + iceCreamCost;
                    textBox1.Text = $"${totalPrice}";
                }
                if (ChocolateIce.Checked == true)
                {
                    ChocolateSauce.Enabled = true;
                    textBox2.Text = $"${iceCreamCost} has been added to your total.";
                    totalPrice = totalPrice + iceCreamCost;
                    textBox1.Text = $"${totalPrice}";
                }  
        }



        private void StrawberrySauce_Click(object sender, EventArgs e)
        {
            if (sauceCount > 0)
            {
                StrawberrySauce.Enabled = false;
                ChocolateSauce.Enabled = false;
                Select.Enabled = false;
                label4.Text = sauceWarn;
            }
            else
            {
                totalPrice = totalPrice + saucePrice;
                textBox2.Text = $"${saucePrice} has been added to your total.";
                textBox1.Text = $"${totalPrice}";
            }
            sauceCount += 1;
        }

        private void ChocolateSauce_Click(object sender, EventArgs e)
        {
            if (sauceCount > 0)
            {
                StrawberrySauce.Enabled = false;
                ChocolateSauce.Enabled = false;
                Select.Enabled = false;
                label4.Text = sauceWarn;
            }
            else
            {
                totalPrice = totalPrice + saucePrice;
                textBox2.Text = $"${saucePrice} has been added to your total.";
                textBox1.Text = $"${totalPrice}";
            }
            sauceCount += 1;
        }


        private void TopSelect_Click(object sender, EventArgs e)
        {
            if (topingCount > 0)
            {
                Sprinkles.Enabled = false;
                MeltedMarshmellow.Enabled = false;
                Oreos.Enabled = false;
                WhippedCream.Enabled = false;
                TopSelect.Enabled = false;

                label3.Text = toppingWarn;
            }

            topingCount += 1;
        }


        private void Sprinkles_Click(object sender, EventArgs e)
        {
            totalPrice = totalPrice + topingPrice;
            textBox2.Text = $"${topingPrice} has been added to your total.";
            textBox1.Text = $"${totalPrice}";
        }

        private void MeltedMarshmellow_Click(object sender, EventArgs e)
        {
            totalPrice = totalPrice + topingPrice;
            textBox2.Text = $"${topingPrice} has been added to your total.";
            textBox1.Text = $"${totalPrice}";
        }

        private void Oreos_Click(object sender, EventArgs e)
        {
            totalPrice = totalPrice + topingPrice;
            textBox2.Text = $"${topingPrice} has been added to your total.";
            textBox1.Text = $"${totalPrice}";
        }

        private void WhippedCream_Click(object sender, EventArgs e)
        {
            totalPrice = totalPrice + topingPrice;
            textBox2.Text = $"${topingPrice} has been added to your total.";
            textBox1.Text = $"${totalPrice}";
        }

        private void Pay_Click(object sender, EventArgs e)
        {
            double totalCash = Convert.ToDouble(CashAmount.Text);
            double totalChange = totalCash - totalPrice;

            if(totalChange<0)
            {
                textBox3.Text = "Transaction Failed. Insufficient Funds";
            }    
           else
            {
                textBox3.Text = $"${totalChange}";
            }
        }
    }
}
