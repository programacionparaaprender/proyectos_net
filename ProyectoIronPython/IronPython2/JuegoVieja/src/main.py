import clr
clr.AddReference("System.Drawing")
clr.AddReference("System.Windows.Forms")
from System.Drawing import (Pens, Color, Font, FontStyle, Point, Brushes)
from System.Drawing import Size, Pen
from System.Drawing.Drawing2D import DashStyle
from System.Windows.Forms import Application, Form, PaintEventArgs, Button
from System.Windows.Forms import MessageBox, Label


class HelloWorldForm(Form):
    def __init__(self):
        self.Text = 'Hello World'
        self.Height = 500
        self.Width = 500
        button = Button()
        button.Text = "Click Me"
        button.Location = Point(50, 100)
        button.Click += self.buttonPressed
        self.Controls.Add(button)

        self.label = Label()
        self.label.Text = "Please Click Me"
        self.label.Location = Point(50, 50)
        self.label.Height = 30
        self.label.Width = 200
        self.Controls.Add(self.label)
        #self.Paint += self.PaintEventHandler(self.Form1_Paint)
        self.Paint += self.Form1_Paint
        self.CenterToScreen()

    def OnPaint(self, sender, e):
        g = e.Graphics

        pen = Pen(Color.Black, 1)
        pen.DashStyle = DashStyle.Dot

        g.DrawLine(pen, 20, 40, 250, 40)

        pen.DashStyle = DashStyle.DashDot
        g.DrawLine(pen, 20, 80, 250, 80)

        pen.DashStyle = DashStyle.Dash
        g.DrawLine(pen, 20, 120, 250, 120)

        pen.DashStyle = DashStyle.DashDotDot
        g.DrawLine(pen, 20, 160, 250, 160)

        pen.DashPattern = (6, 8, 1, 1, 1, 1, 1, 1)
        g.DrawLine(pen, 20, 200, 250, 200)

        pen.Dispose()
        g.Dispose()

    def buttonPressed(self, sender, args):
        #print ('The label *used to say* :')
        MessageBox.Show(self.label.Text)
        #self.count += 1
        #self.label.Text = "You have clicked me %s times." % self.count

    def Form1_Paint(self, sender, e):
        g = e.Graphics
        texto = "This is a diagonal line drawn on the control"
        g.DrawString(texto, Point(30, 30))
        g.DrawLine(Pens.Red, 10, 10, 300, 10)


form = HelloWorldForm()
Application.Run(form)