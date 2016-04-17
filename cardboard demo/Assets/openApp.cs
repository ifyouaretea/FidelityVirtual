using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System;

public class openApp : MonoBehaviour {

    private GameObject placeholder;
    private bool isShowing;

    public void isActive()
    {
        placeholder = gameObject;
        //Debug.Log(isShowing);
        placeholder.SetActive(!placeholder.activeSelf);
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
