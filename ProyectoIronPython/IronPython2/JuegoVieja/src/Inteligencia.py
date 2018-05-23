# -*- coding: utf-8 -*-
from Vieja import Vieja
from Observable import Observable
#1 queda en tres combinaciones
#2 queda en tres combinaciones
#3 queda en tres combinaciones
#4 queda en tres combinaciones
#5 queda en cuatro combinaciones
#6 queda en tres combinaciones
#7 queda en tres combinaciones
#8 queda en tres combinaciones
#9 queda en tres combinaciones


class Inteligencia(Observable):
    def __init__(self, id, vieja=None):
        Observable.__init__(self, id)
        self.vieja = None
        if vieja is not None:
            self.vieja = vieja
        else:
            self.vieja = Vieja()

    def jugar(self):
        print("turno computadora")
        print(self.vieja.getMatriz())

    def verificacion_1(self):
        matriz = self.vieja.getMatriz()
        cond1 = matriz[0][0] is 1
        cond2 = matriz[0][1] is 1
        cond3 = matriz[0][2] is 1



