using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ImposterGps : MonoBehaviour
{
    private bool notClear;
    [SerializeField] TextMeshPro gpsText;

    // Update is called once per frame
    void Update()
    {
        if (notClear)
        {
            gpsText.text = "Imposter \nnearby";
            gpsText.color = Color.red;
        }
        else
        {
            gpsText.text = "Clear";
            gpsText.color = Color.green;
        }

    }

    public void SetNotClear(bool _clear)
    {
        notClear = _clear;
    }
}
