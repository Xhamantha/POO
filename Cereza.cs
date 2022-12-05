using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Nombre completo: Lesley Samantha García Ramírez
Asignatura: Programación orientada a objetos
Nombre y número de ejercicio: 4 - Generar coliciones
Descripción de los que hace el script: Permite que el usuario pueda mover al personaje con las teclas
*/

/*
El siguiente codigo se saco del canal de Youtube de BravePixelG aqui se hace una colicion y destruccion de la manzana restaurandole la vida que perdio al jugador
*/

public class Cereza : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player")){
            other.GetComponent<CombateJugador>().Curar(2);
            Destroy(gameObject);
        }
    }
}
