using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody))]
public class AddForceBehaviour : MonoBehaviour
{
    private Rigidbody rigid;
    public float holdTime = 3f;
    public int counter = 3;
    public Vector3 forces, forces2;
    public Text countdown;
    public bool canRun;
    
    private IEnumerator Start()
    {
        rigid = GetComponent<Rigidbody>();
        while (counter > 0)
        {
            yield return new WaitForSeconds(holdTime);
            rigid.AddForce(forces);
            counter--;
            print(counter);
        }
        print("GO");
        while (canRun)
        {
            yield return new WaitForSeconds(holdTime);
            rigid.AddForce(forces2);
            
        }
    }

    
}
