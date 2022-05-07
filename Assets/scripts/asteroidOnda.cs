using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidOnda : MonoBehaviour
{ 
    public int quantidadeAsteroides = 3;

    public Asteroidecompportamento prefabAsteroide;
    void Start()
    {
        for (int i = 0; i < quantidadeAsteroides; i++ )
        {
            float  x = Random.Range(-11.0f, 11.0f);
            float  y = Random.Range(-5.0f, 5.0f);
            Vector3 posicao = new Vector3 (x, y, 0.0f);
            Instantiate(prefabAsteroide, posicao, Quaternion.identity);
        }
    }
}
    

   
