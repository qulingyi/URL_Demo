using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour {
    public GameObject s;
    int p = 3;
	// Use this for initialization
	void Start () {
        //s.transform.localScale += new Vector3(p * 1.0f, p * 1.0f, p * 1.0f);
        s.transform.localScale += new Vector3(p, p, p);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
