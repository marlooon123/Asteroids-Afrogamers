using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comportamento : MonoBehaviour
{
    public float aceleracao = 3.0f;
    public  float rotacao = 180.0f;
    public float velocidademaxima = 10.0f;
    public  Rigidbody2D jogadorRb;
    public Rigidbody2D prefabBala;

    public float velocidadeBala = 3.0f;
    void Start()
    {
        transform.position = new Vector3 (0.0f, 0.0f, 0.0f);
    }

    void  Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody2D bala = Instantiate (prefabBala,jogadorRb.position, Quaternion.identity);
            bala.velocity = transform.up * velocidadeBala;
        }
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
            jogadorRb.rotation += rotacao * Time.deltaTime;
         
        }
            
        if (Input.GetKey(KeyCode.D))
        {
            jogadorRb.rotation -= rotacao * Time.deltaTime;
        }   
        if (jogadorRb.velocity.magnitude > velocidademaxima)
        {
            jogadorRb.velocity = Vector2.ClampMagnitude (jogadorRb.velocity, velocidademaxima);
        }
    }

    void    OnTriggerEnter2D (Collider2D outro)
    {
        Destroy (gameObject);
        Debug.Log ("Failed!");

    }
}
