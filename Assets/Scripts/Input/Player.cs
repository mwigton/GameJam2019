using UnityEngine;

namespace GameJam
{
	public class Player : MonoBehaviour
	{
		private void Start()
		{
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = false;
		}
	}
}
