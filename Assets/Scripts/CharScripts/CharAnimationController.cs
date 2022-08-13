using TigerForge;
using UnityEngine;

namespace CharScripts
{
   public class CharAnimationController : MonoBehaviour
   {
      [SerializeField] private Animator charAnimator;

      private const string walkAnimation = "Walk";
      private const string idleAnimation = "Idle + MODEL";
      private void Start()
      {
         EventManager.StartListening("CharMovementStarted", OnCharMovementStarted);
         EventManager.StartListening("CharMovementStopped", OnCharMovementStopped);
      }

      private void OnCharMovementStarted()
      {
         charAnimator.Play(walkAnimation);
      }
   
      private void OnCharMovementStopped()
      {
         charAnimator.Play(idleAnimation);
      }
   }
}
