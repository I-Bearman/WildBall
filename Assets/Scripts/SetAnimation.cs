using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class SetAnimation : MonoBehaviour
{
    private Animator Anim;

    private void Awake()
    {
        Anim = transform.GetComponent<Animator>();
    }


    public void SetNextAnimation()
    {
        Anim.SetInteger("SetInt", Random.Range(0, 3));
    }
}
