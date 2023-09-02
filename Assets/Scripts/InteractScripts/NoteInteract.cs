using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;



public class NoteInteract : InteractableInterface
{
    [SerializeField] private GameObject noteCanvas;
    [SerializeField] private TMP_Text noteTextArea;
    [SerializeField] [TextArea] private string noteText;
    [SerializeField] CameraController camera;
    private bool isOpen = false;
    public override void interact(){
        if(!isOpen){ShowNote();}    
    }
    public void ShowNote(){
        noteTextArea.text = noteText;
        noteCanvas.SetActive(true);
        camera.enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        isOpen = true;
    }
    public void CloseNote(){
        noteTextArea.text = string.Empty;
        noteCanvas.SetActive(false);
        camera.enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        isOpen = false;
    }
    private void Update(){
        if (Input.GetKeyUp(KeyCode.Escape)) {
            CloseNote();
        }
    }
}
