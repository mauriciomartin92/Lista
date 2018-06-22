/*
 * Lista.h
 *
 *  Created on: 21 jun. 2018
 *      Author: utnso
 */

#ifndef LISTA_H_
#define LISTA_H_

#include<stdio.h>
#include <stdlib.h>
#include <string.h>

typedef struct Persona{
	char* nombre;
	int prioridad;
}Persona;


typedef struct Nodo{
	Persona p;
	struct Nodo*siguiente;
}Nodo;


typedef struct Lista{
	Nodo* cabeza;
}Lista;

Nodo* CrearNodo(Persona* p);

void DestruirNodo(Nodo* nodo);

void InsertarPrincipio(Lista* lista, Persona* p);

void InsertarFinal(Lista* lista, Persona* p);

void* BuscarPrioridadCero(Lista* lista, Persona* p);

void* MostrarLista(Lista*lista, Persona* p);

#endif /* LISTA_H_ */
