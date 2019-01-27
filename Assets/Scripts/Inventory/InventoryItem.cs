using UnityEngine;
using System.Collections.Generic;
using System.Collections;

namespace GameJam
{
	public class InventoryItem : MonoBehaviour
	{
		public GameObject model;
		public string itemName;
		public AudioSource audioSource;
		public GameObject playerModelItem;
		public GameObject playerModelItem1;
		public GameObject prompt;

		public bool Collected { get; private set; }

		protected virtual void OnTrigger() { }

		private void OnTriggerEnter(Collider other)
		{
			if (Collected) return;
			if (other.tag != "Player") return;
			Debug.Log("Item collected: " + gameObject.name, this);
			audioSource.Play();
			Collected = true;
			Inventory.Add(itemName);
			model.SetActive(false);
			if(playerModelItem != null) playerModelItem.SetActive(true);
			if(playerModelItem1 != null) playerModelItem1.SetActive(true);
			OnTrigger();
			StartCoroutine(ShowPrompt());
		}

		private IEnumerator ShowPrompt()
		{
			if (prompt == null) yield break;
			prompt.SetActive(true);
			yield return new WaitForSeconds(5);
			prompt.SetActive(false);
		}
	}
}
