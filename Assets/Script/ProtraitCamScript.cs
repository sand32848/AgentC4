using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using JetBrains.Annotations;

public class ProtraitCamScript : MonoBehaviour
{
   [SerializeField] private List<GameObject> npcList = new List<GameObject>();

    public void findNpc(string _name)
    {
        foreach(GameObject n in npcList)
        {
            n.SetActive(false);
        }

        GameObject npc = npcList.First(x => x.name == _name);

        if (npc)
        {
            npc.SetActive(true);
        }
    }
}
