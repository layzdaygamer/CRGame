using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {

    public Rigidbody rb;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>(); 
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Movement()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {

        }
    }
}
