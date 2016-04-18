using UnityEngine;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using System;

public class openApp : MonoBehaviour {

    private bool isShowing;
    public GameObject openApps;
    public static List<GameObject> listofOpenedApps = new List<GameObject>();
    private Vector3 defaultLaunchPos;
    private Vector3 defaultLaunchScale;

    public void isActive(){
        Debug.Log("isActive()");
        GameObject temp = Instantiate(gameObject);
        temp.transform.SetParent(openApps.transform);
        //gameObject.SetActive(!gameObject.activeSelf);
        temp.transform.localPosition = new Vector3(50, -157252.5f, 0);
        temp.transform.localScale = new Vector3(1, 1, 1);
        temp.SetActive(true);
        listofOpenedApps.Add(temp);
        Debug.Log("number of open apps: " + listofOpenedApps.Count);
    }

    public void singleActive()
    {
        Debug.Log("singleActive()");
        if (gameObject.activeSelf == true)
        {
            //recenter
            Debug.Log("recentering?");
            gameObject.transform.localPosition = new Vector3(50, -157252.5f, 0);
            gameObject.transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            // it's not active yet so make it active.
            gameObject.SetActive(!gameObject.activeSelf);
            listofOpenedApps.Add(gameObject);

        }
    }

    public void fixedActive()
    {
        Debug.Log("fixedActive()");
        gameObject.SetActive(!gameObject.activeSelf);
    }
    void Start()
    {
        // somehow using these do not work. so they are not used at the moment.
        defaultLaunchPos = new Vector3(50, -157252.5f, 0);
        defaultLaunchScale = new Vector3(1, 1, 1);

    }
    public void onMouseOver()
    {
        Debug.Log("openApp update active app");
        int i = listofOpenedApps.IndexOf(gameObject);
        GameObject item = listofOpenedApps[i];
        listofOpenedApps.RemoveAt(i);
        listofOpenedApps.Insert(0, item);
    }
    public void Update()
    {
        //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //RaycastHit hit;
        //MeshCollider collider = GetComponent<MeshCollider>();
        
        //if (collider.Raycast(ray, out hit, 100.0F))
        //{
        //    Debug.Log("openApp update active app");
        //    int i = listofOpenedApps.IndexOf(gameObject);
        //    GameObject item = listofOpenedApps[i];
        //    listofOpenedApps.RemoveAt(i);
        //    listofOpenedApps.Insert(0, item);
        //}
    }
}
