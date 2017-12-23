using UnityEngine;
using System.Collections;

public class URL : MonoBehaviour
{
    // Use this for initialization
    public GameObject myObject;
    string Url;
    void Start()
    {
        Url = "http://api.open-notify.org/astros.json";
        GetData();
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    //Invoke this function where to want to make request.
    void GetData()
    {
        //sending the request to url
        WWW www = new WWW(Url);
        StartCoroutine("GetdataEnumerator", Url);
    }
    IEnumerator GetdataEnumerator(WWW www)
    {
        //Wait for request to complete
        yield return www;
        if (www.error != null)
        {
            string serviceData = www.text;
            //Data is in json format, we need to parse the Json.
            Debug.Log(serviceData);
            Scaling sphere = JsonUtility.FromJson<Scaling>(serviceData);
            myObject.transform.localScale = new Vector3(sphere.number, sphere.number, sphere.number);
        }
        else
        {
            Debug.Log(www.error);
        }
    }
   
    public class Scaling
    {
        public int number;
    }
}