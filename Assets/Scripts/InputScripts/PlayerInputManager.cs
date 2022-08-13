using CharScripts;
using PickUpScripts;
using UnityEngine;

namespace InputScripts
{
    public class PlayerInputManager : MonoBehaviour
    {
        [SerializeField] private Camera cam;
        [SerializeField] private CharMoveController charMoveController;
        [SerializeField] private PickUpManager pickUpManager;

        private void Update()
        {
            if (Input.GetMouseButtonDown(0) && Physics.Raycast(cam.ScreenPointToRay(Input.mousePosition), out var hit))
            {
                if (hit.collider.CompareTag("PickUpable"))
                {
                    pickUpManager.PickedUpObject(hit.collider.gameObject);   
                }
                else
                {
                    charMoveController.MoveToDestionation(hit.point);
                }
            }
        }
    }
}