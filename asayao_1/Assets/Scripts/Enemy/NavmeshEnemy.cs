using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavmeshEnemy : MonoBehaviour {
	GameObject mainChara;

	// Use this for initialization
	void Start () {
		mainChara = GameObject.Find("mainChara");

	}

	// Update is called once per frame
	void Update () {
		this.gameObject.GetComponent<NavMeshAgent>().SetDestination(mainChara.transform.position);


	}
}
