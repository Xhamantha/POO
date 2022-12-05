using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
Nombre completo: Lesley Samantha García Ramírez
Asignatura: Programación orientada a objetos
Nombre y número de ejercicio: 1 - Movimiento de personaje
Descripción de los que hace el script: Permite que el usuario pueda mover al personaje con las teclas
*/

/*
El siguiente codigo se saco del canal de Youtube de JLPM Sobre como hacer el movimiento de personaje de una
forma parecida pero diferente a la que vimos en clase.
*/
public class Move : MonoBehaviour
{
    public float Speed;
    public float JumpForce;
    public LayerMask capapiso;
    //acceder
    private Rigidbody2D Rigidbody2D;
    private BoxCollider2D boxCollider;
    private Animator Animator;
    private float Horizontal;
    public bool Hit = false;
    void Start() //Carga
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        Animator = GetComponent<Animator>();
        Rigidbody2D = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    void Update() //Ejecucion
    {
        Horizontal = Input.GetAxisRaw("Horizontal");

        if (Horizontal < 0.0f) transform.localScale = new Vector3 (-1.0f, 1.0f, 1.0f);
        else if (Horizontal > 0.0f) transform.localScale = new Vector3 (1.0f, 1.0f, 1.0f);

        Animator.SetBool("running", Horizontal != 0.0f);
//Salto
        if (Input.GetKeyDown(KeyCode.W)) 
        {
            Rigidbody2D.AddForce(Vector2.up * JumpForce,ForceMode2D.Impulse);
        }

        if (Hit)
        {
            Rigidbody2D.AddForce(Vector2.up * JumpForce,ForceMode2D.Impulse);
            Hit = false;
        }
    }

    //Constante
    private void FixedUpdate() {
        Rigidbody2D.velocity = new Vector2(Horizontal * Speed, Rigidbody2D.velocity.y);
    }
}
