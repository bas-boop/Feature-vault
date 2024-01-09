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
            
        }

        protected override void Move()
        {
            Vector2 target = _rigidbody.velocity;
            target.SetX(p_moveInput.x);
            _rigidbody.velocity = target;
        }
    }
}