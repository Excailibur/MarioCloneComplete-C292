using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] public int coinValue = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
           
            UIManager.instance.UpdateCoinText(coinValue);
            Destroy(gameObject);
            //gameObject.SetActive(false);
        }
    }
}
