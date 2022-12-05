using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/*
Nombre completo: Lesley Samantha García Ramírez
Asignatura: Programación orientada a objetos
Nombre y número de ejercicio: 2 y 5 - colision de monedas
Descripción de los que hace el script: Hace la interacion del jugador con las monedas dandole puntaje cuando las recolecte
*/

/*
El siguiente codigo se saco del canal de Youtube de BravePixelG sobre como hacer que el personaje recolecte las monedas dandole una puntaje de ellas.
*/
public class Pun : MonoBehaviour
{
    private float puntos;
    private TextMeshProUGUI textMesh;

    private void Start() {
        textMesh = GetComponent<TextMeshProUGUI>();
    }

    // Suma los puntos de las monedas
    private void Update() {
        textMesh.text = puntos.ToString("0");
    }


    public void SumarPuntos(float puntosEntrada){
        puntos += puntosEntrada;
    }
    
}
