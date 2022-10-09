using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using NodeCanvas.DialogueTrees;

public class DialougeBox : MonoBehaviour
{
    RectTransform rect => GetComponent<RectTransform>();
    [SerializeField] private DialogueTreeController dialogueTreeController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (InputManager.instance.playerControl.BaseControl.E.triggered)
        {
            MoveDialogueBox();
            dialogueTreeController.StartDialogue();
        }
    }

    public void MoveDialogueBox()
    {
        rect.DOLocalMoveX(0, 0.5f);
        //rect.DOMoveX(220, 0.5f);
    }
}
