using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UrlAgain : MonoBehaviour {
    public GameObject myObject;
    public string url = "http://api.open-notify.org/astros.json";

    IEnumerator Start()
    {
        // Start a download of the given URL
        using (WWW www = new WWW(url))
        {
            // Wait for download to complete
            yield return www;
                string serviceData = www.text;
                //Data is in json format, we need to parse the Json.
                Debug.Log(serviceData);
            Scaling sphere = JsonUtility.FromJson<Scaling>(serviceData);
            myObject.transform.localScale = new Vector3(sphere.number, sphere.number, sphere.number);
        }
    }
    public class Scaling
    {
        public int number;
    }
}
