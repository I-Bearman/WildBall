using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerDamage : MonoBehaviour
{
    [SerializeField] Image HealthLevel;
    [SerializeField] ParticleSystem PlayerPartSys;

    void Update()
    {
        if (HealthLevel.fillAmount <= 0)
        {
            StartCoroutine(Death());
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 9)
            HealthLevel.fillAmount -= 0.2f;
        if (collision.gameObject.layer == 10)
            HealthLevel.fillAmount -= 1f;
    }

    private IEnumerator Death()
    {
        PlayerPartSys.Play();
        gameObject.GetComponent<Rigidbody>().isKinematic = true;
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        

    }

}
