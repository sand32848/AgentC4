using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Shaker : MonoBehaviour
{
   public void Shake()
    {
        transform.DOShakePosition(2,0.2f,20,90,false,false);
    }
}
