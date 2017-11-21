using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
	private GameObject mainChara;

	void Awake(){
		mainChara = GameObject.Find("mainChara");
	}

	// Update is called once per frame
	void Update () {
		if(mainChara == null)return;
		transform.position = new Vector3(mainChara.transform.position.x,mainChara.transform.position.y+5,mainChara.transform.position.z-3f);
	}
}
