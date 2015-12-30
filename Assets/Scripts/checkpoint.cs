using UnityEngine;
using System.Collections;

public class checkpoint : MonoBehaviour {

    public scene_controller controller;
    public GameObject player;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	    if(player.transform.position.x == transform.position.x)
        {
            controller.checkpoint = transform; 
        }
	}
}
