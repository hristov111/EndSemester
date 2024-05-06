using EndSemensterProject;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace EndSemesterProject
{
    public  class Color_Button:Button
    {
        // 22, 162 - x,y
        public static Form1 Instance;
        public static CreateMember Instance2;
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            Instance.currentColor = this.BackColor == Color.Red
                ? "red" : this.BackColor == Color.Blue
                ? "blue" : this.BackColor == Color.Yellow
                ? "yellow" : this.BackColor == Color.Green 
                ? "green" : "black";
            Instance.currentOutColor = Instance.currentColor;
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            this.Cursor = Cursors.Hand;
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.Cursor= Cursors.Default;

        }



    }
}
