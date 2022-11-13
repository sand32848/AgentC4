using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CoinSpender : MonoBehaviour
{
    [SerializeField] private int coinAmount;
    private CoinCollector coinCollector => GameObject.FindGameObjectWithTag("CoinCollector").transform.GetComponent<CoinCollector>();
    [SerializeField] private UnityEvent spendCoinFunction;

    public void consumeCoin()
    {
        if (coinCollector.GetCurrentCoint() < coinAmount) return;

        coinCollector.SpendCoin(coinAmount);
        spendCoinFunction.Invoke();
    }
}
