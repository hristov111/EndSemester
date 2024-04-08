using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EndSemesterProject
{
    public class CheckTextbox
    {
        public CheckTextbox(){}
        public Color ConvertToColor(string color)
        {

            color = color.ToLower();
            if (color.Contains('[') && color.Contains(']'))
            {
                return ConvertToColor(color.Substring(color.IndexOf('[')+1, color.IndexOf(']')-color.IndexOf('[')-1));
            }
            switch (color)
            {
                case "red":
                    return Color.Red;
                case "blue":
                    return Color.Blue;
                case "green":
                    return Color.Green;
                case "yellow":
                    return Color.Yellow;
                case "black":
                    return Color.Black;
                default:
                    return Color.Aqua;
            }
        }

        public int GiveValue(TextBox t, string message)
        {
            if (!check_Text(t))
            {
                MessageBox.Show(message, "Error!");
                t.Text = "";
                //default value if there is a error
                return 50;
            }
            if (t.Text != "")
            {
                int num = Convert.ToInt32(t.Text);
                t.Text = "";
                return num;
            }
            else
            {
                MessageBox.Show("No argument given! Default value of 50 set", "Error!");
                return 50;
            }
        }

        public bool check_Text(TextBox t)
        {
            string text = t.Text;
            foreach (char c in text)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
