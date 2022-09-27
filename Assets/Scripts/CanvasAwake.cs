using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CanvasAwake : MonoBehaviour
{
    public Text NumOfLevelText; 
    private void Awake()
    {
        NumOfLevelText.text = "Level " + SceneManager.GetActiveScene().buildIndex.ToString();
    }

    
}
