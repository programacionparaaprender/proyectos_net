# -*- coding: utf-8 -*-


class Observable:
    def __init__(self, id):
        self.id = id
        self.objetos = []

    def agregar(self, objeto):
        self.objetos.append(objeto)

    def getId(self):
        return self.id

    def actualizar(self, id):
        for objeto in self.objetos:
            if objeto.getId() == id:
                objeto.actualizar(self.id)