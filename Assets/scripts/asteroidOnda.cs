using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidOnda : MonoBehaviour
{ 
    public int quantidadeAsteroides = 3;
    public Asteroidecompportamento prefabAsteroide;
    void Start()
    {
        for (int i = 0; i < quantidadeAsteroides; i++ );
        {
            Vector3 posicao = new Vector3 (0.0f, 0.0f, 0.0f);
            Instantiate(prefabAsteroide, posicao, Quaternion.identity);
        }
    }
}
    

   
