using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private int amount;
    [SerializeField] private Rigidbody coin;
    
    public void spawnCoin()
    {
        for(int i = 0; i < amount; i++)
        {
            Rigidbody rb = Instantiate(coin, transform.position, Quaternion.identity);

            rb.AddForce(new Vector3(Random.Range(-1f, 1f), 0, Random.Range(-1f, 1f)).normalized * 3f + Vector3.up * 10f, ForceMode.Impulse);
        }
    }
}
