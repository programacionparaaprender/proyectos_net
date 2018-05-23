import clr
clr.AddReference("System.Drawing")
clr.AddReference("System.Windows.Forms")
from System.Windows.Forms import Application, Form
from System.Windows.Forms import MessageBox
from Boton import Boton
from Vieja import Vieja
from Inteligencia import Inteligencia


#ocho posibles combinaciones x, +, |, -
#1 queda en tres combinaciones
#5 queda en cuatro combinaciones
#4 queda en dos combinaciones
class HelloWorldForm(Form):
    def __init__(self):
        self.id = 1
        self.Text = 'Hello World'
        self.Height = 200
        self.Width = 200
        self.botongroup = []
        self.generarboton(1, 0, 0, 50, 50, "1")
        self.generarboton(2, 50, 0, 50, 50, "2")
        self.generarboton(3, 100, 0, 50, 50, "3")
        self.generarboton(4, 0, 50, 50, 50, "4")
        self.generarboton(5, 50, 50, 50, 50, "5")
        self.generarboton(6, 100, 50, 50, 50, "6")
        self.generarboton(7, 0, 100, 50, 50, "7")
        self.generarboton(8, 50, 100, 50, 50, "8")
        self.generarboton(9, 100, 100, 50, 50, "9")
        self.vieja = Vieja()
        self.inteligencia = Inteligencia(2, self.vieja)
        self.inteligencia.agregar(self)
        self.turno = 1

    def generarboton(self, id, x, y, w, h, text):
        button = Boton(id, x, y, w, h, text)
        button.agregar(self)
        self.botongroup.append(button)
        self.Controls.Add(button)

    def actualizar(self, id):
        if (self.turno is 1):
            MessageBox.Show("self.label.Text " + str(id))
        self.vieja.actualizar(1, id)
        self.inteligencia.jugar()

    def getId(self):
        return self.id


form = HelloWorldForm()
Application.Run(form)