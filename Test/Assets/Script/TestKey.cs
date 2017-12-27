using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestKey : MonoBehaviour {
  
    // Use this for initialization
    void Start () {
        PreviewLabs.RequestParameters.HasKey("size=3");
        string si = PreviewLabs.RequestParameters.GetValue("size");
        Debug.Log(si);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
