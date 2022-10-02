using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LevelProfile", menuName = "ScriptableObjects/LevelProfile")]
public class LevelProfileScriptable : ScriptableObject
{
    public Sprite imagePorfile;
    public string profileName;
    [TextArea]
    public string description;
}
