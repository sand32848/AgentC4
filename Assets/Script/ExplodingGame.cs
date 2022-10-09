using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class ExplodingGame : MonoBehaviour
{
    [SerializeField] private float maxTime;
    [SerializeField] private float currentTime;
    [SerializeField] private UnityEvent onSuccess;
    [SerializeField] private TextMeshPro maxTimeText;
    [SerializeField] private TextMeshPro currentTimeText;
    [SerializeField] [ReadOnly] private bool start;
    [SerializeField][ReadOnly] private float score;
    private float targetScore;

    [SerializeField]private List<Explodable> explodablesList = new List<Explodable>();
    private Renderer[] render =>  GetComponentsInChildren<Renderer>();
    private Collider[] colliders => GetComponentsInChildren<Collider>();

    void Start()
    {
        Explodable[] explodes = GetComponentsInChildren<Explodable>();
        for(int i = 0; i < explodes.Length; i++)
        {
            explodablesList.Add(explodes[i]);
            explodes[i].explodeAction += updateScore;
        }

        targetScore = explodablesList.Count;
        maxTimeText.text = maxTime.ToString("0.00");
    }

    // Update is called once per frame
    void Update()
    {
        if (start)
        {
            currentTime += Time.deltaTime;
        }

        if(currentTime >= maxTime)
        {
            Reset();
        }

        currentTimeText.text = currentTime.ToString("0.00");
    }

    public void updateScore()
    {
        score += 1;
        start = true;

        if(score >= targetScore)
        {
            onSuccess.Invoke();

            if(currentTime < maxTime)
            {
                maxTime = currentTime;

                maxTimeText.text = maxTime.ToString("0.00");
            }

            Reset();
        }
    }

    public void Reset()
    {
        start = false;
        currentTime = 0;
        score = 0;

        foreach (Renderer r in render)
        {
            r.enabled = true;
        }

        foreach (Collider c in colliders)
        {
            c.enabled = true;
        }

    }
}
