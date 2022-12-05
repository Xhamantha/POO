using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
Nombre completo: Lesley Samantha García Ramírez
Asignatura: Programación orientada a objetos
Nombre y número de ejercicio: 4 - colision de monedas
Descripción de los que hace el script: Hace la interacion del jugador con las monedas dandole puntaje cuando las recolecte
*/

/*
El siguiente codigo se saco del canal de Youtube de RocketJam sobre como hacer que el personaje recolecte las monedas dandole una puntaje de ellas.
*/

public class Coins : MonoBehaviour
{

    [SerializeField] private float cantidadPuntos;
    [SerializeField] private Pun puntaje;
        private void OnTriggerEnter2D(Collider2D collision) 
    {
        // Destruye las monedas cuando el jugador las toma
        if (collision.CompareTag("Player"))
        {
            puntaje.SumarPuntos(cantidadPuntos);
            Destroy(this.gameObject); 
        }
    }    
}
