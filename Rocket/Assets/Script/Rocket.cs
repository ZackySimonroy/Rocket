using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {
    private Rigidbody rocket;
    [SerializeField] public float Trust;
    [SerializeField] public float ForceRelation;
    // Use this for initialization
    void Start () {
        rocket = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        ManageInputJump();

        if(Input.GetAxis("Horizontal") > 0)
        {
            rocket.AddForceAtPosition(new Vector3(5, 0, 0), new Vector3(0, 10, 0));
        }
        else if(Input.GetAxis("Horizontal") < 0)
        {
            rocket.AddForceAtPosition(new Vector3(-5, 0, 0), new Vector3(0, 10, 0));
        }
    }

    private void ManageInputJump()
    {
        if (Input.GetAxis("Jump") > 0)
        {
            rocket.AddRelativeForce(new Vector3(0, ForceRelation, 0));
        }
    }
}
