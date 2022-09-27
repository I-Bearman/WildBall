using System.Collections;
using UnityEngine;

namespace WildBall.Inputs
{
    //[RequireComponent(typeof(Rigidbody))]

    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField, Range(0, 10)] private float speed = 2.0f;
        private Rigidbody playerRigitbody;
        private bool canJump;

        private void Awake()
        {
            playerRigitbody = GetComponent<Rigidbody>();
        }

        public void MoveCharacter(Vector3 movement)
        {
            playerRigitbody.AddForce(movement * speed);
        }

        public void JumpCharacter()
        {
            if (canJump)
                playerRigitbody.AddForce(0, 1, 0, ForceMode.Impulse);
            
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.layer == 8)
                canJump = true;
        }

        private void OnCollisionExit(Collision collision)
        {
            if (collision.gameObject.layer == 8) 
                canJump = false;
        }



#if UNITY_EDITOR
        [ContextMenu("Reset values")]
        public void ResetValues()
        {
            speed = 2;
        }
#endif
    }
}