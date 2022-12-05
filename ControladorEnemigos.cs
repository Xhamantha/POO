using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


/*
Nombre completo: Lesley Samantha García Ramírez
Asignatura: Programación orientada a objetos
Nombre y número de ejercicio: 3 - Spawn
Descripción de los que hace el script: Se spawnean los enemigos
*/

/*
El siguiente codigo se saco del canal de Youtube de BravePixelG aqui se muestra el punto de Spawneo del enemigo cada 10 segundos.
*/
public class ControladorEnemigos : MonoBehaviour
{
    private float minX, maxX, minY, maxY;
    [SerializeField] private Transform[] puntos;
    [SerializeField] private GameObject[] enemigos;
    [SerializeField] private float tiempoEnemigos;
    private float tiempoSiguienteEnemigo;

    private void Start() {
        maxX = puntos.Max(punto => punto.position.x);
        minX = puntos.Min(punto => punto.position.x);
        maxY = puntos.Max(punto => punto.position.y);
        minY = puntos.Min(punto => punto.position.y);
    }

    private void Update() {
        tiempoSiguienteEnemigo += Time.deltaTime;

        if (tiempoSiguienteEnemigo >= tiempoEnemigos){
            tiempoSiguienteEnemigo = 0;
            //Crear enemigo
            CrearEnemigo();
        }
    }

    private void CrearEnemigo(){
        int numeroEnemigo = Random.Range(0, enemigos.Length);
        Vector2 posicionAleatoria = new Vector2(Random.Range(minX,maxX),Random.Range(minY,maxY));

        Instantiate(enemigos[numeroEnemigo],posicionAleatoria, Quaternion.identity);
    }
}
