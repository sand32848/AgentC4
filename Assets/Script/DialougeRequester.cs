using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NodeCanvas.DialogueTrees;
using UnityEngine.Events;

public class DialougeRequester : MonoBehaviour
{
    [SerializeField] DialogueTreeController dialogueTreeController;
    [SerializeField] UnityEvent onDialougeEnd;
    [SerializeField] ProtraitCamScript protraitCam => GameObject.FindGameObjectWithTag("ProtraitCam").GetComponent<ProtraitCamScript>();
    [SerializeField] private bool onStart;

    private void Start()
    {
        if (onStart)
        {
            protraitCam.findNpc(dialogueTreeController.graph.primeNode.name);
        }
    }

    public void callDialouge(string name)
    {
        protraitCam.findNpc(name);
    }

    public void startDialouge()
    {
        dialogueTreeController.StartDialogue();
    }

    public void EndDialougeFunction()
    {
        onDialougeEnd.Invoke();
    }
}
