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
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void tbTownsInfo_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnAddTown_Click_1(object sender, EventArgs e)
        {
            Tablet tablet = new Tablet();
            fTablet ft = new fTablet(tablet);
            if (ft.ShowDialog() == DialogResult.OK)

            {
                tbTownsInfo.Text +=
                (tablet.Brand, tablet.Model, tablet.Color,
                "Об'єм пам'ятi:", tablet.Memory, "Рік випуску:", tablet.Year , "Дiаогональ екрану:", tablet.SizeDisplay,
                tablet.Bluetooth ? "Є Bluetooth" : "Немає Bluetooth",
                tablet.NFC ? "Є NFC" : "Немає NFC",
                "Кiлькiсть одиниць товару", tablet.Number,
                "Загальна цiна товару на складi:", tablet.TotalPrice,
                "Середня ціна за одиницю товару:", tablet.GetYearIncomePerInhabitant(), "\r\n");

            }
        }
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Припинити роботу застосунку?",
            "Припинити роботу", MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }
    }
}
