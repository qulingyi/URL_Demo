using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ObjectSelect : MonoBehaviour
{

    public GameObject button;
    public GameObject cam;

    // Use this for initialization
    void Start()
    {
        button.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

        
    }
    void OnMouseDown()
    {
        button.SetActive(true);
        cam.GetComponent<Camera>().locked = true;     
    }
}
