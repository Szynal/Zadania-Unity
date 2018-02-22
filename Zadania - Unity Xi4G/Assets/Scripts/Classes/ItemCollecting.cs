using System.Collections.Generic;
using UnityEngine;


namespace Assets.Scripts
{
    class ItemCollecting : MonoBehaviour
    {
        public List<GameObject> ItemsTypes;
        public int[] CollectedItems;

        private void Start()
        {
            ItemsTypes = new List<GameObject>();
            ItemsTypes = FindObjectOfType<ItemGenerator>()._ItemList;
            CollectedItems = new int[ItemsTypes.Count];
        }
    }
}
