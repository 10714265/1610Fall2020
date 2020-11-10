using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instan : MonoBehaviour
{
    public GameObject prefab;

    public float delay;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (true)
        {
            Instantiate(prefab);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
