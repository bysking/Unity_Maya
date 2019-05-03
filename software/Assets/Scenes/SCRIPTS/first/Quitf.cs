using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quitf : MonoBehaviour {

    // Use this for initialization
    public void BtnQuitf()
    {

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
