using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinManager : MonoBehaviour
{
    [SerializeField] private GameObject winUI;
    private void OnEnable()
    {
        Target.onTargetComplete += activateWin;
    }

    private void OnDisable()
    {
        Target.onTargetComplete -= activateWin;
    }

    public void activateWin()
    {
        winUI.SetActive(true);
        InputManager.instance.playerControl.BaseControl.Disable();
        Cursor.lockState = CursorLockMode.None;
    }
}
