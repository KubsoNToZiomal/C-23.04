using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace apka
{
    public partial class Form1 : Form
    {
        private string sciezkaObrazu = "";

        public Form1()
        {
            InitializeComponent();
            btnDalej.Enabled = false;
        }

        private void btnObraz_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Pliki graficzne|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                sciezkaObrazu = ofd.FileName;
                pictureBox1.ImageLocation = sciezkaObrazu;
                SprawdzPoprawnosc();
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            SprawdzPoprawnosc();
        }

        private bool CzyEmailPoprawny(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        private void SprawdzPoprawnosc()
        {
            bool poprawnyEmail = CzyEmailPoprawny(txtEmail.Text);
            bool maObraz = !string.IsNullOrEmpty(sciezkaObrazu);
            bool maDane = txtImie.Text.Length > 0 && txtNazwisko.Text.Length > 0;

            btnDalej.Enabled = poprawnyEmail && maObraz && maDane;
        }

        private void btnDalej_Click(object sender, EventArgs e)
        {
            if (!CzyEmailPoprawny(txtEmail.Text))
            {
                MessageBox.Show("Niepoprawny email!");
                return;
            }

            if (string.IsNullOrEmpty(sciezkaObrazu))
            {
                MessageBox.Show("Nie wybrano obrazu!");
                return;
            }

            string linia = $"{txtImie.Text} {txtNazwisko.Text} {txtEmail.Text} {sciezkaObrazu}";
            File.AppendAllText("dane.txt", linia + Environment.NewLine);

            MessageBox.Show("Zapisano!");

            txtImie.Clear();
            txtNazwisko.Clear();
            txtEmail.Clear();
            pictureBox1.Image = null;
            sciezkaObrazu = "";
            btnDalej.Enabled = false;
        }
    }
}