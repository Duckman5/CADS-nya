using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W : MonoBehaviour
{
    [SerializeField]
    GameObject winscram; 
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.childCount == 0)
        {
            winscram.transform.position = new Vector3(0.13f, 0.17f, -5); 
        }
    }
}
