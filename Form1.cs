using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4.Builder;
using WindowsFormsApp4.Com;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Model1 model = new Model1();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bbuilder b = new Bbuilder();
            BDirector d = new BDirector(b);

            if (comboBox1.SelectedItem.ToString() == "Бургер стандартный")
                d.BuildDefault();
            else
                d.BuildWith();

            try
            {
                model.Burgers.Add(b.GetBurgers());
                model.SaveChanges();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            LoadData();
        }
        private void LoadData()
        {
            comboBox1.SelectedIndex = 0;
            dataGridView1.DataSource = model.Burgers.ToList();
        }
    }
}
