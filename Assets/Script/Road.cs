using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder;

public class Road : MonoBehaviour
{
    [SerializeField] private float speed;
    private float limit;
    private float currLimit = 0;
    private Vector3 originPos;

    private void Start()
    {
        originPos = transform.position;
      limit = transform.GetComponent<Renderer>().bounds.size.x;
    }

    void Update()
    {
        transform.position += transform.right  * Time.deltaTime * speed ;

        currLimit += Time.deltaTime * speed ;

        if (currLimit >= limit)
        {
            transform.position = originPos;
            currLimit = 0;
        }
    }
}
