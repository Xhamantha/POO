using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Nombre completo: Lesley Samantha García Ramírez
Asignatura: Programación orientada a objetos
Nombre y número de ejercicio: 3 - Spawn
Descripción de los que hace el script: Se da movimiento al enemigo
*/

/*
El siguiente codigo se saco del canal de Youtube de BravePixelG solo se da un movimiento al enemigo.
*/

public class MivimientoEnemigo : MonoBehaviour
{
  private Rigidbody2D rbd2D;
  [SerializeField] private float velocidadMovimiento;
  [SerializeField] private float distancia;
  [SerializeField] private LayerMask queEsPiso;

  private void Start() {
    rbd2D = GetComponent <Rigidbody2D>();
  }

  private void Update() {
    rbd2D.velocity = new Vector2(velocidadMovimiento *transform.right.x, rbd2D.velocity.y);

    RaycastHit2D informacionPiso = Physics2D.Raycast(transform.position, transform.right, distancia, queEsPiso);

    if (informacionPiso)
    {
        Girar();
    }
  }

  private void Girar(){
    transform.eulerAngles = new Vector3(0, transform.eulerAngles.y + 180, 0);
  }

  private void OnDrawGizmosSelected() {
    Gizmos.color = Color.red;
    Gizmos.DrawLine(transform.position, transform.position + transform.right * distancia);
  }
}

