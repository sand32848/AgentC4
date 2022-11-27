using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicStarter : MonoBehaviour
{
    [SerializeField] private string musicName;
    private bool onStart = false;

    private void Start()
    {

        AudioManager.instance.PlayBGM(musicName);
    }

    public void playStartMusic(string SongName)
    {
        AudioManager.instance.continuePlaying(SongName);
    }

    public void disableMusic()
    {
        AudioManager.instance.StopPlay("MainTheme");
    }
}
