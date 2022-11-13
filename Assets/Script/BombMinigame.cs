using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BombMinigame : MonoBehaviour
{
    [SerializeField] private float timeUntillExplode;
    [SerializeField] private TextMeshPro textMeshPro;
    [SerializeField] private ParticleSystem particleSystem;
    [SerializeField] private MeshRenderer meshRenderer;
    [SerializeField] private GameObject particle;
    public static Action onExplode;
    public static Action onDestroy;

    public bool trigger;

    private void Update()
    {
        if (trigger) return;

        timeUntillExplode -= Time.deltaTime;

        textMeshPro.text = timeUntillExplode.ToString("0");

        if(timeUntillExplode <= 0)
        {
            trigger = true;
            onExplode?.Invoke();
            particleSystem.Play();
            textMeshPro.enabled = false;
            meshRenderer.enabled = false;
            Destroy(gameObject,3);
            particle.SetActive(false);
        }
    }

    public void destrotBomb()
    {
        if (trigger) return;

        trigger = true;
        onDestroy?.Invoke();
        particleSystem.Play();
        textMeshPro.enabled = false;
        meshRenderer.enabled = false;
        Destroy(gameObject,3);
    }

}
