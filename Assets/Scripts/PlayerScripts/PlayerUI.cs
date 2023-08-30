using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerUI : MonoBehaviour
{

    [SerializeField] public TextMeshProUGUI promptText;
    void Start()
    {
        
    }

    public void updateText(string promptMsg){
        promptText.text = promptMsg; 
    }
}
