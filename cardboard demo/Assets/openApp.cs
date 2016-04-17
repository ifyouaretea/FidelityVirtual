using UnityEngine;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using System;

public class openApp : MonoBehaviour {

    private bool isShowing;
    public GameObject openApps;
    private List<GameObject> listofOpenedApps = new List<GameObject>();
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
    }

    public void singleActive()
    {
        Debug.Log("singleActive()");
        gameObject.SetActive(!gameObject.activeSelf);

    }
    void Start()
    {
        // somehow using these do not work. so they are not used at the moment.
        defaultLaunchPos = new Vector3(50, -157252.5f, 0);
        defaultLaunchScale = new Vector3(1, 1, 1);

    }

}
