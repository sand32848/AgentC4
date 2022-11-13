using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public static Action onCoinCollect;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            onCoinCollect?.Invoke();
            Destroy(gameObject);
        }
    }


}
