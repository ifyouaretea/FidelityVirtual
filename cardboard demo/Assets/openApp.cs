using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System;

public class openApp : MonoBehaviour {

    private bool isShowing;

    public void isActive(){
		gameObject.SetActive(!gameObject.activeSelf);
    }
}
