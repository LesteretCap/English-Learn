using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English_Learn
{
    internal class Presenter
    {
        Model model;
        Form1 learnEnglish;
        public Presenter(Form1 learn)
        {
            model = new Model();
            learnEnglish = learn;

            learnEnglish.NextWord += LearnEnglish_NextWord;
            learnEnglish.CheckWord += LearnEnglish_CheckWord;
        }

        private void LearnEnglish_CheckWord(object sender, EventArgs e)
        {

            bool result = model.CheckBox(learnEnglish.textBox1.Text);
            string line;
            if (result)
            {
                learnEnglish.label2.ForeColor = System.Drawing.Color.Green;
                line = "Great";
            }
            else
            {
                learnEnglish.label2.ForeColor = System.Drawing.Color.Red;
                line = "Awful";
            }

            learnEnglish.label2.Text = line;
        }

        public void LearnEnglish_NextWord(object sender, EventArgs e)
        {
            string text = model.NextWord();
            learnEnglish.label1.Text = text;
        }
    }
}
