using UnityEngine;

namespace Baz_geluk9.Feature_vault.Feature.PlayerMovement
{
    public sealed class InputParser : MonoBehaviour
    {
        [SerializeField] private PlayerMovement playerMovement;

        private const string HORIZONTAL = "Horizontal";
        private const string VERTICAL = "Vertical";
        
        private void Update()
        {
            float x = Input.GetAxisRaw(HORIZONTAL);
            float y = Input.GetAxisRaw(VERTICAL);
            
            playerMovement.SetMoveInput(new Vector2(x,y));
            
            if (Input.GetButtonDown("Jump"))
                playerMovement.Jump();
        }
    }
}
