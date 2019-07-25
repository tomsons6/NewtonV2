using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(Nextsceene());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    IEnumerator Nextsceene()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(1);
        
    }
}
