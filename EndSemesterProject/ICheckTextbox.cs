using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndSemesterProject
{
    internal interface ICheckTextbox
    {
        Color ConvertToColor(string color);
        int GiveValue(TextBox t, string message);

        bool check_Text(TextBox t);
    }
}
