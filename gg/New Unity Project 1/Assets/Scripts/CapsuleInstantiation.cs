﻿using UnityEngine;
using System.Collections;

public class CapsuleInstantiation : MonoBehaviour 
{
	public GameObject capsule;
	public int numberOfObjects = 20;
	public float radius = 5f;

	// Use this for initialization
	void Start ()
	{
		for (int i = 0; i < numberOfObjects; i++) {
			float angle = i * Mathf.PI * 2 / numberOfObjects;
			Vector3 pos = new Vector3 (Mathf.Cos (angle), 0, Mathf.Sin (angle)) * radius;
			Instantiate (capsule, pos, Quaternion.identity);
		}
	}
		



	
	// Update is called once per frame
	void Update () {
	
	}
}
