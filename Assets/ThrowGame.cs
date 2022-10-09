using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class ThrowGame : MonoBehaviour
{
    [SerializeField] private UnityEvent onSuccess;
    [SerializeField] private TextMeshPro playerLiveText;
    [SerializeField] private List<Thrower> throwers = new List<Thrower>();
    [SerializeField] private int throwTarget;
    private bool start;

    private float throwCooldown;

    private bool alreadySuccess;

    private int throwAmount;
    private int currentLife = 4;

    private void Start()
    {
        throwers = GetComponentsInChildren<Thrower>().ToList();
    }

    private void Update()
    {
        throwCooldown -= Time.deltaTime;

        if(throwCooldown <= 0)
        {
            throwers[Random.Range(0, throwers.Count)].Throw();

            throwCooldown = Random.Range(1f, 2f);

            throwAmount += 1;
        }

        if (throwAmount  >= throwTarget)
        {
            currentLife = 4;
            start = false;
            throwAmount = 0;
            throwCooldown = 1;
        }

        if(currentLife <= 0)
        {
            currentLife = 4;
            start = false;
            throwAmount = 0;
            throwCooldown = 1;
        }
    }

    public void startGame()
    {
        start = true;
    }
}
