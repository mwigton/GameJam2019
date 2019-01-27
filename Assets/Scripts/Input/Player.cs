using UnityEngine;

namespace GameJam
{
	public class Player : MonoBehaviour
	{
		private Vector3 m_startPosition;
		private Quaternion m_startRotation;

		public static Player Instance { get; private set; }

		private void Start()
		{
			Instance = this;
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

		public void SetLoaction(Transform target)
		{
			transform.position = target.position;
			transform.rotation = target.rotation;
		}

		public void SetScale(float scale)
		{
			transform.localScale = new Vector3(scale, scale, scale);
		}
	}
}
