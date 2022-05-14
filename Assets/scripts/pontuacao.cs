using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class pontuacao : MonoBehaviour
{
   public TMP_Text textoPontos;
   public int pontos;

    void Awake()
    {
        textoPontos.text = "";
        Asteroidecompportamento.EventoAsteroideDestruido += AsteroideDestruido;  
    }

    void OnDestroy()
    {
        Asteroidecompportamento.EventoAsteroideDestruido -= AsteroideDestruido;       
    }

    void AsteroideDestruido()
    {
        Debug.Log("Asteroide Destruido!");  
    }
    void   AtualizacaoTextoPontos ()
    {
        textoPontos.text = pontos.ToString();
    }
}
