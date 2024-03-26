using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject charModel;
    public AudioSource crash;
    public GameObject mainCam;
    public GameObject levelControl;
    

   
    void OnTriggerEnter(Collider other)
    {
       this.gameObject.GetComponent<BoxCollider>().enabled = false;
       thePlayer.GetComponent<PlayerMove>().enabled = false;
        charModel.GetComponent<Animator>().Play("Stumble Backwards");
        levelControl.GetComponent<LevelDistance>().enabled = false;
        crash.Play();
        mainCam.GetComponent<Animator>().enabled = true;
        levelControl.GetComponent<EndRunSequence>().enabled = true; 
        
        
    }
}


