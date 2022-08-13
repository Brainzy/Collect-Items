using UIScripts;
using UnityEngine;
using UnityEngine.AI;

namespace CharScripts
{
    public class CharSpeedController : MonoBehaviour
    {
        [SerializeField] private NavMeshAgent navMeshAgent;
        [SerializeField] private float minSpeed;
        [SerializeField] private float maxSpeed;
        [SerializeField] private float speedStep;
        public void IncreaseSpeedButtonPressed(Transform button)
        {
            var currentSpeed = navMeshAgent.speed;
            navMeshAgent.speed = Mathf.Clamp(currentSpeed+speedStep, minSpeed, maxSpeed);
            UIAnimation.AnimateButton(button);
        }

        public void DecreaseSpeedButtonPressed(Transform button)
        {
            var currentSpeed = navMeshAgent.speed;
            navMeshAgent.speed = Mathf.Clamp(currentSpeed-speedStep, minSpeed, maxSpeed);
            UIAnimation.AnimateButton(button);
        }
        
    }
}
