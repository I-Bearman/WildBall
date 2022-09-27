using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    public void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }
    public void OnSelectLevel(int NumLevel)
    {
        SceneManager.LoadScene(NumLevel);
        Time.timeScale = 1;
    }

}
