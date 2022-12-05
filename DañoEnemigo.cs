using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DañoEnemigo : MonoBehaviour
{
    private Move Player;

    void Start() 
    {
        Player = FindObjectOfType<Move>();
    }
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if(collision.gameObject.tag == "Player")
        {
           Player.Hit = true;
           Destroy(gameObject);
        }    
    }
}
