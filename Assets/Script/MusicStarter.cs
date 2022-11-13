using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicStarter : MonoBehaviour
{
    [SerializeField] private string musicName;

    private void Start()
    {
        AudioManager.instance.PlayBGM(musicName);
    }
}
