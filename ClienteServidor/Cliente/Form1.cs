using Compartida;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zyan.Communication;

namespace Cliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Connect to server
            var connection = new ZyanConnection("tcp://localhost:8080/ZyanDemo");

            // Create HelloWorldService proxy
            var proxy = connection.CreateProxy<IOperaciones>();

            // Invoke a method
            textBox3.Text=proxy.sumar(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)).ToString();
        }
    }
}
