using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class multiAppView : MonoBehaviour {

	public GameObject allOpenedAppsFolder;
	int size_listOfOpenedApps;
	public GameObject defaultCopy;
	public Sprite spriteWhatsapp, spriteChrome, spriteDota, spriteTelegram, spritePaint, spriteVlc,spriteSpotify, spriteSteam, spriteWord, spriteSublime;

	// Use this for initialization
	void Start () {
		size_listOfOpenedApps = openApp.listofOpenedApps.Count;
	}
	
	// Update is called once per frame
	void Update () {
		if (openApp.listofOpenedApps.Count != size_listOfOpenedApps) {
			size_listOfOpenedApps = openApp.listofOpenedApps.Count;
			reorganise ();

		} 
	}

	void reorganise(){
		Debug.Log ("reorganise()");
		Debug.Log ("size_listOfOpenedApps: "+size_listOfOpenedApps.ToString());


		for (int i = allOpenedAppsFolder.transform.childCount-1; i > 0; i--) {
			Destroy(allOpenedAppsFolder.transform.GetChild(i).gameObject);
		}

		Debug.Log ("size of listOfOpenedApps: "+openApp.listofOpenedApps.Count.ToString());
		for (int i=0; i<size_listOfOpenedApps; i++){
			
			string tag = openApp.listofOpenedApps[i].tag;
			Debug.Log ("#"+i.ToString() + " object tag: "+tag);

			if (tag.Equals ("whatsapp")) {
				Debug.Log ("Instantiating whatsapp object");
				GameObject copy = Instantiate (defaultCopy) as GameObject;
				copy.SetActive (true);
				copy.transform.SetParent (allOpenedAppsFolder.transform, false);

				GameObject imageRect = copy.transform.GetChild (0).gameObject;
				imageRect.GetComponent<Image> ().overrideSprite = spriteWhatsapp;

			} else if (tag.Equals ("chrome")) {
				Debug.Log ("Instantiating chrome object");
				GameObject copy = Instantiate (defaultCopy) as GameObject;
				copy.SetActive (true);
				copy.transform.SetParent (allOpenedAppsFolder.transform, false);

				GameObject imageRect = copy.transform.GetChild (0).gameObject;
				imageRect.GetComponent<Image> ().overrideSprite = spriteChrome;

			} else if (tag.Equals ("dota")) {
				Debug.Log ("Instantiating chrome object");
				GameObject copy = Instantiate (defaultCopy) as GameObject;
				copy.SetActive (true);
				copy.transform.SetParent (allOpenedAppsFolder.transform, false);

				GameObject imageRect = copy.transform.GetChild (0).gameObject;
				imageRect.GetComponent<Image> ().overrideSprite = spriteDota;

			} else if (tag.Equals ("telegram")) {
				Debug.Log ("Instantiating chrome object");
				GameObject copy = Instantiate (defaultCopy) as GameObject;
				copy.SetActive (true);
				copy.transform.SetParent (allOpenedAppsFolder.transform, false);

				GameObject imageRect = copy.transform.GetChild (0).gameObject;
				imageRect.GetComponent<Image> ().overrideSprite = spriteTelegram;

			} else if (tag.Equals ("paint")) {
				Debug.Log ("Instantiating chrome object");
				GameObject copy = Instantiate (defaultCopy) as GameObject;
				copy.SetActive (true);
				copy.transform.SetParent (allOpenedAppsFolder.transform, false);

				GameObject imageRect = copy.transform.GetChild (0).gameObject;
				imageRect.GetComponent<Image> ().overrideSprite = spritePaint;

			} else if (tag.Equals ("vlc")) {
				Debug.Log ("Instantiating chrome object");
				GameObject copy = Instantiate (defaultCopy) as GameObject;
				copy.SetActive (true);
				copy.transform.SetParent (allOpenedAppsFolder.transform, false);

				GameObject imageRect = copy.transform.GetChild (0).gameObject;
				imageRect.GetComponent<Image> ().overrideSprite = spriteVlc	;

			} else if (tag.Equals ("spotify")) {
				Debug.Log ("Instantiating chrome object");
				GameObject copy = Instantiate (defaultCopy) as GameObject;
				copy.SetActive (true);
				copy.transform.SetParent (allOpenedAppsFolder.transform, false);

				GameObject imageRect = copy.transform.GetChild (0).gameObject;
				imageRect.GetComponent<Image> ().overrideSprite = spriteSpotify	;

			} else if (tag.Equals ("steam")) {
				Debug.Log ("Instantiating chrome object");
				GameObject copy = Instantiate (defaultCopy) as GameObject;
				copy.SetActive (true);
				copy.transform.SetParent (allOpenedAppsFolder.transform, false);

				GameObject imageRect = copy.transform.GetChild (0).gameObject;
				imageRect.GetComponent<Image> ().overrideSprite = spriteSteam;

			} else if (tag.Equals ("word")) {
				Debug.Log ("Instantiating chrome object");
				GameObject copy = Instantiate (defaultCopy) as GameObject;
				copy.SetActive (true);
				copy.transform.SetParent (allOpenedAppsFolder.transform, false);

				GameObject imageRect = copy.transform.GetChild (0).gameObject;
				imageRect.GetComponent<Image> ().overrideSprite = spriteWord;

			} else if (tag.Equals ("sublime")) {
				Debug.Log ("Instantiating chrome object");
				GameObject copy = Instantiate (defaultCopy) as GameObject;
				copy.SetActive (true);
				copy.transform.SetParent (allOpenedAppsFolder.transform, false);

				GameObject imageRect = copy.transform.GetChild (0).gameObject;
				imageRect.GetComponent<Image> ().overrideSprite = spriteSublime;

			}
		}
	}

	Sprite loadSprite(string appname){
		return Resources.Load<Sprite>("SS/"+appname+"SS");
	}
}
