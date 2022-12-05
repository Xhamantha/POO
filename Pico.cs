using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Nombre completo: Lesley Samantha García Ramírez
Asignatura: Programación orientada a objetos
Nombre y número de ejercicio: 4 y 5 - Colicion
Descripción de los que hace el script: Hace que el personaje reciba un daño de 5 puntos al colicionar con este.
*/

/*
El siguiente codigo se saco del canal de Youtube de BravePixelG sobre como hacer el que cuando el personaje este parado en el pico le quite vida.
*/

public class Pico : MonoBehaviour
{
    [SerializeField] private float tiempoEntreDaño;
    private float tiempoSiguienteDaño;
   private void OnTriggerEnter2D(Collider2D other) 
   {
    if (other.CompareTag("Player"))
    {
        tiempoSiguienteDaño -= Time.deltaTime;
        if (tiempoSiguienteDaño <= 0)
        {
            other.GetComponent<CombateJugador>().TomarDaño(1);
            tiempoSiguienteDaño = tiempoEntreDaño;
        }
    }
   }
}
