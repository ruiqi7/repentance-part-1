using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> pages;
    [SerializeField] private bool allowPause = false;
    [SerializeField] private int pausePageIndex = 0;

    private bool isPaused = false;

    private void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            TogglePause();
        }
    }

    private void TogglePause()
    {
        if (allowPause)
        {
            if (isPaused)
            {
                pages[pausePageIndex].gameObject.SetActive(false);
                Time.timeScale = 1.0f;
                isPaused = false;
            }
            else
            {
                ChangePage(pausePageIndex);
                Time.timeScale = 0.0f;
                isPaused = true;
            }
        }      
    }

    public void ChangePage(int pageIndex)
    {
        foreach (GameObject page in pages)
        {
            page.gameObject.SetActive(false);
        }
        pages[pageIndex].gameObject.SetActive(true);
    }
}
