using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class sublime : MonoBehaviour
{

    public Text textbox;
    public InputField inputfield;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        textbox.text = inputfield.text;
    }
}
