using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explodable : MonoBehaviour
{
    [SerializeField] private bool pieces;

    [ShowIf("pieces")]
    [SerializeField] private UnfreezeFragment unfreezeFragment;
    
    public  void onExplode()
    {
        if (pieces)
        {

        }
        else
        {
            unfreezeFragment.Unfreeze();
        }
    }
}
