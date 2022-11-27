using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PulsingMat : MonoBehaviour
{
    private MaterialPropertyBlock materialProperty;
    private Renderer renderer;
    [SerializeField] private float PulseMin;
    [SerializeField] private float PulseMax;
    private float currentPulse = 0;
    private Color originMatColor;

    private bool allowPulse;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
        materialProperty = new MaterialPropertyBlock();

        materialProperty.SetColor("_Color", new Color(0.7490196f, 0.007843138f, 0, 1));
        renderer.SetPropertyBlock(materialProperty, 0);
    }

    private void Update()
    {
        materialProperty.SetColor("_Color", new Color(0.7490196f, 0.007843138f, 0,1) * currentPulse);
        renderer.SetPropertyBlock(materialProperty,0);
    }

    public void callPulse()
    {
        DOTween.To(() => currentPulse, x => currentPulse = x, 7, 1).SetLoops(-1,LoopType.Yoyo);
    }

    public void stopPulse()
    {

    }
}
