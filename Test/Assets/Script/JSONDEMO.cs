using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class JSONDEMO : MonoBehaviour {
    public GameObject myObject;
    //private int size;
    string path;
    string jsonString;
	// Use this for initialization
	void Start () {
        path = Application.streamingAssetsPath + "/Creature.json";
        jsonString = File.ReadAllText(path);
        Scaling sphere = JsonUtility.FromJson<Scaling>(jsonString);
        Debug.Log(sphere.size);
        myObject.transform.localScale += new Vector3(sphere.size, 0, 0);

    }
	
	// Update is called once per frame
	void Update () {
        
           
      
    }
   
    [System.Serializable]
   public class Scaling
    {
        public int size;
    }
}
