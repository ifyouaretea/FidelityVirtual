﻿using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
public class DragHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler{

	public static GameObject itemBeingDragged;
	Vector3 startPosition;
	Transform startParent;
	private Ray ray;
	private RaycastHit hit;

	#region IBeginDragHandler implementation
	public void OnBeginDrag (PointerEventData eventData){
		itemBeingDragged = gameObject;
		startPosition = transform.position;
		startParent = transform.parent;
		//GetComponent<CanvasGroup> ().blocksRaycasts = false;
	}
	#endregion

	#region IDragHandler implementation
	public void OnDrag (PointerEventData eventData){
		ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		if (Physics.Raycast(ray,out hit)){
			transform.position.Set (hit.point.x, hit.point.y, transform.position.z);
		}
			
		//transform.position = Input.mousePosition;
	}
	#endregion

	#region IEndDragHandler implementation
	public void OnEndDrag (PointerEventData eventData){
		itemBeingDragged = null;
		//GetComponent<CanvasGroup> ().blocksRaycasts = true;
		transform.position = startPosition;
	}
	#endregion
}
