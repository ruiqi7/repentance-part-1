using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class NPCInteract : InteractableInterface
{
    [SerializeField] public string[] lines;
    [SerializeField] public GameObject dialogueBox;
    [SerializeField] public DialogueController dialogueController;
    private bool isTalking = false;
    public override void interact(){
        if(!isTalking){
            speak();
        }
    }

    public void speak(){
        dialogueBox.SetActive(true);
        isTalking = !isTalking;
        dialogueController.lines = lines;
        dialogueController.StartDialogue();
    }
    
    public void Update(){
        if(dialogueBox.activeInHierarchy == false){
            dialogueController.lines = null;
            isTalking = !isTalking;
        }
    }
}
