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
    //public GameObject canvas;
    //public CardboardHead head;
    private Vector3 defaultLaunchPos;
    private Vector3 defaultLaunchScale;

    public void isActive()
    {
        // placeholder = gameObject;
        // Debug.Log(isShowing);
        // placeholder.SetActive(!placeholder.activeSelf);

        Debug.Log("isActive()");
        GameObject temp = Instantiate(gameObject);
        temp.transform.SetParent(openApps.transform);
        //Ray currRay = head.Gaze;
        Vector3 pos = Cardboard.SDK.HeadPose.Position;


        temp.transform.localPosition = new Vector3(50, -157252.5f, 0);
        temp.transform.localScale = new Vector3(1, 1, 1);
        temp.SetActive(true);

        //((RectTransform)temp.transform).position = new Vector3(50, -157252.5f, 0);
        
        
        listofOpenedApps.Add(temp);
        

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

    // Use this for initialization
    void Start()
    {
        // somehow using these do not work. so they are not used at the moment.
        defaultLaunchPos = new Vector3(50, -157252.5f, 0);
        defaultLaunchScale = new Vector3(1, 1, 1);

    }

    //// Update is called once per frame
    //void Update () {

    //}
}
