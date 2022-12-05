 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/*
Nombre completo: Lesley Samantha García Ramírez
Asignatura: Programación orientada a objetos
Nombre y número de ejercicio: Creditos
Descripción de los que hace el script: simpemente es la escena de creditos y cuando termina se vuelve al menu principal.
*/

/*
El siguiente codigo se saco del canal de Youtube de LuisCanary donde enseña como hacer creditos y retornar al menu.
*/

public class Creditos : MonoBehaviour
{
    
    void Start()
    {
        Invoke("WaitToEnd",30);
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
        }   
    }

    public void WaitToEnd()
    {
        SceneManager.LoadScene("Menu");
    }
}
