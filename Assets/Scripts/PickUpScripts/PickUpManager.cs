using CharScripts;
using TigerForge;
using UnityEngine;

namespace PickUpScripts
{
    public class PickUpManager : MonoBehaviour
    {
        [SerializeField] private float minimumPickUpDistance;
        [SerializeField] private CharMoveController charMoveController;
        public void PickedUpObject(GameObject pickedUpGameObject)
        {
            if (!IsPlayerCloseEnoughToObject(pickedUpGameObject))
                return;
            
            pickedUpGameObject.SetActive(false);
            EventManager.EmitEvent("PickedUpCollectible");
        }

        private bool IsPlayerCloseEnoughToObject(GameObject pickedUpGameObject)
        {
            var currentPlayerPosition = charMoveController.ReturnCurrentPosition();
            var currentItemPosition = pickedUpGameObject.transform.position;
            print(Vector3.Distance(currentItemPosition, currentPlayerPosition));
            return Vector3.Distance(currentItemPosition, currentPlayerPosition) < minimumPickUpDistance;
        }
    }
}
