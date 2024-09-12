using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    private void Update()
    {
        ReloadScene();
    }
    public void UpdateCoinText(int coin)
    {
        coinsCollected += coin;
        coinText.text = "x " + coinsCollected;
    }

    public void ReloadScene()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
