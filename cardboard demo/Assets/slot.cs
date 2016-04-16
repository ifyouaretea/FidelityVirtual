using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class slot : MonoBehaviour, IDropHandler{

	#region IDropHandler implementation
	public void OnDrop (PointerEventData eventData)
	{	

	//	string tag = DragHandler.itemBeingDragged.tag;
	//	string button = tag + "Button";
	//	Debug.Log (button);
	//	GameObject child = (GameObject) Instantiate(Resources.Load (button), transform.position, transform.rotation);
	//	Debug.Log("hihi");
	//	child.transform.parent = transform.parent;
		List<string> fav = init.fav;
		string tag = DragHandler.itemBeingDragged.tag;
		foreach (string i in fav) {
			if (!i.Equals ("Untagged")) {

				gameObject.GetComponent<Image>().sprite = DragHandler.itemBeingDragged.GetComponent<Image> ().sprite;
				gameObject.transform.parent.tag = tag;
			}

		}
	}
	#endregion
}
