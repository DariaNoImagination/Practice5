using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        private List<Appliance> appliancesForm;

        public Form3(List<Appliance> appliances)
        {
            InitializeComponent();
            appliancesForm = appliances;
            printAppliance();
        }

        void printAppliance()
        {
            if (appliancesForm.Count != 0)
            {
                foreach (var appliance in appliancesForm)
                {

                    listBox.Items.Insert(0,appliance.ToString());  // Вызываем метод ToString() для каждого устройства
  
                }
            }
            else listBox.Items.Add("Список пуст");      
        }
        private void lst_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = (int)e.Graphics.MeasureString(listBox.Items[e.Index].ToString(), listBox.Font, listBox.Width).Height;
        }

        private void lst_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (listBox.Items.Count > 0)
            {
                e.DrawBackground();
                e.DrawFocusRectangle();
                e.Graphics.DrawString(listBox.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
            }
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

      
    }
}
