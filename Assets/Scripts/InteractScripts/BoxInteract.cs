using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;


public class BoxInteract : InteractableInterface
{
    
    public override void interact(){
        this.transform.position += Vector3.forward * 1f;
        Debug.Log("Interactred");
    }
}

