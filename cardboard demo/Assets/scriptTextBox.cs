using UnityEngine;
using System.Collections;

public class scriptTextBox : MonoBehaviour {

	public GameObject screen;
	GameObject textBox;
	Vector2 screenSize;
	Vector2 size_Offset = new Vector2(-40, -20);

	// Use this for initialization
	void Start () {
		textBox = gameObject;

		// resize textbox to screen size
		screenSize = Get_Size (screen);
		Set_Size (textBox, screenSize[0] , screenSize[1], size_Offset );

		textBox.transform.position.Set (10,-10,0);
	}

	// Update is called once per frame
	void Update () {
		// resize textbox to screen size
		screenSize = Get_Size (screen);
		Set_Size (textBox, screenSize[0] , screenSize[1], size_Offset );
		textBox.transform.position.Set (10,-10,0);

	}

	public static Vector2 Get_Size(GameObject gameObject) {
		if (gameObject != null) {
			var rectTransform = gameObject.GetComponent<RectTransform> ();
			if (rectTransform != null) {
				return new Vector2 (rectTransform.rect.width, rectTransform.rect.height);
			}
			throw new MissingReferenceException ("textbox :: rectTransform == null");

		} else {
			throw new MissingReferenceException ("textbox :: gameObject == null");

		}

	}

	public static void Set_Size(GameObject gameObject, float width, float height, Vector2 size_offset) {
		if (gameObject != null)
		{
			var rectTransform = gameObject.GetComponent<RectTransform>();
			if (rectTransform != null)
			{
				rectTransform.sizeDelta = (new Vector2(width, height)) + size_offset;
			}               
		}
	}
}
