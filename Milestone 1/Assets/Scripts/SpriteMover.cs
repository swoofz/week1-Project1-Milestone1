using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMover : MonoBehaviour {

    // Delcare variables
    public float speed = 0.02f; // Variable to adjust the speed of the sprite
    private Transform spriteTf; // Variable to get transform values

	// Use this for initialization
	void Start () {
        spriteTf = GetComponent<Transform>(); // get transform values of component
	}
	
	// Update is called once per frame
	void Update () {
        // Move sprite up
        spriteTf.position += Vector3.up * speed; // Update y positive every frame
	}
}
