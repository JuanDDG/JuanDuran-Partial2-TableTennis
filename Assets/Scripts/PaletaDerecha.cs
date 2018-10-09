using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaletaDerecha : MonoBehaviour
{

    public float motionSpeed;

    // Use this for initialization
    void Start()
    {

    }

    void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(Vector3.forward * motionSpeed);

        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(Vector3.back * motionSpeed);

        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(Vector3.up * motionSpeed);

        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(Vector3.down * motionSpeed);

        }
    }

}