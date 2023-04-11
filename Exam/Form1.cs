using ExamDomain;
using ExamInfrastructura;
using System.Numerics;
using System.Windows.Forms;

namespace Exam
{
    public partial class Form1 : Form
    {
        private readonly ApplicationDbContext context;

        public Form1(ApplicationDbContext context)
        {
            InitializeComponent();
            this.context = context;

            dataGridView_test.DataSource = context.Companies.Local.ToBindingList();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            Form_Class1 dialog = new Form_Class1();
            if (dialog.ShowDialog(this) != DialogResult.OK) return;

            Class1 class1 = new Class1();
            class1.Name = dialog.textBox_Text.Text;

            context.Companies.Add(class1);
            context.SaveChanges();

            MessageBox.Show("Новый объект добавлен");
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            if (dataGridView_test.SelectedRows.Count <= 0) return;

            int index = dataGridView_test.SelectedRows[0].Index;
            int id = 0;
            bool converted = Int32.TryParse(dataGridView_test[0, index].Value.ToString(), out id);
            if (converted == false) return;

            Class1? class1 = context.Companies.Find(id);
            if (class1 == null) return;

            Form_Class1 dialog = new Form_Class1();

            dialog.textBox_Text.Text = class1.Name;

            if(dialog.ShowDialog(this) != DialogResult.OK) return;

            class1.Name = dialog.textBox_Text.Text;

            context.SaveChanges();
            dataGridView_test.Refresh();
            MessageBox.Show("Объект обновлен");
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView_test.SelectedRows.Count <= 0) return;

            int index = dataGridView_test.SelectedRows[0].Index;
            int id = 0;
            bool converted = Int32.TryParse(dataGridView_test[0, index].Value.ToString(), out id);
            if (converted == false) return;

            Class1? class1 = context.Companies.Find(id);
            if(class1 == null) return;

            context.Companies.Remove(class1);
            context.SaveChanges();

            MessageBox.Show("Объект удален");
        }
    }
}