using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    [SerializeField] private float shakeMultiplier;
    [SerializeField] private float duration;

    private Camera camera => Camera.main;

    private void Update()
    {
   
    }

    public void shakeCamera(float force, int virbratioRate)
    {
        camera.DOShakePosition(duration,force * shakeMultiplier,virbratioRate);
    }
}
