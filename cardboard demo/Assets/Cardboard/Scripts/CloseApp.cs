using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class CloseApp : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
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
        if (onObj && Input.GetKey(KeyCode.RightControl) && Input.GetKey(KeyCode.Delete))
        {

            Destroy(gameObject);
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