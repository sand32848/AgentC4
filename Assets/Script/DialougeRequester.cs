using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NodeCanvas.DialogueTrees;
using UnityEngine.Events;

public class DialougeRequester : MonoBehaviour
{
    [SerializeField] DialogueTreeController dialogueTreeController;
    [SerializeField] UnityEvent onDialougeEnd;

    public void startDialouge()
    {
        dialogueTreeController.StartDialogue();
    }

    public void EndDialougeFunction()
    {
        onDialougeEnd.Invoke();
    }
}
