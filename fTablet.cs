using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4aA
{
    public partial class fTablet : Form
    {

        public Tablet TheTablet;
        public fTablet (Tablet t)
        {
        
            TheTablet = t;
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            
            TheTablet.Brand = tbBrand.Text.Trim();
            TheTablet.Model = tbModel.Text.Trim();
            TheTablet.Color = tbColor.Text.Trim();
            TheTablet.Memory = int.Parse(tbMemory.Text.Trim());
            TheTablet.Year = double.Parse(tbYear.Text.Trim());
            TheTablet.SizeDisplay = double.Parse(tbSizeDisplay.Text.Trim());
            TheTablet.Bluetooth = chbBluetooth.Checked;
            TheTablet.NFC = chbNFC.Checked;
            TheTablet.Number = int.Parse(tbNumber.Text.Trim());
            TheTablet.TotalPrice = double.Parse(tbTotalPrice.Text.Trim());
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void fTown_Load(object sender, EventArgs e)
        {
            if (TheTablet != null)
            {
                tbBrand.Text = TheTablet.Brand;
                tbModel.Text = TheTablet.Model;
                tbColor.Text = TheTablet.Color;
                tbMemory.Text = TheTablet.Memory.ToString();
                tbYear.Text = TheTablet.Year.ToString();
                tbSizeDisplay.Text = TheTablet.SizeDisplay.ToString();
                tbTotalPrice.Text = TheTablet.TotalPrice.ToString();
                chbBluetooth.Checked = TheTablet.Bluetooth;
                chbNFC.Checked = TheTablet.NFC;
                tbNumber.Text = TheTablet.Number.ToString();
                

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void fMain_Load(object sender, EventArgs e)
        {

        }
    }
}
