using TigerForge;
using UnityEngine;
using UnityEngine.AI;

namespace CharScripts
{
    public class CharMoveController : MonoBehaviour
    {
        [SerializeField] private NavMeshAgent navMeshAgent;
            
        private bool isMoving;

        public void MoveToDestionation(Vector3 destination)
        {
            navMeshAgent.destination = destination;
            EventManager.EmitEvent("CharMovementStarted");
        }

        public Vector3 ReturnCurrentPosition()
        {
            return transform.position;
        }

        private void LateUpdate()
        {
            if (navMeshAgent.remainingDistance > 0.1f)
            {
                isMoving = true;
            }
            if (navMeshAgent.remainingDistance <= 0.1f && isMoving )
            {
                EventManager.EmitEvent("CharMovementStopped");
                isMoving = false;
            }
        }
    }
}
