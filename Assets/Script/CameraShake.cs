using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    [SerializeField] private float shakeForce;
    [SerializeField] private float duration;

    private Camera camera => Camera.main;

    public void shakeCamera()
    {
        camera.DOShakePosition(duration);
    }
}
