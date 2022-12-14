using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelController : MonoBehaviour
{
    public bool isPaused;

    public GameObject pausePanel;
    public GameObject mainShopPanel;
    public GameObject levelsPanel;


    void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab) && !isPaused)
        {
            pausePanel.SetActive(true);
            TogglePause();
        }
    }

    

    public void TogglePause()
    {
        isPaused = !isPaused;
        if (isPaused)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;

            pausePanel.SetActive(false);
            mainShopPanel.SetActive(false);
            levelsPanel.SetActive(false);
        }
    }

    public void PausePanel()
    {
        isPaused = true;
        pausePanel.SetActive(true);
    }
    public void MainShop()
    {
        isPaused = true;
        mainShopPanel.SetActive(true);
    }
    public void Levels()
    {
        isPaused = true;
        levelsPanel.SetActive(true);
    }
}
