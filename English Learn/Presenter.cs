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

        const int MAX_ATTEMPT = 3;
        const int LOSE = 0;
        static int counter = MAX_ATTEMPT;
        static int score = 0;

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
                score++;
                learnEnglish.label6.Text = score.ToString();
                LearnEnglish_NextWord(sender, e);
            }
            else
            {
                learnEnglish.label2.ForeColor = System.Drawing.Color.Red;
                line = "Awful";

                counter--;
                learnEnglish.label3.Text = counter.ToString();
                if (counter == LOSE)
                {
                    learnEnglish.label2.ForeColor = System.Drawing.Color.Red;
                    learnEnglish.label2.BackColor = System.Drawing.Color.Black;
                    line = "YOU LOSE";
                    learnEnglish.button2.Enabled = false;
                }
            }

            learnEnglish.label2.Text = line;
        }

        public void LearnEnglish_NextWord(object sender, EventArgs e)
        {
            string text = model.NextWord();
            learnEnglish.textBox1.Text = null;
            learnEnglish.label1.Text = text;
        }
    }
}
