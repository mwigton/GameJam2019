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
			m_paused = paused;
			pauseScreen.SetActive(paused);
			Time.timeScale = paused ? 0 : 1;
			Cursor.lockState = paused ? CursorLockMode.None : CursorLockMode.Confined;
			Cursor.visible = paused;
		}
	}
}
