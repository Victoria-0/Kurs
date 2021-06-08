using Kurs.ModelBd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurs
{
    public partial class Form1 : Form
    {
        ModelBd.Model1 connect = new ModelBd.Model1();
        public Form1()
        {
            InitializeComponent();
            connect.Library.Load();
            dataGridView1.DataSource = connect.Library.Local.ToBindingList();
        }

        private void dob_Click(object sender, EventArgs e)
        {

            Form2 form = new Form2();
            DialogResult result = form.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                Library clientadd = new Library();
                clientadd.Avtor = form.textBox1.Text;
                clientadd.Book = form.textBox2.Text;
                clientadd.God = form.textBox3.Text;
                clientadd.Style = form.textBox4.Text;

                connect.Library.Add(clientadd);
                connect.SaveChanges();
                MessageBox.Show("add");

            }
        }

        private void red_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = index;
                bool convert = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);



                Library clientedit = connect.Library.Find(id);

                form2.textBox1.Text = clientedit.Avtor;
                form2.textBox2.Text = clientedit.Book;
                form2.textBox3.Text = clientedit.God;
                form2.textBox4.Text = clientedit.Style;

                DialogResult resultedit = form2.ShowDialog(this);
                if (resultedit == DialogResult.OK)

                {
                    clientedit.Avtor = form2.textBox1.Text;
                    clientedit.Book = form2.textBox2.Text;
                    clientedit.God = form2.textBox3.Text;
                    clientedit.Style = form2.textBox4.Text;


                    connect.SaveChanges();
                    dataGridView1.Refresh();
                    MessageBox.Show("Объект обновлён");

                }
            }

        }
        private void yd_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == true)
                {
                    Library Clientdel = connect.Library.Find(id);
                    connect.Library.Remove(Clientdel);
                    connect.SaveChanges();
                    string buff = Clientdel.Book;
                    MessageBox.Show("Запись " + buff + " удалена");


                }




            }

            else

            {
                MessageBox.Show(" Не выбрана запись");
            }
        }
    }
}
