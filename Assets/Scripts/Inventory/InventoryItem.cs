using UnityEngine;

namespace GameJam
{
	public class InventoryItem : MonoBehaviour
	{
		public GameObject model;
		public string itemName;
		public AudioSource audioSource;
		public GameObject playerModelItem;

		public bool Collected { get; private set; }

		private void OnTriggerEnter(Collider other)
		{
			if (Collected) return;
			if (other.tag != "Player") return;
			Debug.Log("Item collected: " + gameObject.name, this);
			audioSource.Play();
			Collected = true;
			Inventory.Add(itemName);
			model.SetActive(false);
			playerModelItem.SetActive(true);
		}
	}
}
