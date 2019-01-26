using UnityEngine;
using DG.Tweening;

namespace GameJam
{
	public class CanvasGroupFader : MonoBehaviour
	{
		[SerializeField]
		private CanvasGroup m_canvasGroup;

		[SerializeField]
		private float m_duration;

		public void Show()
		{
			m_canvasGroup.DOFade(1, m_duration);
			m_canvasGroup.interactable = true;
			m_canvasGroup.blocksRaycasts = true;
		}

		public void Hide()
		{
			m_canvasGroup.DOFade(0, m_duration);
			m_canvasGroup.interactable = false;
			m_canvasGroup.blocksRaycasts = false;
		}
	}
}
