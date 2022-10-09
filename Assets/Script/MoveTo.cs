using DG.Tweening;
using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTo : MonoBehaviour
{
    [SerializeField] private List<Vector3> positionList = new List<Vector3>();
    [ReadOnly] public Vector3 startPosition;
    [ReadOnly] public Vector3 endPosition;


    public  void moveToEndPos()
    {
        transform.DOMove(endPosition,0.5f);
    }

    public void moveToStartPos()
    {
        transform.DOMove(startPosition, 0.5f);
    }

    [Button]
    public void RecordStartPosition()
    {
        startPosition = transform.position;
    }

    [Button]
    public void RecordDestination()
    {
        endPosition = transform.position;
    }

    [Button]
    public void ResetPosition()
    {
        transform.position = startPosition;
    }
}
