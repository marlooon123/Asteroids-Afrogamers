using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroidecompportamento : MonoBehaviour
{ public Rigidbody2D asteroidRb;
public float velocidademaxima = 1.0f;
public  GameObject Bala;

    void Start()
    {
        Vector2 direcao = Random.insideUnitCircle;
        direcao = direcao * velocidademaxima; 
    asteroidRb.velocity = direcao;
    }
    void OnTriggerEnter2D (Collider2D Bala)
    {
        Destroy(gameObject);
        Destroy(Bala.gameObject);
    }
}


