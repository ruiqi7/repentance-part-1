using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> pages;
    [SerializeField] private bool allowPause = false;
    [SerializeField] private int pausePageIndex = 0;

    private bool isPaused = false;
    private CameraController cameraController;

    void Start()
    {
        cameraController = Camera.main.GetComponent<CameraController>();
    }

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
                Cursor.lockState = CursorLockMode.Locked;
                cameraController.enabled = true;
                Time.timeScale = 1.0f;
                isPaused = false;
            }
            else
            {
                ChangePage(pausePageIndex);
                Cursor.lockState = CursorLockMode.None;
                cameraController.enabled = false;
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
