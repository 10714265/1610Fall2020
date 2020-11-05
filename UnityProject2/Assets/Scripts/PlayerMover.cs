using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour



{
    public float speed;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var lfinput = Input.GetAxis("Horizontal");
        var verticleInput = Input.GetAxis("Vertical");
        
        transform.Translate(new Vector3(lfinput, 0, verticleInput) * Time.deltaTime * speed);

        float jumpInput = Input.GetAxis("Jump");
        transform.Translate(new Vector3(0, jumpInput, 0) * Time.deltaTime * speed);
    }

    
}
