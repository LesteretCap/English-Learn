using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English_Learn
{
    internal class Model
    {
        string[] rusWords;
        string[] engWords;

        Random rand = new Random();

        public Model()
        {
            rusWords = new string[]
            {
                "Понедельник",
                "Вторник",
                "Среда",
                "Четверг",
                "Пятница",
                "Суббота",
                "Воскресенье"
            };
            engWords = new string[]
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
        }

        public string NextWord()
        {
            return rusWords[rand.Next(rusWords.Length)];
        }

        public bool CheckBox(string text)
        {
            bool result = false;
            for (int i = 0; i < rusWords.Length; i++)
            {
                if (text == engWords[i])
                {
                    result = true;
                }
            }
            return result;
        }
    }
}
