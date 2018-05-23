# -*- coding: utf-8 -*-
import numpy as np

# X es 1
# O es 2


class Vieja:
    def __init__(self):
        self.matriz = np.zeros([3, 3], int)

    def getMatriz(self):
        return self.matriz

    def actualizar(self, entidad, numero):
        #usuario = 1
        #computadora = 2
        temp = entidad
        if numero is 1:
            self.matriz[0][0] = temp
        elif numero is 2:
            self.matriz[0][1] = temp
        elif numero is 3:
            self.matriz[0][2] = temp
        elif numero is 4:
            self.matriz[1][0] = temp
        elif numero is 5:
            self.matriz[1][1] = temp
        elif numero is 6:
            self.matriz[1][2] = temp
        elif numero is 7:
            self.matriz[2][0] = temp
        elif numero is 8:
            self.matriz[2][1] = temp
        elif numero is 9:
            self.matriz[2][2] = temp