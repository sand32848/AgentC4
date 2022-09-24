using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionManager : MonoBehaviour
{
    [SerializeField] private CanvasGroup transitionOverlay;
    // Start is called before the first frame update
    public static TransitionManager instance;

    private void Awake()
    {

        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
    }

    public void Transition(string sceneName)
    {
        Tween tween = transitionOverlay.DOFade(1, 0.2f).OnComplete(() => { SceneManager.LoadScene(sceneName); transitionOverlay.DOFade(0, 0.2f); });
    }

    //IEnumerator transition(string sceneName)
    //{

    //}
}
