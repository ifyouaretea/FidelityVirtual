using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class closeApp : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    #region Private Variables
    private bool onObj = false;
    private Vector2 mousePosition;
	private List<GameObject> openApps = openApp.listofOpenedApps;
    #endregion

    #region Unity Methods
    private void Update()
    {
        mousePosition = Input.mousePosition;
        // closes all apps within range of the pointer. front or back all close.
		Debug.Log(onObj);
		if (onObj && Input.GetKeyDown(KeyCode.Escape)){
			Debug.Log("hi");
            GameObject appToClose = openApp.listofOpenedApps[0];
            openApp.listofOpenedApps.RemoveAt(0);
            string tag = appToClose.transform.tag;
            if (tag == "onetime")
            {
                appToClose.SetActive(false);
            }
            else {
                Destroy(appToClose);
            }
        }
		if (Input.GetKeyDown(KeyCode.LeftWindows) && Input.GetKeyDown(KeyCode.D)){
			foreach (var gameObj in FindObjectsOfType(typeof(GameObject)) as GameObject[])
			{
				if (gameObj.tag == "open"){
					gameObj.SetActive(false);

				}
			}

		}
        //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //RaycastHit hit;
        //MeshCollider collider = GetComponent<MeshCollider>();

        //if (collider.Raycast(ray, out hit, 100.0F)) {
        //    Debug.Log("closeApp raycast");
        //    if (onObj && Input.GetKey(KeyCode.RightControl) && Input.GetKey(KeyCode.Delete))
        //    {
        //        GameObject appToClose = openApp.listofOpenedApps[0];
        //        openApp.listofOpenedApps.RemoveAt(0);
        //        string tag = appToClose.transform.tag;
        //        if (tag == "onetime")
        //        {
        //            Debug.Log("onetime close");
        //            appToClose.SetActive(false);
        //        }
        //        else {
        //            Destroy(appToClose);
        //        }
        //    }
        //}

    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        onObj = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        onObj = false;
    }

    public void OnDisable()
    {
        onObj = false;
    }

}
#endregion