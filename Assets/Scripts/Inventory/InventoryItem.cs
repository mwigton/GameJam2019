using UnityEngine;

namespace GameJam
{
	public class InventoryItem : MonoBehaviour
	{
		public GameObject model;
		public string itemName;

		private void OnTriggerEnter(Collider other)
		{
			if (other.tag != "Player") return;
			Inventory.Add(itemName);
			gameObject.SetActive(false);
		}
	}
}
