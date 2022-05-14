using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroidecompportamento : MonoBehaviour
{ 
    public static System.Action EventoAsteroideDestruido = null;
    public Rigidbody2D asteroidRb;
    public float velocidademaxima = 1.0f;
    public  GameObject Bala;
    public int quantidadefragmentos = 2;
    public Asteroidecompportamento prefabAsteroideMenor;

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
        /*Lacos de Repeticao*/
        /*While loop or for Loop*/

        int i; //Inicializacao da Variavel --> Contador
        
        i = 0; //Passagem de valor variavel --> Contador
        while(i<quantidadefragmentos)
        {
            Instantiate(prefabAsteroideMenor, asteroidRb.position, Quaternion.identity);
            i = i + 1; //i++;
        }

       if (EventoAsteroideDestruido != null)
     {
         EventoAsteroideDestruido();
     }
     }

}