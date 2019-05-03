using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Followby : MonoBehaviour
{

    public float mouse_x;
    public float mouse_y;
    public float mouse_scroll;
    public GameObject player;

    void Start()
    {

        mouse_x = 0;
        mouse_y = 0;
        mouse_scroll = 0;
    }

    // Update is called once per frame

    void Update()
    {
        transform.LookAt(player.transform);
        mouse_scroll = Input.GetAxis("Mouse ScrollWheel");

        if (mouse_scroll != 0)
        {
            transform.Translate(new Vector3(0, 0, mouse_scroll * Time.deltaTime * 50f), Space.Self);
        }
        //  if (Input.GetMouseButton(1))
        //{
        mouse_x = Input.GetAxis("Mouse X");
        mouse_y = Input.GetAxis("Mouse Y");
        transform.RotateAround(player.transform.position, player.transform.up, mouse_x * Time.deltaTime * 50f);
        transform.RotateAround(player.transform.position, transform.right, -1 * mouse_y * Time.deltaTime * 50f);
    }

}
