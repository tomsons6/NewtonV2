using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitNewton : MonoBehaviour {

    public GameObject target;
    public AudioClip hit;
    private AudioSource source;
    private bool b = false;
    // Use this for initialization
    void Awake()
    {

        source = GetComponent<AudioSource>();
    }

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == target.name)
        {
            if (b == false)
            {
                b = true;
                Debug.Log("hit");
                this.GetComponent<Animator>().enabled = true;
                source.PlayOneShot(hit);
            }
            
        }
    }

}
