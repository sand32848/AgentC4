using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.UI;

public class LevelProfileTrigger : MonoBehaviour, IPointerEnterHandler
{
    [SerializeField] private TextMeshProUGUI profileNameUI;
    [SerializeField] private TextMeshProUGUI profileDescriptionUI;
    [SerializeField] private Image profileImageUI;
    [SerializeField] private LevelProfileScriptable profileScriptable;
    public void OnPointerEnter(PointerEventData eventData)
    {
        profileNameUI.text = profileScriptable.name;
        profileDescriptionUI.text = profileScriptable.description;
        profileImageUI.sprite = profileScriptable.imagePorfile;
    }


}
