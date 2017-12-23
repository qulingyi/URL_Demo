using UnityEngine;
using System.Collections;

public class PureUrl : MonoBehaviour
{
    // Use this for initialization
    string Url;
    void Start()
    {
        Url = "http://api.open-notify.org/astros.json" ;
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
        }
        else
        {
            Debug.Log(www.error);
        }
    }
}