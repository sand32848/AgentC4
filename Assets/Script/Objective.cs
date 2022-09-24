using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objective : MonoBehaviour
{
    public void WinCall()
    {
        PauseManager.isPauasable = false;
        InputManager.instance.playerControl.Disable();
        AudioManager.instance?.Play("Goal");
        ScreenCaller.callScreen(1);
        Cursor.lockState = CursorLockMode.None;
    }
}
