using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comportamento : MonoBehaviour
{
    public float aceleracao = 3.0f;
    public  Rigidbody2D jogadorRb;
    public  float rotacao = 180.0f;
    public float velocidademaxima = 10.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 direcao = transform.up * aceleracao;
            jogadorRb.AddForce(direcao, ForceMode2D.Force);
        }
        if (Input.GetKey(KeyCode.A))
        {
            jogadorRb.rotation = rotacao + (rotacao * Time.deltaTime);
         
        }
            
            if (Input.GetKey(KeyCode.D))
        {
            jogadorRb.rotation = jogadorRb.rotation - (rotacao * Time.deltaTime);
        }   
        if (jogadorRb.velocity.magnitude > velocidademaxima)
        {
            jogadorRb.velocity = Vector2.ClampMagnitude (jogadorRb.velocity, velocidademaxima);
        }
    }
}
