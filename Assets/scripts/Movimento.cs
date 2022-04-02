using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    public float velocidade;
    public GameObject prefabMeteoro;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Tecla de Espaço");
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + new Vector3(0.0f, 5.0f * Time.deltaTime, 0.0f);
            //transform.position += new Vector3(10.0f, 0.0f, 0.0f);
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position + new Vector3(0.0f, -5.0f * Time.deltaTime, 0.0f);
            //transform.position += new Vector3(10.0f, 0.0f, 0.0f);
        }
         if (Input.GetKeyDown(KeyCode.P))
        {
            Instantiate (prefabMeteoro,new Vector3(3.0f,3.0f, 0.0f), Quaternion.identity);
        }
       
        
    }
}
