using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Speech : MonoBehaviour
{
    [SerializeField][TextArea] private string[] itemInfo;
    [SerializeField] private float textSpeed = 0.01f;
    [SerializeField] private TextMeshPro itemInfoText;
    [SerializeField] private GameObject speechBubble;
    private int currentDsiplayingText = 0;
    public bool oneTime;

    private GameObject player => GameObject.FindGameObjectWithTag("Player");

    private void Update()
    {
        Vector3 playerPos = new Vector3(player.transform.position.x, speechBubble.transform.position.y, player.transform.position.z);
        speechBubble.transform.LookAt(playerPos);
    }

    public void ActivateText()
    {
        if (oneTime) return;

        speechBubble.SetActive(true);
        StartCoroutine(AnimateText());

        oneTime = true;
    }

    IEnumerator AnimateText()
    {
        for(int i =0; i< itemInfo[currentDsiplayingText].Length + 1; i++)
        {
            itemInfoText.text = itemInfo[currentDsiplayingText].Substring(0, i);
            yield return new WaitForSeconds(textSpeed);
        }
    }
}
