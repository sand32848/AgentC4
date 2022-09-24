using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelSelector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            int x = i;
            transform.GetChild(i).GetComponentInChildren<TextMeshProUGUI>().text = (i+1).ToString();
            Button _button = transform.GetChild(i).GetComponent<Button>();
            _button.onClick.AddListener(() => SceneLoader.loadScene("Level_" + (x+1).ToString()));
        }
    }
}
