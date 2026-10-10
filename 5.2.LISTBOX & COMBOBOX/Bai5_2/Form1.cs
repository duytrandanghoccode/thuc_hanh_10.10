using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5_2
{
    public partial class frmService : Form
    {
        Dictionary<string, List<Service>> services;

        public frmService()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            services = new Dictionary<string, List<Service>>();

            services.Add("Khám bệnh", new List<Service>()
        {
            new Service("Khám tổng quát", 200000),
            new Service("Khám tim mạch", 300000),
            new Service("Khám da liễu", 250000)
        });

            services.Add("Xét nghiệm", new List<Service>()
        {
            new Service("Xét nghiệm máu", 150000),
            new Service("Xét nghiệm nước tiểu", 100000),
            new Service("Xét nghiệm đường huyết", 120000)
        });

            services.Add("Chụp X-Quang", new List<Service>()
        {
            new Service("X-Quang phổi", 250000),
            new Service("X-Quang xương", 300000),
            new Service("X-Quang răng", 200000)
        });

            services.Add("Vắc-xin", new List<Service>()
        {
            new Service("Vắc-xin cúm", 350000),
            new Service("Vắc-xin viêm gan B", 400000),
            new Service("Vắc-xin HPV", 1500000)
        });

            cboCategory.Items.AddRange(services.Keys.ToArray());

            cboCategory.SelectedIndex = 0;
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstAvailableServices.Items.Clear();

            string category = cboCategory.SelectedItem.ToString();

            foreach (Service service in services[category])
            {
                lstAvailableServices.Items.Add(service);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (lstAvailableServices.SelectedItem != null)
            {
                lstSelectedServices.Items.Add(
                    lstAvailableServices.SelectedItem
                );

                CalculateTotal();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstSelectedServices.SelectedItem != null)
            {
                lstSelectedServices.Items.Remove(
                    lstSelectedServices.SelectedItem
                );

                CalculateTotal();
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            lstSelectedServices.Items.Clear();

            CalculateTotal();
        }

        private void CalculateTotal()
        {
            decimal total = 0;

            foreach (Service service in lstSelectedServices.Items)
            {
                total += service.Price;
            }

            txtTotal.Text = total.ToString("N0");

            decimal discount = 0;
            if (!decimal.TryParse(txtDiscount.Text, out discount))
            {
                MessageBox.Show("Chiết khấu phải là số!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                txtDiscount.Focus();
                return;
            }

            if (discount < 0 || discount > 100)
            {
                MessageBox.Show("Chiết khấu phải từ 0 đến 100!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                txtDiscount.Focus();
                return;
            }

            decimal payment = total - total * discount / 100;

            txtPayment.Text = payment.ToString("N0");
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }
        private void lblSelected_Click(object sender, EventArgs e)
        {
        }
    }
}
