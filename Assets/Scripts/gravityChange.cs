using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravityChange : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //GetComponent<Rigidbody>().gravityScale(Physics.gravity * rigidbody.mass);
        //GetComponent<ConstantForce>().force = new Vector3(0, -25.0f, 0);
        GetComponent<Rigidbody>().AddForce(force: new Vector3(100f, 0, 0));
    }
	
	// Update is called once per frame
	void Update () {
        
    }
    private void FixedUpdate()
    {
        
    }
}
