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
    private ProtraitCamScript protraitCam => GameObject.FindGameObjectWithTag("ProtraitCam").GetComponent <ProtraitCamScript >();
    [field : SerializeField] public LevelProfileScriptable profileScriptable { get; private set; }
    public void OnPointerEnter(PointerEventData eventData)
    {
        protraitCam.findNpc(profileScriptable.name);
        profileNameUI.text = profileScriptable.profileName;
        profileDescriptionUI.text = profileScriptable.description;
    }


}
