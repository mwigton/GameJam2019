using UnityEngine;

namespace GameJam
{
	public class Player : MonoBehaviour
	{
		private Vector3 m_startPosition;
		private Quaternion m_startRotation;

		private void Start()
		{
			m_startRotation = transform.rotation;
			m_startPosition = transform.position;
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = false;
		}

		public void Respawn()
		{
			transform.position = m_startPosition;
			transform.rotation = m_startRotation;
			PauseScreen.Instance.SetPaused(false);
		}
	}
}
