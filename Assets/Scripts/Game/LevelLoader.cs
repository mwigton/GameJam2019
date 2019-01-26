using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
	public void Load(string level)
	{
		SceneManager.LoadSceneAsync(level, LoadSceneMode.Additive);
	}
}
