using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelSelectButton : MonoBehaviour, IPointerClickHandler
{
    private TextMeshProUGUI levelText;
    private string levelName;
    private void Start()
    {
        string resultString = Regex.Match(transform.name, @"\d+").Value;

        levelName = "Level_" + resultString;

        levelText = GetComponentInChildren<TextMeshProUGUI>();
        levelText.text = resultString;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (Application.CanStreamedLevelBeLoaded(levelName))
        {
            SceneLoader.loadScene(levelName);
        }

        AudioManager.instance?.Play("Button");
    }

    // Start is called before the first frame update

}
