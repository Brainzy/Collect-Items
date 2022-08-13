using TigerForge;
using TMPro;
using UnityEngine;

namespace UIScripts
{
    public class CollectibleCounter : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI collectedText;
        private int collectedAmount = 0;

        private void Start()
        {
            EventManager.StartListening("PickedUpCollectible", OnPickedUpCollectible);
        }

        private void OnPickedUpCollectible()
        {
            collectedAmount++;
            collectedText.SetText(collectedAmount.ToString());
        }
        
    }
}
