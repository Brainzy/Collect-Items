using DG.Tweening;
using UnityEngine;

namespace UIScripts
{
   public static class UIAnimation
   {
      private static float animationDuration = 0.2f;
      public static void AnimateButton(Transform button)
      {
         button.DOScale(new Vector3(0.8f, 0.8f, 0.8f), animationDuration).OnComplete(() => button.DOScale(Vector3.one, animationDuration));
      }
   }
}
