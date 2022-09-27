using UnityEngine;
using UnityEngine.UI;

public class UseBridge : MonoBehaviour
{
    [SerializeField] GameObject Player;
    [SerializeField] Rigidbody Bridge;
    private Collider PlayerCollider;
    [SerializeField] Text HintText;
    [SerializeField] Animation UseSwitch;

    void Start()
    {
        PlayerCollider = Player.GetComponent<Collider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == PlayerCollider)
        {
            HintText.text = "Press 'E' to lower the handle";
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.E))
        {
            UseSwitch.Play();
            Bridge.isKinematic = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other == PlayerCollider)
        {
            HintText.text = "";
        }
    }
}
