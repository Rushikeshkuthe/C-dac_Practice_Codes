using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07DemoEvent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Button button1 = new Button();
            button1.Text = "Click Me";      // naming the button
            EventHandler pointer = new EventHandler(SomeThingToExecute); // we pass some event here

            button1.Click += pointer;  //attach pointer to clicking event

            this.Controls.Add(button1); // controls is base class of button
        }

        public void SomeThingToExecute(object sender, EventArgs e)  // these 2 arguments should be their
        {
            MessageBox.Show("Test");
        }
    }
}
