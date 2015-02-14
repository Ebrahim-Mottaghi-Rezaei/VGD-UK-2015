using UnityEngine;
using System.Collections;

public class ColliderDetection : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{
		print("Hello World!");
		Debug.Log("Hello World!");
	}
}
