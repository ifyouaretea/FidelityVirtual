using UnityEngine;
using System.Collections;

public class init : MonoBehaviour {


	// Use this for initialization
	void Awake () {
        foreach (var gameObj in FindObjectsOfType(typeof(GameObject)) as GameObject[])
        {
            if (gameObj.name == "Place holder")
            {
                //gameObj.SetActive(false);

            }
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
