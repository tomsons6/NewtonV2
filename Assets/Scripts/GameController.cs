using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public LayerMask layerMask1;
    public LayerMask layerMask2;
    public LayerMask layerMask3;
    public Transform cam;
    public Transform AppleStartPoint;
    public Transform wtf;
    public GameObject Apple1;
    public GameObject Apple2;
    public GameObject Apple3;
    public GameObject Apple1Start;
    public GameObject Apple2Start;
    public GameObject Apple3Start;

    public AudioClip trowSound;
    public AudioClip dropSound;
    private AudioSource source;

    public GameObject zemeG;
    public GameObject MenesG;
    public GameObject JupitersG;
    public GameObject Grafiki;

    private bool nomests = false;
    private bool showGraf = false;
    private bool frstpress = false;
    public GameObject All;
    void Awake()
    {
        All.transform.localRotation = Quaternion.Euler(0, 180, 0);
        source = GetComponent<AudioSource>();
    }


    public Text te;
    // Use this for initialization
    void Start()
    {

    }
     void Rrotateionl()
    {
        All.transform.localRotation = Quaternion.Euler(0, 0, 0);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
            TrowApple(Apple1);
        if (Input.GetKeyDown(KeyCode.S))
            StartDrop(Apple1Start);

        if (frstpress == false)
        {
            if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger) || Input.GetKeyDown(KeyCode.Y))
            {
                Rrotateionl();
                frstpress = true;
            }
        }
        else
        {

            if (OVRInput.GetDown(OVRInput.Button.One) || Input.GetKeyDown(KeyCode.P))
            {
                if (showGraf == false)
                {
                    zemeG.GetComponent<SpriteRenderer>().enabled = true;
                    MenesG.GetComponent<SpriteRenderer>().enabled = true;
                    JupitersG.GetComponent<SpriteRenderer>().enabled = true;
                    showGraf = true;

                }
                else
                {
                    zemeG.GetComponent<SpriteRenderer>().enabled = false;
                    MenesG.GetComponent<SpriteRenderer>().enabled = false;
                    JupitersG.GetComponent<SpriteRenderer>().enabled = false;
                    showGraf = false;

                }

            }
            //  if (OVRInput.GetActiveController() == OVRInput.Controller.LTrackedRemote ||
            //    OVRInput.GetActiveController() == OVRInput.Controller.RTrackedRemote)
            //  {

            if (OVRInput.GetDown(OVRInput.Button.Two) || Input.GetKeyDown(KeyCode.O))
            {
                Debug.Log("nospiests;");
                if (nomests == false)
                {
                    zemeG.GetComponent<Animator>().enabled = true;
                    MenesG.GetComponent<Animator>().enabled = true;
                    JupitersG.GetComponent<Animator>().enabled = true;
                    StartDrop(Apple1Start);
                    StartDrop(Apple2Start);
                    StartDrop(Apple3Start);
                    source.pitch = 3;
                    source.PlayOneShot(dropSound);
                    nomests = true;
                }


            }
            if (OVRInput.GetUp(OVRInput.Button.Start))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
            {

                RaycastHit hit;

                if (Physics.Raycast(cam.position, cam.forward, out hit, Mathf.Infinity, layerMask1))
                {
                    TrowApple(Apple1);
                    te.text = "Zeme";
                }
                if (Physics.Raycast(cam.position, cam.forward, out hit, Mathf.Infinity, layerMask2))
                {
                    TrowApple(Apple2);
                    te.text = "Mesnes ";
                }
                if (Physics.Raycast(cam.position, cam.forward, out hit, Mathf.Infinity, layerMask3))
                {
                    TrowApple(Apple3);
                    te.text = "Jupiters";
                }



            }

        }
    }
     //   else// if (OVRInput.Get(OVRInput.Touch.PrimaryTouchpad)) // finger on HMD pad?
     //   {
           // not using controller, same behavior as before.
        //    te.text = "XXX";
       // }
    //}

    public void TrowApple(GameObject go)
    {
         GameObject ins = Instantiate(go, AppleStartPoint.position, Quaternion.identity);
         ins.GetComponent<Rigidbody>().velocity = wtf.forward * 10;
        source.pitch = 3;
         source.PlayOneShot(trowSound);
       
    }

    public void StartDrop(GameObject go)
    {

        go.GetComponent<Rigidbody>().useGravity = true;
        go.GetComponent<ConstantForce>().enabled = true;

        // long hold 

    }

}
