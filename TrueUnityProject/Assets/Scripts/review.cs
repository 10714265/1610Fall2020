using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
//find private here as well cause of syntax

public class review : MonoBehaviour
{

    public int numbers;
    public float what;
    public string name;
    public bool truefalsestatement;
    public GameObject playerArt;
    public Transform playerTransform;
    
    //somthing specific is private

    private CharacterController controller;
    //in order to tell private what it is, tell it whre to find it
    private Vector3 movemnt;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        //this is where to find the previously mentioned private variable
    }

    // Update is called once per frame
    void Update()
    {
        movemnt.x = 3f;
        controller.Move(Vector3.forward);
    }
}
//scripatble object will instanstiate as an asset
//mono behavior instantiate as componenet
//what is the point of a scriptable object? to hold data, 
//MB component, so asset
//Both will store variables and funcitons, difference between two is what can see and use them

//component on a game object, game objects can only use their own componenetns
//for  scripatable object any thing can see it

//two different kinds o f bariables
//variables refrence
//player thats refrenceing a scriptable object, drag it into the monobehavior, its listing the object, thats a refrecne 
//anything thats a seperate object is refrenced 