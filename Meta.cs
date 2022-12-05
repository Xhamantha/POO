using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
Nombre completo: Lesley Samantha García Ramírez
Asignatura: Programación orientada a objetos
Nombre y número de ejercicio: Meta y Creditos
Descripción de los que hace el script: Permite al jugador cambiar a los creditos .
*/

/*
El siguiente codigo se saco del canal de Youtube de Tutorial Dingo se programa el cambio de escena a los creditos cuando el jugador pasa la bandera
*/
public class Meta : MonoBehaviour
{
       private void OnTriggerEnter2D(Collider2D collision){
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Finish");
        }
    }
}
