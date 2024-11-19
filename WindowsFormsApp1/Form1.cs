using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Appliance> appliances = new List<Appliance>();
        public Appliance this[int index]
        {
            get => appliances[index];
            set => appliances[index] = value;   
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 addForm = new Form2();
            addForm.ShowDialog();
            Appliance appliance = addForm.appliance;
            appliances.Add(appliance);
 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 listForm = new Form3(appliances);
            listForm.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            appliances.Clear(); //Очищаем список
            Close();
        }
    }
}
