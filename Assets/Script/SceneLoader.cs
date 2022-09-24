using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Text.RegularExpressions;
using UnityEditor;

public class SceneLoader : Singleton<SceneLoader>
{
	public static Action<string> transition;

    public static void loadNextScene()
	{
		string resultString = Regex.Match(SceneManager.GetSceneAt(0).name, @"\d+").Value;
	
		string levelString = "Level_" + (int.Parse(resultString) + 1).ToString();

		if (Application.CanStreamedLevelBeLoaded(levelString))
		{
            loadScene(levelString);
		}
	}

	public static void loadCurrentScene()
	{
		loadScene(SceneManager.GetSceneAt(0).name);
	}

	public static void loadScene(string sceneName)
	{
		PauseManager.isPauasable = true;
		if (Application.CanStreamedLevelBeLoaded(sceneName))
		{
			Time.timeScale = 1;
			if (TransitionManager.instance == null) SceneManager.LoadScene(sceneName);
			else TransitionManager.instance.Transition(sceneName);
			//SceneManager.LoadScene(sceneName);
			//transition?.Invoke(sceneName);
		}
	}
}
