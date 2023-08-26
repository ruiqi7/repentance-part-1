using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyController : MonoBehaviour
{
    private Color color;

    void Start()
    {
        color = GetComponent<Image>().color;
        color.a = 0.5f;
        GetComponent<Image>().color = color;
    }

    public void AdjustDifficulty()
    {
        foreach (Transform sibling in transform.parent)
        {
            Image siblingImage = sibling.gameObject.GetComponent<Image>();
            Color siblingColor = siblingImage.color;
            if (sibling.position.x <= transform.position.x)
            {
                siblingColor.a = 1.0f;
            }
            else
            {
                siblingColor.a = 0.5f;
            }
            siblingImage.color = siblingColor;
        }
    }
}
