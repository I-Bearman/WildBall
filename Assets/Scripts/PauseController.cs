using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseController : MonoBehaviour
{
    public GameObject PauseScreen;
    private bool paused;
    public void PauseGame()
    {
        if (paused)
        {
            Time.timeScale = 1;
            PauseScreen.SetActive(false);
        }
        else
        {
            Time.timeScale = 0;
            PauseScreen.SetActive(true);
        }
        paused = !paused;
    }
}
