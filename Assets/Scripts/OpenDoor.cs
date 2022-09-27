using UnityEngine;
using UnityEngine.UI;

public class OpenDoor : MonoBehaviour
{
    [SerializeField] GameObject Player, Door;
    private Collider PlayerCollider;
    [SerializeField] Text HintText;

    // Start is called before the first frame update
    void Start()
    {
        PlayerCollider = Player.GetComponent<Collider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == PlayerCollider)
        {
            HintText.text = "Press 'E' to open the door";
        }

    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.E))
            if (other == PlayerCollider)
            {
                Rigidbody DoorRigBody = Door.GetComponent<Rigidbody>();
                DoorRigBody.isKinematic = false;
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
