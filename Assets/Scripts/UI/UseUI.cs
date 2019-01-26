using UnityEngine;

namespace GameJam
{
	public class UseUI : MonoBehaviour
	{
		[SerializeField]
		private GameObject m_usePrompt;

		public static UseUI Instance { get; private set; }

		private void Start()
		{
			Instance = this;
		}

		public void Show()
		{
			m_usePrompt.SetActive(true);
		}

		public void Hide()
		{
			m_usePrompt.SetActive(false);
		}
	}
}
