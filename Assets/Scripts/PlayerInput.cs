using System.Collections;
using UnityEngine;

namespace WildBall.Inputs
{
    [RequireComponent(typeof(PlayerMovement))]
    public class PlayerInput : MonoBehaviour
    {        
        private Vector3 movement;
        private PlayerMovement playerMovement;
        private bool canJump;

        private void Awake()
        {
            playerMovement = GetComponent<PlayerMovement>();
        }

        void Update()
        {
            float horizontal = Input.GetAxis(GlobalStringVars.HORIZONTAL_AXIS);
            float vertikcal = Input.GetAxis(GlobalStringVars.VERTICAL_AXIS);

            movement = new Vector3(vertikcal, 0, -horizontal).normalized;
        }

        private void FixedUpdate()
        {
            playerMovement.MoveCharacter(movement);

            if (Input.GetButton(GlobalStringVars.JUMP_BUTTON))
            {
                playerMovement.JumpCharacter();
                
            }
                
        }





    }
}