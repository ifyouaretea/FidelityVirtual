using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using System;

public class openApp : MonoBehaviour {

    private GameObject placeholder;
    private bool isShowing;
    public GameObject openApps;
    private List<GameObject> listofOpenedApps = new List<GameObject>();
    public GameObject canvas;
        
    public void isActive()
    {
        // placeholder = gameObject;
        // Debug.Log(isShowing);
        // placeholder.SetActive(!placeholder.activeSelf);

        Debug.Log("isActive()");
        GameObject temp = Instantiate(canvas,new Vector3(50, -157252.5f,0));
        temp.SetActive(true);
        temp.transform.SetParent(openApps.transform);

        ((RectTransform)temp.transform).position = new Vector3();
        
        
        listofOpenedApps.Add(temp);
        

    }

    private GameObject Instantiate(GameObject canvas, Vector3 vector3)
    {
        throw new NotImplementedException();
    }


    //   //get tag
    //   /*
    //   CanvasGroup cg = MyRectTransform.GetComponent<CanvasGroup>();
    //   cg.interactable= false;
    //   cg.alpha = 0;​
    //   */

    //   private string Tag;
    //   private GameObject[] lists;
    //   private bool isShowing;

    //   public void OnGazeEnter()
    //   {
    //       tag = gameObject.tag;
    //       Debug.Log("Inside OnGazeEnter");
    //       Debug.Log(tag);
    //   }

    //   public void OnGazeExit()
    //   {
    //       tag = null;
    //       Debug.Log("Inside OnGazeExit");
    //       Debug.Log(tag);
    //   }

    //   public void OnGazeTrigger()
    //   {
    //       if (tag != null)
    //       {
    //           Debug.Log("Inside OnGazeTrigger");
    //           Debug.Log(tag);
    //           lists = GameObject.FindGameObjectsWithTag(tag);
    //           //CanvasGroup placeholder = lists[0].GetComponent<CanvasGroup>();
    //           lists[0].SetActive(!isShowing);
    //           //placeholder.interactable = false;
    //           //lists[0].GetComponent<CanvasGroup>().alpha= 0;


    //       }

    //   }

    //   // Use this for initialization
    //   void Start () {
    //       isShowing = false;

    //   }

    //// Update is called once per frame
    //void Update () {

    //}
}
