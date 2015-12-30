using UnityEngine;
using System.Collections;

public class scene_controller : MonoBehaviour {

    public float deathFloor; //The height at which the player is killed (eg by falling down a pit)
    public GameObject player;

    public Transform checkpoint;
    int score;


	// Use this for initialization
	void Start () {
        score = 0;
	}

    // Update is called once per frame
    void Update() {
        if (player.transform.position.y < deathFloor)
        {
            killPlayer();
        }
    }

    public void killPlayer()
    {
        player.SetActive(false);
        player.GetComponent<Transform>().position = checkpoint.position;
        player.SetActive(true);
    }
}
