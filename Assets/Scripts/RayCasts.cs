using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCasts : MonoBehaviour {

    public LayerMask layerMask;
    public Transform cam;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(cam.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))
        {
          
            Debug.Log("Did Hit");
        }
        else
        {
          
            Debug.Log("Did not Hit");
        }
    }
}

