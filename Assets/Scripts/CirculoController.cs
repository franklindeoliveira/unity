﻿using UnityEngine;
using System.Collections;

public class CirculoController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other) {
		Debug.Log("Colidiu: " + other.gameObject.name);
	}
}
