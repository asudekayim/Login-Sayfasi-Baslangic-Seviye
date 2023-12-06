using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gelecegi_Yazanlar_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        void kodOlustur()
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(1000, 10000);
            textBox4.Text = sayi.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            kodOlustur();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "random@mail.com" && textBox2.Text == "1234" && textBox3.Text == textBox4.Text)
            {
                MessageBox.Show("Başarıyla giriş yapıldı", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("HATALI GİRİŞ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
