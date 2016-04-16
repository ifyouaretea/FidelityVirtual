using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class init : MonoBehaviour {

	public static List<string> fav = new List<string>();
	public Text time;
	public Text date;
	// Use this for initialization
	void Awake () {
		time.text = System.DateTime.Now.ToString("hh:mm tt");
		date.text = System.DateTime.Now.ToString("dddd \n dd MMMM, yyyy");

		GameObject favourites = GameObject.Find("Favourites");

        foreach (var gameObj in FindObjectsOfType(typeof(GameObject)) as GameObject[])
        {
			if (gameObj.name == "Place holder" || gameObj.name=="All Apps"){
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
		time.text = System.DateTime.Now.ToString("hh:mm tt");
		date.text = System.DateTime.Now.ToString("dddd \n dd MMMM, yyyy");
	}
}
