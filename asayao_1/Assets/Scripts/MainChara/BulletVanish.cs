using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletVanish : MonoBehaviour {
	private float vanishTime;

	// Use this for initialization
	void Start () {
		vanishTime = 0.0f;

	}

	// Update is called once per frame
	void Update () {
		vanishTime += Time.deltaTime;
		if(vanishTime >= 1.0f)Destroy(this.gameObject);
	}
}
