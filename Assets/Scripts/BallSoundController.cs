using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSoundController : MonoBehaviour {

    AudioSource audioData;

    // Use this for initialization
    void Start () {
        audioData = GetComponent<AudioSource>();
        audioData.Play(0);
        Debug.Log("started");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
            Debug.DrawRay(contact.point, contact.normal, Color.white);
        }
        audioData.Play();
    }
}
