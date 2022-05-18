using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ColetarItem : MonoBehaviour
{
    int pontuacao;
    public Text pontuacaoUI;

    private void Start()

    {
        pontuacao = 0;
        pontuacaoUI.text = "Placar:" +
        pontuacao.ToString();
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Colisão aconteceu");
        if (other.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            pontuacao++;
        }
    }
}
