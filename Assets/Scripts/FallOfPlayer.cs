using UnityEngine;
using UnityEngine.SceneManagement;

public class FallOfPlayer : MonoBehaviour
{
    public GameObject Player;
    private LoadLevel loaderlevel;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }
}
