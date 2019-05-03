using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loadf : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

    }
    public void OnStartGame(string sceneName)
    {
        Application.LoadLevel(sceneName);

    }
    // Update is called once per frame
    void Update()
    {

    }
}
