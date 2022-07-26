using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoBookApp {
    public partial class Registration : Form {
        public Registration() {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void Registration_butt_Click(object sender, EventArgs e) {
            this.Registration_butt.Enabled = false;
            this.Save_button.Enabled = true;
            //---------------
            this.Info_groupBox1.Enabled = true;

            //------- Clear-----//

            this.textBox1.ResetText();
            this.textBox2.ResetText();
            this.textBox3.ResetText();
            this.textBox4.ResetText();
            this.textBox5.ResetText();
            this.textBox6.ResetText();
            this.textBox7.ResetText();
            //------------------//
        }

        private void Save_button_Click(object sender, EventArgs e) {

            if (this.textBox1.Text == "") {
                MessageBox.Show("Operação Inválida! Preencha o campo de 'ID'");
                return;
            }

            this.Save_button.Enabled = false;
            this.Registration_butt.Enabled = true;
            //-------------------
            this.Info_groupBox1.Enabled = false;

            string fn = @"F:\C#\ProjetoBookApp\";
            //------ Nome----------
            string p = fn + this.textBox1.Text + "fn.txt";
            System.IO.File.WriteAllText(p,this.textBox2.Text);
            //-------------------

            //------ Sobrenome----------
            p = fn + this.textBox1.Text + "ln.txt";
            System.IO.File.WriteAllText(p, this.textBox3.Text);
            //-------------------

            //------ Telefone----------
            p = fn + this.textBox1.Text + "cel.txt";
            System.IO.File.WriteAllText(p, this.textBox4.Text);
            //-------------------
            //------ Email----------
            p = fn + this.textBox1.Text + "email.txt";
            System.IO.File.WriteAllText(p, this.textBox5.Text);
            //-------------------
            //------ Endereço----------
            p = fn + this.textBox1.Text + "cep.txt";
            System.IO.File.WriteAllText(p, this.textBox6.Text);
            //-------------------
            //------ Comentário----------
            p = fn + this.textBox1.Text + "info.txt";
            System.IO.File.WriteAllText(p, this.textBox7.Text);
            //-------------------


            MessageBox.Show("Salvo Com Sucesso!");

        }

        private void Registration_Load(object sender, EventArgs e) {
            this.Info_groupBox1.Enabled = false;
        }

        private void textBox4_TextChanged(object sender, EventArgs e) {

        }
    }
}
