using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class U10PS_DissolveOverTime : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    private SkinnedMeshRenderer skinnedMesh;
    private bool allow = false;
    public float speed = .5f;

    private void OnEnable()
    {
        DissolveAll.dissolveAll += allowDissolve;
    }

    private void OnDisable()
    {
        DissolveAll.dissolveAll -= allowDissolve;
    }

    private void Start(){
        meshRenderer = this.GetComponent<MeshRenderer>();
        skinnedMesh = transform.GetComponent<SkinnedMeshRenderer>();
    }

    private float t = 0.0f;
    private void Update(){

        if (!allow) return;

        if (meshRenderer) meshRenderer.enabled = true;
        if (skinnedMesh) skinnedMesh.enabled = false;

        Material[] mats = meshRenderer.materials;
        t += Time.deltaTime;

        if (mats[0].GetFloat("_Cutoff") >= 0.98f) return;

       

        foreach(Material m in mats)
        {
            m.SetFloat("_Cutoff", Mathf.Sin(t * speed));
        }



        
        // Unity does not allow meshRenderer.materials[0]...
        meshRenderer.materials = mats;
    }

    public void allowDissolve()
    {
        allow = true;
    }
}
