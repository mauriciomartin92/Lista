/*
 ============================================================================
 Name        : Lista.c
 Author      : 
 Version     :
 Copyright   : Your copyright notice
 Description : Hello World in C, Ansi-style
 ============================================================================
 */

#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include "Lista.h"

Nodo* CrearNodo(Persona* p){
	Nodo* nodo = (Nodo*) malloc(sizeof(Nodo));
	strcpy(nodo->p.nombre, p->nombre);
	nodo->p.prioridad = p->prioridad;
	nodo->siguiente = NULL;
	return nodo;
}

void DestruirNodo(Nodo* nodo){
	free(nodo);
}

void InsertarPrincipio(Lista* lista, Persona* p){
	Nodo* nodo = CrearNodo(p);
	nodo->siguiente = lista->cabeza;
	lista->cabeza = nodo;
}

void InsertarFinal(Lista* lista, Persona* p){
	Nodo* nodo = CrearNodo(p);

	if(lista->cabeza == NULL){
		lista->cabeza = nodo;
	} else {
				Nodo* puntero = lista->cabeza;
				while(puntero->siguiente){  //recorro la lista hasta el final y sale
				puntero = puntero->siguiente;
				}
				puntero->siguiente = nodo;
			}

}

void* BuscarPrioridadCero(Lista* lista, Persona* p){

	Nodo* puntero = lista->cabeza;
	while((puntero->p.prioridad != 0) && (puntero->siguiente != NULL )){
		puntero = puntero->siguiente;
	}

		return lista->cabeza->p.nombre;
}

void* MostrarLista(Lista*lista, Persona* p){
	Nodo* puntero = lista->cabeza;
	while(puntero->siguiente){
			printf("%s\n",puntero->p.nombre);
			printf("%c\n",puntero->p.prioridad);
		}
printf("Fin de lista");
	return 0;
}

int main(){

	Nodo* unNodo = NULL;

    unNodo = (Nodo*) malloc(sizeof(Nodo*));

	unNodo->siguiente = NULL;

	strcpy(unNodo->p.nombre, "Juan");
	unNodo->p.prioridad = 1;

	printf("%s\n",unNodo->p.nombre);
	printf("%d\n",unNodo->p.prioridad);

	free(unNodo);

	return EXIT_SUCCESS;
}
