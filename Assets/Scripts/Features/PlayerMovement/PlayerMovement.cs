using System;
using Baz_geluk9.Feature_vault.Extensions;
using UnityEngine;

namespace Baz_geluk9.Feature_vault.Feature.PlayerMovement
{
    public abstract class PlayerMovement : MonoBehaviour
    {
        //todo: all setting's should be in a scriptable object
        [Header("Usage")]
        [SerializeField] private bool useDeadZone;
        [SerializeField] protected bool useJump;
        [SerializeField] private bool useAccelerate;
        [SerializeField] private bool useDecelerate;

        [Header("Settings")]
        [SerializeField, Range(0, 1)] private float deadZone;
        
        [Header("Attributes")]
        [SerializeField, Range(1, 25)] protected float p_walkingSpeed;
        
        protected Vector2 p_moveInput;

        public bool CanMove { get; private set; } = true;

        private void FixedUpdate()
        {
            if (CanMove)
                Walk();
        }

        public void SetMoveInput(Vector2 input)
        {
            Vector2 targetInput = input;
            
            if (useDeadZone)
                targetInput = SetMoveInputWithDeadZone(targetInput);
            
            p_moveInput = targetInput;
        }
        
        public abstract void Jump();
        protected abstract void Walk();

        private Vector2 SetMoveInputWithDeadZone(Vector2 input)
        {
            input.x = Mathf.Abs(input.x) < deadZone 
                ? 0 
                : Mathf.Sign(input.x);
            
            input.y = Mathf.Abs(input.y) < deadZone 
                ? 0 
                : Mathf.Sign(input.y);

            return input;
        }
    }
}