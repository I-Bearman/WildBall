using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HindBridge : MonoBehaviour
{
    [SerializeField] Collider PlayerCollider;
    [SerializeField] Text HintText;
    private void OnTriggerEnter(Collider other)
    {
        if (other == PlayerCollider)
        {
            HintText.text = "You need to lower the handle of the switch";
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
