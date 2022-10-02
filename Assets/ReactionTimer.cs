using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class ReactionTimer : MonoBehaviour
{
    [SerializeField][ReadOnly]private float currentTime;
    [SerializeField] private float scoreTime;
    [SerializeField] private UnityEvent onSuccess;
    [SerializeField] private TextMeshPro scoreTimeText;
    [SerializeField] private TextMeshPro playerTimeText;
    [SerializeField] private Light lightMarker;
    private Coroutine timerCoroutine;
    private bool isRunning;
    private bool start;
    private bool timeMarker;

    private bool alreadySuccess;

    private void Start()
    {

        scoreTimeText.text =  scoreTime.ToString("0.00");
    }

    private void Update()
    {
        if (start)
        {
            currentTime += Time.deltaTime;
        }   
    }

    public void activateTimer()
    {
        if (isRunning) return;
        isRunning = true;
        timerCoroutine = StartCoroutine(StartTimer());
    }

    IEnumerator StartTimer()
    {
        yield return new WaitForSeconds(Random.Range(3f, 6f));

        currentTime = 0;
        start = true;
        timeMarker = true;
        lightMarker.color = Color.green;

    }

    public void resultCheck()
    {
        print("D");
        if (timeMarker)
        {
            playerTimeText.text = currentTime.ToString("0.00");

            if (currentTime < scoreTime)
            {
                scoreTime = currentTime;

                scoreTimeText.text = scoreTime.ToString("0.00");

                if (!alreadySuccess)
                {
                    onSuccess.Invoke();
                    alreadySuccess = true;
                }
            }
        }
        else
        {
            playerTimeText.text = "Too early";

            StopCoroutine(timerCoroutine);
        }

        timeMarker = false;
        isRunning = false;
        start = false;
        currentTime = 0;
        lightMarker.color = Color.red;
    }


}
