using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResultCanvas : MonoBehaviour
{
    [SerializeField] private GameObject lostScreen;
    [SerializeField] private GameObject winScreen;
    [SerializeField] private GameObject resultCanvas;

    private void Start()
    {
        ScreenCaller.callScreen += callResult;
    }

    private void OnDisable()
    {
        ScreenCaller.callScreen -= callResult;
    }
    public void callResult(int result)
    {
        resultCanvas.SetActive(true);

        if (result == 1)
        {
            winScreen.SetActive(true);
        }
        else
        {
            lostScreen.SetActive(true); 
        }
    }
}
