using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGradient : MonoBehaviour
{
    // Start is called before the first frame update
    
    Material normal;
    public Material Heightmap;
    Terrain terrain;
    bool changed;

    void Start()
    {
        terrain = gameObject.GetComponent<Terrain>();
        normal = terrain.materialTemplate;
        changed = false;
    }

    public void Changecolour()
    {
        if(!changed){
            terrain.materialTemplate = Heightmap;
            changed = true;
        }
        else
        {
            terrain.materialTemplate = normal;
            changed = false;
        }
                
    } 
    // Update is called once per frame
    void Update()
    {
        
    }
}
