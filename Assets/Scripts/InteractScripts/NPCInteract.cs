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
        isTalking = !isTalking;
        dialogueController.lines = lines;
        dialogueBox.SetActive(true);
        dialogueController.StartDialogue();
    }
    
    public void Update(){
        if(dialogueController.isActiveAndEnabled == false){
            dialogueController.lines = null;
            dialogueBox.SetActive(false);
            isTalking = !isTalking;
        }
    }
}
