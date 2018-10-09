using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaletaIzquierda : MonoBehaviour {

    // Use this for initialization

    public float motionSpeed;

    // Use this for initialization
    void Start()
    {
     
    }


    // Update is called once per frame
    void Update () {

        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(Vector3.forward * motionSpeed);

        }

        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(Vector3.back * motionSpeed);

        }

        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(Vector3.up * motionSpeed);

        }

        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(Vector3.down * motionSpeed);

        }

    }
}
