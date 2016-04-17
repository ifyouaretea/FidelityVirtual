using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class DragHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler{

	public static GameObject itemBeingDragged;
	Vector3 startPosition;
	Transform startParent;
	private float distance;
	#region IBeginDragHandler implementation

	public void OnBeginDrag (PointerEventData eventData)
	{
		itemBeingDragged = gameObject;
		startPosition = transform.position;
		startParent = transform.parent;
		GetComponent<CanvasGroup> ().blocksRaycasts = false;

	}

	#endregion

	#region IDragHandler implementation

	public void OnDrag (PointerEventData eventData)
	{
		distance = Vector3.Distance(new Vector3(transform.position.x, transform.position.y + 1f,transform.position.z),Camera.main.transform.position);
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		Vector3 rayPoint = ray.GetPoint(distance); 
		transform.position = rayPoint;
		//transform.position = Input.mousePosition;
	}

	#endregion

	#region IEndDragHandler implementation

	public void OnEndDrag (PointerEventData eventData)
	{
		transform.position = startPosition;
		GetComponent<CanvasGroup> ().blocksRaycasts = true;
		itemBeingDragged = null;
	}

	#endregion
}
