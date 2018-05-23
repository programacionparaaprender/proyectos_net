# -*- coding: utf-8 -*-
import clr
clr.AddReference("System.Drawing")
clr.AddReference("System.Windows.Forms")
from System.Drawing import Point
from System.Windows.Forms import Button
from Observable import Observable


class Boton(Button):
    def __init__(self, id, x, y, w, h, text):
        super()
        self.Text = text
        self.Location = Point(x, y)
        self.Height = w
        self.Width = h
        self.observable = Observable(id)
        self.Click += self.buttonPressed

    def getId(self):
        return self.observable.getId()

    def agregar(self, objeto):
        self.observable.agregar(objeto)

    def buttonPressed(self, sender, args):
        self.Text = 'X'
        self.observable.actualizar(1)

