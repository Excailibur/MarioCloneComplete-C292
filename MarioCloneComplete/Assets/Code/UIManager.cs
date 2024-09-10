using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    [SerializeField] private TextMeshProUGUI coinText;
    private int coinsCollected = 0;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        coinText = GameObject.Find("CoinText").GetComponent<TextMeshProUGUI>();
    }

    public void UpdateCoinText(int coin)
    {
        coinsCollected += coin;
        coinText.text = "x " + coinsCollected;
    }

}
