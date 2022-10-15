using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.Linq;

public class PlayerThrow : MonoBehaviour
{
    [SerializeField] private Bomb c4;
    [SerializeField] private float throwForce;
    private List<Bomb> bombList = new List<Bomb>();
    [SerializeField] private float throwCooldown;
    [SerializeField] private float detonateCooldown;
    private float _throwCooldown;
    private float _detonateCooldown;

    private void Start()
    {
        _throwCooldown = throwCooldown;
        _detonateCooldown = detonateCooldown;
    }

    // Update is called once per frame
    void Update()
    {
        throwCooldown -= Time.deltaTime;
        detonateCooldown -= Time.deltaTime;

        if (InputManager.instance.playerControl.BaseControl.LeftClick.triggered)
        {
            if (throwCooldown > 0) return;
            Bomb c = Instantiate(c4,Camera.main.transform.position,  Quaternion.Euler(Random.Range(0,90), Random.Range(0, 90), Random.Range(0, 90)));
            c.addForce(Camera.main.transform.forward * throwForce);
            bombList.Add(c);

            throwCooldown = _throwCooldown;
            detonateCooldown = _detonateCooldown;
        }

        if (InputManager.instance.playerControl.BaseControl.RightClick.triggered)
        {
            if (detonateCooldown > 0) return;


            for(int i = 0;  i < bombList.Count; i++)
            {
                if (bombList[i])
                {
                    bombList[i].StartCoroutine("explode");
                }

            }

            bombList.Clear();
        }
    }
}
