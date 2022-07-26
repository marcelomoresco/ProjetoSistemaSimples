using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoBookApp {
    public partial class Search : Form {
        public Search() {
            InitializeComponent();
        }

        private void textBox8_TextChanged(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            if (textBox8.Text == "") {
                MessageBox.Show("Operação Inválida! Preencha o campo de 'ID'");
            }


            string fn = @"F:\C#\ProjetoBookApp\";
            //------ Nome----------
            string p = fn + this.textBox8.Text + "fn.txt";
            string r;

            this.textBox1.Text = this.textBox8.Text;

            if (System.IO.File.Exists(p) == true) {
                r = System.IO.File.ReadAllText(p);
                this.textBox2.Text = r;
            }

            //---------Sobrenome-----------//

            p= fn + this.textBox8.Text + "ln.txt";

            if (System.IO.File.Exists(p) == true) {
                r = System.IO.File.ReadAllText(p);
                this.textBox3.Text = r;
            }
            //--------------------//

            //---------Celular-----------//
            p= fn + this.textBox8.Text + "cel.txt";

            if (System.IO.File.Exists(p) == true) {
                r = System.IO.File.ReadAllText(p);
                this.textBox4.Text = r;
            }

            //---------E-mail-----------//

            p = fn + this.textBox8.Text + "email.txt";

            if (System.IO.File.Exists(p) == true) {
                r = System.IO.File.ReadAllText(p);
                this.textBox5.Text = r;
            }
            //--------------------//


            //---------Endereço-----------//

            p = fn + this.textBox8.Text + "cep.txt";

            if (System.IO.File.Exists(p) == true) {
                r = System.IO.File.ReadAllText(p);
                this.textBox6.Text = r;
            }
            //--------------------//

            //---------Comentário-----------//

            p = fn + this.textBox8.Text + "info.txt";

            if (System.IO.File.Exists(p) == true) {
                r = System.IO.File.ReadAllText(p);
                this.textBox7.Text = r;
            }
            //--------------------//

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }
    }
}
