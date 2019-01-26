using UnityEngine;

namespace GameJam
{
	public class InventoryItem : MonoBehaviour
	{
		public GameObject model;
		public string itemName;

		public bool Collected { get; private set; }

		private void OnTriggerEnter(Collider other)
		{
			if (other.tag != "Player") return;
			Debug.Log("Item collected: " + gameObject.name, this);
			Collected = true;
			Inventory.Add(itemName);
			gameObject.SetActive(false);
		}
	}
}
