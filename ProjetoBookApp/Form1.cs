using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBookApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e) {
            Registration rg_data = new Registration();
            rg_data.MdiParent = this;
            rg_data.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e) {
            Search search_data = new Search();
            search_data.MdiParent = this;
            search_data.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e) {
            this.process1.StartInfo.FileName = @"C:\Windows\System32\calc.exe";
            this.process1.Start();
        }

        private void toolStripButton4_Click(object sender, EventArgs e) {
            AboutUs about_us = new AboutUs();
            about_us.MdiParent = this;
            about_us.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
