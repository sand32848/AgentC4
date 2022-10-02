using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class Speech : MonoBehaviour
{
    [SerializeField][TextArea] private string[] itemInfo;
    [SerializeField] private float textSpeed = 0.01f;
    [SerializeField] private float timeBetweenText;
    [SerializeField] private TextMeshPro itemInfoText;
    [SerializeField] private GameObject speechBubble;
    private int currentDsiplayingText = 0;
    public bool continuous;
    public bool oneTime;
    [SerializeField] private UnityEvent onSpeechFinish;

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

    public void playText(int index = 0)
    {
        
    }

    public void DisableText()
    {
        speechBubble.SetActive(false);
    }

    IEnumerator AnimateText()
    {
        for(int i =0; i< itemInfo[currentDsiplayingText].Length + 1; i++)
        {
            itemInfoText.text = itemInfo[currentDsiplayingText].Substring(0, i);
            yield return new WaitForSeconds(textSpeed);

            if(itemInfoText.text == itemInfo[currentDsiplayingText])
            {
                currentDsiplayingText += 1;
                yield return new WaitForSeconds(textSpeed);
            }
        }
    }
}
