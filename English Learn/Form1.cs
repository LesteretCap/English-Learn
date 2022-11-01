using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace English_Learn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            new Presenter(this);
        }

        private EventHandler nextWord;
        private EventHandler checkWord;

        public event EventHandler NextWord
        { 
            add { nextWord += value; }
            remove { nextWord -= value; }
        }
        public event EventHandler CheckWord
        {
            add { checkWord += value; }
            remove { checkWord -= value; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            nextWord.Invoke(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkWord.Invoke(sender, e);
        }
    }
}
