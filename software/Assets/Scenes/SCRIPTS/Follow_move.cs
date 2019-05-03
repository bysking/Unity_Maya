using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_move : MonoBehaviour {

    public GameObject player;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position;
    }
}
