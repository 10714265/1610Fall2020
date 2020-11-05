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
        float lfinput = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(lfinput, 0, 0) * Time.deltaTime * speed);

        float verticleInput = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(0, 0, verticleInput) * Time.deltaTime * speed);

        float jumpInput = Input.GetAxis("Jump");
        transform.Translate(new Vector3(0, jumpInput, 0) * Time.deltaTime * speed);
    }
}
