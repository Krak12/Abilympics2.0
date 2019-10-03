using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abilympics2._0
{
    public partial class ChangePassCr : Form
    {
        public ChangePassCr()
        {
            InitializeComponent();
        }

        // закрытие формы
        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        /* сохранение значения пароля в переменную ChangePassCr и
          переход на форму CreatorMenu */
        private void Button2_Click(object sender, EventArgs e)
        {
            Data.ChangePassCr = textBox3.Text;
            Form cm = new CreatorMenu();
            Hide();
            DialogResult res = cm.ShowDialog();
            if (res != DialogResult.Cancel)
            {
                Show();
            }
            else Close();
        }
    }
}
