using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torre : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject prefabDoMissil;

    void Start()
    {

        Instantiate (prefabDoMissil);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
