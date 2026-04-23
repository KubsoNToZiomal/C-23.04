namespace apka
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtImie;
        private System.Windows.Forms.TextBox txtNazwisko;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnObraz;
        private System.Windows.Forms.Button btnDalej;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtImie = new System.Windows.Forms.TextBox();
            this.txtNazwisko = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnObraz = new System.Windows.Forms.Button();
            this.btnDalej = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();

            this.txtImie.Location = new System.Drawing.Point(30, 50);
            this.txtImie.Size = new System.Drawing.Size(200, 23);
            this.txtImie.TextChanged += new System.EventHandler(this.textBox_TextChanged);

            this.txtNazwisko.Location = new System.Drawing.Point(30, 100);
            this.txtNazwisko.Size = new System.Drawing.Size(200, 23);
            this.txtNazwisko.TextChanged += new System.EventHandler(this.textBox_TextChanged);

            this.txtEmail.Location = new System.Drawing.Point(30, 150);
            this.txtEmail.Size = new System.Drawing.Size(200, 23);
            this.txtEmail.TextChanged += new System.EventHandler(this.textBox_TextChanged);

            this.label1.Text = "Imię";
            this.label1.Location = new System.Drawing.Point(30, 30);

            this.label2.Text = "Nazwisko";
            this.label2.Location = new System.Drawing.Point(30, 80);

            this.label3.Text = "Email";
            this.label3.Location = new System.Drawing.Point(30, 130);

            this.btnObraz.Location = new System.Drawing.Point(30, 200);
            this.btnObraz.Size = new System.Drawing.Size(200, 30);
            this.btnObraz.Text = "OBRAZ";
            this.btnObraz.Click += new System.EventHandler(this.btnObraz_Click);

            this.btnDalej.Location = new System.Drawing.Point(30, 250);
            this.btnDalej.Size = new System.Drawing.Size(200, 30);
            this.btnDalej.Text = "DALEJ";
            this.btnDalej.Click += new System.EventHandler(this.btnDalej_Click);

            this.pictureBox1.Location = new System.Drawing.Point(300, 30);
            this.pictureBox1.Size = new System.Drawing.Size(400, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.ClientSize = new System.Drawing.Size(750, 400);
            this.Controls.Add(this.txtImie);
            this.Controls.Add(this.txtNazwisko);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnObraz);
            this.Controls.Add(this.btnDalej);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Text = "Formularz";

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}