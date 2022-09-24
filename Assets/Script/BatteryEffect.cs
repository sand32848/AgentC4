using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BatteryEffect : MonoBehaviour
{
    [SerializeField] private Color onColor, offColor;
    [SerializeField] private float intensity;
    private float _intensity;
    private Color currentColor, targetColor;
    public float Speed = 1, Offset;

    [SerializeField] private Renderer _renderer;
    private MaterialPropertyBlock _propBlock;

    void Awake()
    {
        _propBlock = new MaterialPropertyBlock();
    }

    private void Start()
    {
        _intensity = intensity;
        intensity = 1;
        targetColor = offColor;
    }

    void Update()
    {
        // Get the current value of the material properties in the renderer.
        _renderer.GetPropertyBlock(_propBlock);
        // Assign our new value.
        _propBlock.SetColor("_EmissionColor", targetColor * intensity);
        // Apply the edited values to the renderer.
        _renderer.SetPropertyBlock(_propBlock);
    }

    public void colorOn()
    {
        DOTween.To(() => targetColor, x => targetColor = x, onColor, Speed);

        intensity = _intensity;
    }

    public void colorOff()
    {
        DOTween.To(() => targetColor, x => targetColor = x, offColor, Speed);
        intensity = 1;
    }
}
