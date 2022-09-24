using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerDeath : MonoBehaviour
{
    public UnityEvent onDeathEvent;
    public void Die()
    {
        onDeathEvent.Invoke();

        ScreenCaller.callScreen(0);

        AudioManager.instance?.Play("Die");

        PauseManager.isPauasable = false;

        Cursor.lockState = CursorLockMode.None;
    }
}
