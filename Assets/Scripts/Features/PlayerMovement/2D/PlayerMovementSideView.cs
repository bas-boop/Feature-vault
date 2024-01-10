using Baz_geluk9.Feature_vault.Extensions;
using UnityEngine;

namespace Baz_geluk9.Feature_vault.Feature.PlayerMovement
{
    [RequireComponent(typeof(Rigidbody2D))]
    public sealed class PlayerMovementSideView : PlayerMovement
    {
        private Rigidbody2D _rigidbody;
        
        private void Awake() => _rigidbody = GetComponent<Rigidbody2D>();
        
        public override void Jump()
        {
            if(!useJump)
                return;
            
            _rigidbody.AddForce(new Vector2(0, 10));
        }

        protected override void Walk()
        {
            Vector2 target = _rigidbody.velocity;
            target.SetX(p_moveInput.x * p_walkingSpeed);
            _rigidbody.velocity = target;
        }
    }
}