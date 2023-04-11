using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class Form_Class1 : Form
    {
        public Form_Class1()
        {
            InitializeComponent();
        }

        private void button_Ok_Click(object sender, EventArgs e)
            => DialogResult = DialogResult.OK;

        private void button_Cancel_Click(object sender, EventArgs e)
            => DialogResult = DialogResult.Cancel;
    }
}
