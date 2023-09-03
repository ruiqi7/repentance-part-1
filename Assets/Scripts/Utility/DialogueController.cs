using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogueController : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI textBox;
    [SerializeField] public string[] lines;
    [SerializeField] public float textSpeed = 0.1f;
    private int lineIndex;
    
    /*public void Start(){
        textBox.text = String.Empty;
        StartDialogue();
    }*/

    public void StartDialogue(){
        textBox.text = String.Empty;
        lineIndex = 0;
        StartCoroutine(TypeLine());
        
    }
    public void NextLine(){
        if(lineIndex+1 < lines.Length){
            textBox.text = String.Empty;
            lineIndex += 1;
            StartCoroutine(TypeLine());
        } else{
            gameObject.SetActive(false);
        }
    }
    IEnumerator TypeLine(){
        foreach(char c in lines[lineIndex].ToCharArray()){
            textBox.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
        NextLine();
    }
}
