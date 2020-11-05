using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoviePlay : MonoBehaviour {


	void Start() {
		// this line of code will make the Movie Texture begin playing
		((MovieTexture)GetComponent<Renderer> ().material.mainTexture).Play ();
	}

 

}
