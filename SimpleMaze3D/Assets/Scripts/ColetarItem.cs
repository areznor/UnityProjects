using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColetarItem : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Colis�o aconteceu");
        if (other.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
        }
    }
}
