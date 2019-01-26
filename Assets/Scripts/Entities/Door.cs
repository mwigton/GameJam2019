using UnityEngine;

namespace GameJam
{
	public class Door : MonoBehaviour
	{
		public string item;
		public GameObject door;

		public void CheckOpen()
		{
			if(Inventory.HasItem(item))
			{
				door.SetActive(false);
			}
		}
	}
}
