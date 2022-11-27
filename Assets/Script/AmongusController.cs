using ParadoxNotion;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class AmongusController : MonoBehaviour
{
    [SerializeField] private bool Imposter;
    GameObject player;  
    ImposterGps imposterGps; 

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        imposterGps = player.GetComponent<ImposterGps>();
       
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (!Imposter) return;
        if (collision.transform.tag != "Player") return;
        imposterGps.SetNotClear(true);
    }

    private void OnCollisionExit(Collision collision)
    {

        if (!Imposter) return;
        if (collision.transform.tag != "Player") return;
        imposterGps.SetNotClear(false);
    }

    private void OnTriggerEnter(Collider other)
    {

        if (!Imposter) return;
        if (other.tag != "Player") return;
        imposterGps.SetNotClear(true);

    }

    private void OnTriggerExit(Collider other)
    {
        if (!Imposter) return;
        if (other.tag != "Player") return;
        imposterGps.SetNotClear(false);
    }

    public void ForceClear()
    {
        imposterGps.SetNotClear(false);
    }

}
