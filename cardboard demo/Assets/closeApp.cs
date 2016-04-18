using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class closeApp : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{


    #region Private Variables
    private bool onObj = false;
    private Vector2 mousePosition;
    //public GameObject openApps;
    #endregion

    #region Unity Methods
    private void Update()
    {
        mousePosition = Input.mousePosition;
        Debug.Log("CloseApp");
        Debug.Log(onObj);
        // closes all apps within range of the pointer. front or back all close.
        if (onObj && Input.GetKey(KeyCode.RightControl) && Input.GetKey(KeyCode.Delete))
        {
            GameObject appToClose = openApp.listofOpenedApps[0];
            openApp.listofOpenedApps.RemoveAt(0);
            string tag = appToClose.transform.tag;
            if (tag == "onetime")
            {
                Debug.Log("onetime close");
                appToClose.SetActive(false);
            }
            else {
                Destroy(appToClose);
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
    // THIS DOESN'T WORK...
    public void OnMouseOver()
    {
        Debug.Log("On Mouse Over");
        if (onObj && Input.GetKey(KeyCode.RightControl) && Input.GetKey(KeyCode.Delete))
        {
            GameObject appToClose = openApp.listofOpenedApps[0];
            openApp.listofOpenedApps.RemoveAt(0);
            string tag = appToClose.transform.tag;
            if (tag == "onetime")
            {
                Debug.Log("onetime close");
                appToClose.SetActive(false);
            }
            else {
                Destroy(appToClose);
            }
        }
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