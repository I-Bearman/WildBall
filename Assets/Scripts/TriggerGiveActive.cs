using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerGiveActive : MonoBehaviour
{
    [SerializeField] Collider PlayerCollider;
    [SerializeField] GameObject ActivatingObject;

    private void OnTriggerEnter(Collider other)
    {
        if (other == PlayerCollider)
            ActivatingObject.SetActive(true);
    }
}
