using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextureChanging : MonoBehaviour {
    public Dropdown myDropdown;
    public GameObject myObject;
    public static Texture[] textures = new Texture[3];
    public Texture wood, metal, paper;

    // Use this for initialization
    void Start () {
        textures[0] = wood;
        textures[1] = metal;
        textures[2] = paper;
    }
	
	// Update is called once per frame
	void Update () {
		switch(myDropdown.value )
        {
         case 1:
            myObject.GetComponent<Renderer>().material.mainTexture = textures[0];
                break;
            case 2:
                myObject.GetComponent<Renderer>().material.mainTexture = textures[1];
                break;
            case 3:
                myObject.GetComponent<Renderer>().material.mainTexture = textures[2];
                break;


        }
	}
}
