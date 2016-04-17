using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class MouseDrag : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler {
	public Camera cameraToLookAt;
	private Vector3 screenPoint;
	private Vector3 offset;

	#region IBeginDragHandler implementation
	public void OnBeginDrag (PointerEventData eventData)
	{		
		screenPoint = cameraToLookAt.WorldToScreenPoint(gameObject.transform.position);
		offset = gameObject.transform.position - cameraToLookAt.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
		GetComponent<CanvasGroup> ().blocksRaycasts = false;
	}
	#endregion

	#region IDragHandler implementation
	public void OnDrag (PointerEventData eventData)
	{
		Debug.Log ("OnDrag");
		//transform.rotation.Set(0,cameraToLookAt.transform.rotation.y,0,0);

		Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
		Vector3 curPosition = cameraToLookAt.ScreenToWorldPoint(curScreenPoint) + offset;
		transform.position = curPosition;

		//Vector3 fwd = cameraToLookAt.transform.forward;
		//fwd.y = 0.0f;
		//transform.rotation = Quaternion.LookRotation(fwd);
		transform.LookAt (transform.position + cameraToLookAt.transform.rotation * Vector3.forward, cameraToLookAt.transform.rotation * Vector3.up);

	}
	#endregion

	#region IEndDragHandler implementation
	public void OnEndDrag (PointerEventData eventData)
	{
		GetComponent<CanvasGroup> ().blocksRaycasts = true;
		//transform.position;
	}
	#endregion
}