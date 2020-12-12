using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMove1 : MonoBehaviour
{
    private Rigidbody rigbod;
    public float jumpforce = 10;
    public float gravity;
    public bool isonground = true;
    public bool hasPowerUp;
    public float powerUpStrength = 350.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        rigbod = GetComponent<Rigidbody>();
        Physics.gravity *= gravity;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isonground)
        {
            rigbod.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
            isonground = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isonground = true;

        if (collision.gameObject.CompareTag("Enemy") && hasPowerUp)
        {
            Rigidbody playerRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 upupandaway = (transform.position - collision.gameObject.transform.position);
            Debug.Log("player Collided with " + collision.gameObject + " with powerup set to" + hasPowerUp);
            playerRigidbody.AddForce(upupandaway * powerUpStrength, ForceMode.Impulse);
            
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PowerUp"))
        {
            hasPowerUp = true;
            Destroy(other.gameObject);
            StartCoroutine(PowerupCountdownRoutine());

            IEnumerator PowerupCountdownRoutine()
            {
                yield return new WaitForSeconds(7);
                hasPowerUp = false;
            }
        }
        
    }
    
}
