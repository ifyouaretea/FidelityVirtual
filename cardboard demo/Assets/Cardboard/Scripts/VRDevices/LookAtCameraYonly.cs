﻿using UnityEngine;
using System.Collections;

public class LookAtCameraYonly : MonoBehaviour {

	public Camera cameraToLookAt;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//Vector3 v = cameraToLookAt.transform.position - transform.position;
		//v.x = v.z = 0.0f;
		//transform.LookAt( cameraToLookAt.transform.position - v ); 
		transform.rotation.Set(0,cameraToLookAt.transform.rotation.y,0,0);
	}
}
