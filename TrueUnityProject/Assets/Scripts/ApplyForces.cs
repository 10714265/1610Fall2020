
using UnityEngine;

public class ApplyForces : MonoBehaviour
{

    public Rigidbody rBody;
    public float force = 100f;
    
    
    // Start is called before the first frame update
    void OnMouseDown()
    {
        rBody.AddForce(0, force, 0);
    }

   
}
