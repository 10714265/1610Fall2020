using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class AddForceBehaviour : MonoBehaviour
{
    private Rigidbody rigid;
    public float holdTime = 3f;
    public int counter = 10;
    public Vector3 forces, forces2;
    public bool canRun;
    
    private IEnumerator Start()
    {
        rigid = GetComponent<Rigidbody>();
        while (counter > 0)
        {
            yield return new WaitForSeconds(holdTime);
            rigid.AddForce(forces);
            counter--;
        }
        
        while (canRun)
        {
            yield return new WaitForSeconds(holdTime);
            rigid.AddForce(forces2);
        }
    }

    
}
