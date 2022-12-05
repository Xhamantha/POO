using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Nombre completo: Lesley Samantha García Ramírez
Asignatura: Programación orientada a objetos
Nombre y número de ejercicio: 4 - colicion
Descripción de los que hace el script: Permite el jugador registre el daño y la curacion recibida por los items.
*/

/*
El siguiente codigo se saco del canal de Youtube de BravePixelG donde muestra como se da un maixo y un minimo de vida y donde se recibe el daño y curacion.
*/

public class CombateJugador : MonoBehaviour
{
  [SerializeField] int vida;
  [SerializeField] int maximoVida;
  [SerializeField] private BarradeVida barradeVida;

  private void Start() 
  {
    vida = maximoVida;
    barradeVida.InicializarBarraDeVida(vida);
  }

  public void TomarDaño(int daño)
  {
    vida -= daño;
    barradeVida.CambiarVidaActual(vida);
    if (vida <=0)
    {
        Destroy(gameObject);
    }
  }

  public void Curar(int curacion)
  {
    if ((vida+ curacion)> maximoVida)
    {
        vida = maximoVida;
        barradeVida.CambiarVidaActual(vida);
    }
    else 
    {
        vida += curacion;
    }
  }
}
