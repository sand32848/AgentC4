using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
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
    [SerializeField] private GameObject vasePrefab;
    private float targetScore;

    [SerializeField] private List<GameObject> oldVaseList = new List<GameObject>();
    private TimeAttackTarget[] timeAttack => GetComponentsInChildren<TimeAttackTarget>();
    private List<Vector3> vector3s = new List<Vector3>();

    void Start()
    {
        for(int i = 0; i < transform.childCount; i++)
        {
            vector3s.Add(transform.GetChild(i).transform.position);
        }

        targetScore = vector3s.Count;
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
    }

    public void startGame()
    {
        if (start) return;

        start = true;

        foreach (GameObject oldVase in oldVaseList)
        {
            Destroy(oldVase);
        }

        oldVaseList.Clear();

        foreach (Vector3 v in vector3s)
        {
           GameObject vase = Instantiate(vasePrefab, v, Quaternion.identity);
            oldVaseList.Add(vase);
            vase.GetComponent<Explodable>().explodeAction += updateScore;
        }

        foreach (TimeAttackTarget p in timeAttack)
        {
            p._particleSystem.Play();
        }
    }
}
