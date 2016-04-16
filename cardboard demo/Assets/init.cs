using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class init : MonoBehaviour {

	public static List<string> fav = new List<string>();
	// Use this for initialization
	void Awake () {
		GameObject favourites = GameObject.Find("Favourites");

        foreach (var gameObj in FindObjectsOfType(typeof(GameObject)) as GameObject[])
        {
            if (gameObj.name == "Place holder"){
                gameObj.SetActive(false);

            }
			if (gameObj.name == "Favourites"){
				foreach (Transform child in gameObj.transform)  
				{  
					fav.Add (child.gameObject.tag);
				}
			}
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
