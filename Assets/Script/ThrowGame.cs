using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SocialPlatforms.Impl;

public class ThrowGame : MonoBehaviour
{
    [SerializeField] private UnityEvent onSuccess;
    [SerializeField] private UnityEvent onGameFinish;
    private List<Thrower> throwers = new List<Thrower>();
    [SerializeField] private int destroyTarget;
    [SerializeField] private GameObject[] healthIcon;

    private bool start;

    private float throwCooldown;

    private bool alreadySuccess;

    private int destroyCount;
    private int currentLife = 3;

    private void OnEnable()
    {
        BombMinigame.onExplode += reduceLife;
        BombMinigame.onDestroy += increaseScore;
    }

    private void OnDisable()
    {
        BombMinigame.onExplode -= reduceLife;
        BombMinigame.onDestroy -= increaseScore;
    }

    private void Start()
    {
        throwers = GetComponentsInChildren<Thrower>().ToList();
    }

    private void Update()
    {
        if (!start) return;

        throwCooldown -= Time.deltaTime;

        if(throwCooldown <= 0)
        {
            throwers[UnityEngine.Random.Range(0, throwers.Count)].Throw();

            throwCooldown = UnityEngine.Random.Range(1f, 2f);
        }
    }

    public void startGame()
    {
        start = true;
    }

    public void reduceLife()
    {
        if (!start) return;
        currentLife -= 1;

        healthIcon[currentLife].SetActive(false);

        if (currentLife <= 0)
        {
            currentLife = 3;
            start = false;
            throwCooldown = 1;

            onGameFinish.Invoke();

            foreach(GameObject g in healthIcon)
            {
                g.SetActive(true);
            }
        }
    }

    public void increaseScore()
    {
        if (!start) return;

        destroyCount += 1;

        if (destroyCount >= destroyTarget)
        {
            onSuccess.Invoke();
            onGameFinish.Invoke();

            currentLife = 3;
            start = false;
            throwCooldown = 1;

            foreach(GameObject g in GameObject.FindGameObjectsWithTag("ThrowTarget"))
            {
                g.GetComponent<BombMinigame>().destrotBomb();
            }
        }
    }
}
