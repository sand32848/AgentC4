using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Sirenix.OdinInspector;

public class RotateTo : MonoBehaviour
{
    [SerializeField] private Vector3 rotateTo;
    [SerializeField] [ReadOnly] private Vector3 startPos;

    public void rotate()
    {
        transform.DORotate(rotateTo,0.5f);
    }

    [Button]
    public void recordPosFinal() 
    {
        rotateTo = transform.rotation.eulerAngles;
    }

    [Button]
    public void recordPosStart()
    {
        startPos = transform.rotation.eulerAngles;
    }

    [Button]
    public void resetPos()
    {
        transform.rotation = Quaternion.Euler(startPos);
    }
}
