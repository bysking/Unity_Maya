using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LOOKAT : MonoBehaviour {
    public GameObject player;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(player.transform);
    }
}
