using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarradeVida : MonoBehaviour
{
    /*
Nombre completo: Lesley Samantha García Ramírez
Asignatura: Programación orientada a objetos
Nombre y número de ejercicio: VIDAS
Descripción de los que hace el script: La premisa es simple que cuando un enemigo te haga daño te quite vida 1 por 1, y cuando recolectes 1 corazon puedas recuperar vida.
*/

/*
El siguiente codigo se saco del canal de Youtube de BravePixelG y ayuda a poder hacer el codigo para daño y vida.
*/

    private Slider slider;
    
    private void Start() 
    {
        slider = GetComponent<Slider>();   
    }

    public void CambiarVidaMaxima(float vidaMaxima)
    {
        slider.maxValue = vidaMaxima;
    }

    public void CambiarVidaActual(float cantidadVida)
    {
        slider.value = cantidadVida;
    }

    public void InicializarBarraDeVida(float cantidadVida)
    {
        CambiarVidaMaxima(cantidadVida);
        CambiarVidaActual(cantidadVida);
    }

}
