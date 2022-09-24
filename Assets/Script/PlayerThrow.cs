using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerThrow : MonoBehaviour
{
    [SerializeField] private Bomb c4;
    [SerializeField] private float throwForce;
    private List<Bomb> bombList = new List<Bomb>();

    // Update is called once per frame
    void Update()
    {
        if (InputManager.instance.playerControl.BaseControl.LeftClick.triggered)
        {
           Bomb c = Instantiate(c4,transform.position,Quaternion.identity);
            c.addForce(Camera.main.transform.forward * throwForce);
            bombList.Add(c);
        }

        if (InputManager.instance.playerControl.BaseControl.RightClick.triggered)
        {
            for(int i = 0;  i < bombList.Count; i++)
            {
                bombList[i].explode();
            }
        }
    }
}
