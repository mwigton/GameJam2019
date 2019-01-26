using UnityEngine;

namespace GameJam
{
	public class PauseScreen : MonoBehaviour
	{
		public GameObject pauseScreen;
		private bool m_paused = false;

		public void Update()
		{
			if(Input.GetKeyDown(KeyCode.Escape))
			{
				m_paused = !m_paused;
				SetPaused(m_paused);
			}
		}

		public void SetPaused(bool paused)
		{
			Debug.Log(paused);
			pauseScreen.SetActive(m_paused);
			Time.timeScale = m_paused ? 0 : 1;
			Cursor.lockState = m_paused ? CursorLockMode.None : CursorLockMode.Confined;
		}
	}
}
