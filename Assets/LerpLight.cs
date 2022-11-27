using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LerpLight : MonoBehaviour
{
    [SerializeField] private Light light;
    [SerializeField] private float range;

    private void Update()
    {
        light.range = range;
    }

    public void DoLerp()
    {
        DOTween.To(() => range, x => range = x, 350, 5).OnComplete(() => DOTween.To(() => range, x => range = x, 0, 2));
    }
}
