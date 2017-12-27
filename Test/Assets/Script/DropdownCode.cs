using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownCode : MonoBehaviour {

    public Dropdown dropdown;
    List<string> textures = new List<string>() { "Wood", "Metal", "Paper" };
    public Text selectedTexture;

    // Use this for initialization
    void Start () {
        textureList();
    }

    void textureIndex(int index)
    {
        selectedTexture.text = textures[index];
    }

    void textureList()
    {

        dropdown.AddOptions(textures);
    }


    // Update is called once per frame
    void Update () {
		
	}
}
