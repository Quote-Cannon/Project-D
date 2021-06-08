using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOcean : MonoBehaviour
{
    Vector3 Vec;  
    // Start is called before the first frame update  
    void Start()  
    {  
          
    }  
  
    // Update is called once per frame  
    void Update()  
    {  
  
        Vec = transform.localPosition;  
        Vec.y += Input.GetAxis("UpDown") * Time.deltaTime * 2;   
        transform.localPosition = Vec;  
    }  
}