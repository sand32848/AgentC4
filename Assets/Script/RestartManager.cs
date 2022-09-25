using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartManager : MonoBehaviour
{
    void Update()
    {
        if (InputManager.instance.playerControl.BaseControl.R.triggered)
        {

            SceneLoader.loadCurrentScene();
        }
    }
}
