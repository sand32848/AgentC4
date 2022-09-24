using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour
{
    public static bool isPaused { get; private set; }
    public static bool isPauasable = true;
    [SerializeField] private GameObject pauseScreen;

    private void Update()
    {
        if (!isPauasable) return;
        if (InputManager.instance.playerControl.BaseControl.Escape.triggered)
        {
            isPaused = !isPaused;

            if (isPaused)
            {
                Time.timeScale = 0;
                pauseScreen.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
            }
            else
            {
                Time.timeScale = 1;
                pauseScreen.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
    }

    public void unPause()
    {
        isPaused = false;
        Time.timeScale = 1;
        pauseScreen.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }
}
