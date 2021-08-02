using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OS : MonoBehaviour
{
    public GameObject USERLocate;
    public GameObject LOOK;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LOOK = USERLocate;
    }
}
