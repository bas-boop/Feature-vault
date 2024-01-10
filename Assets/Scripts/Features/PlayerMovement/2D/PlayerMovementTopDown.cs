using UnityEngine;

namespace Baz_geluk9.Feature_vault.Feature.PlayerMovement
{
    [RequireComponent(typeof(Rigidbody2D))]
    public sealed class PlayerMovementTopDown : PlayerMovement
    {
        private Rigidbody2D _rigidbody;

        private void Awake() => _rigidbody = GetComponent<Rigidbody2D>();

        public override void Jump() { }

        protected override void Walk()
        {
            _rigidbody.velocity = p_moveInput * p_walkingSpeed;
        }
    }
}