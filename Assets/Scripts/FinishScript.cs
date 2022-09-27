using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishScript : MonoBehaviour
{
    public GameObject Player;
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject == Player)
            if (SceneManager.GetActiveScene().buildIndex < 6)
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            else
                SceneManager.LoadScene(0);




    }
}  
