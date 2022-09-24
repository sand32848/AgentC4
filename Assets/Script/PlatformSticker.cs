using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSticker : MonoBehaviour
{

    private void OnTriggerExit(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            other.gameObject.transform.parent = null;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            other.gameObject.transform.parent = transform;
        }
    }

}
