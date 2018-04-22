import sys
sys.path.append(r'C:\Python24\Lib')

import clr
clr.AddReference("System.Drawing")
from System.Drawing import (Pens,Color
    ,Font,FontStyle, Point,Brushes)
clr.AddReference("System.Windows.Forms")
from System.Windows.Forms import Application,Form,PaintEventArgs


class HelloWorldForm(Form):

    def __init__(self):
        self.Text = 'Hello World'
        self.Height =500
        self.Width = 500
        #button.Click += self.buttonPressed
        self.Paint += self.PaintEventHandler(self.Form1_Paint);
    def buttonPressed(self, sender, args):
        print 'The label *used to say* : %s' % self.label.Text
        #self.count += 1
        #self.label.Text = "You have clicked me %s times." % self.count
    def Form1_Paint(self,sender,e):
        g = e.Graphics;
        g.DrawString("This is a diagonal line drawn on the control"
        ,Font("Arial",10)
        ,Brushes.Blue,Point(30,30))
        g.DrawLine(Pens.Red,10,10,300,10);

form = HelloWorldForm()
Application.Run(form)