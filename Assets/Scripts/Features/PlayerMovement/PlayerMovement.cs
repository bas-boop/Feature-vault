using UnityEngine;

namespace Baz_geluk9.Feature_vault.Feature.PlayerMovement
{
    public abstract class PlayerMovement : MonoBehaviour
    {
        [Header("Usage")]
        [SerializeField] private bool useDeadZone;
        [SerializeField] private bool useJump;
        [SerializeField] private bool useAccelerate;
        [SerializeField] private bool useDecelerate;

        protected Vector2 p_moveInput;
        
        private bool _canMove = true;

        private void FixedUpdate()
        {
            if (_canMove)
                Move();
        }

        public void SetMoveInput(Vector2 input)
        {
            p_moveInput = input;
        }
        
        public abstract void Jump();
        protected abstract void Move();
    }
}