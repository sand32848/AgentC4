using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    [SerializeField] private int currentCoin;
    [SerializeField] private TextMeshProUGUI coinText;
    // Start is called before the first frame update

    private void OnDisable()
    {
        Coin.onCoinCollect -= IncreaseCoin;

    }

    private void OnEnable()
    {
        Coin.onCoinCollect += IncreaseCoin;
    }

    public  void IncreaseCoin()
    {
        currentCoin += 1;
        coinText.text = currentCoin.ToString();
    }

    public int GetCurrentCoint()
    {
        return currentCoin;
    }

    public void SpendCoin(int cost)
    {
        currentCoin -= cost;
        coinText.text = currentCoin.ToString();
    }
}
