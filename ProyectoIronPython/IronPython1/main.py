import clr
clr.AddReference('System.Windows.Forms')

from System.Windows.Forms import Application, Form, Label

form = Form(Text="Hello World Form")
label = Label(Text="Hello World!")

form.Controls.Add(label)

Application.Run(form)