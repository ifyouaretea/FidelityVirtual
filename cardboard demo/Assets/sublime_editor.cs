using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class sublime_editor : MonoBehaviour {
	public Text textbox;
	public InputField inputfield;
	public ScrollRect scrollRect;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		textbox.text = inputfield.text;
	}

	public void updateScroll(){
		scrollRect.verticalNormalizedPosition = 0.0f;
	}

	public void OnSubmit(){
		inputfield.text += "\n";
	}
	
}
