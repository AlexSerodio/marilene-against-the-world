using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine(Move(.05f));
	}
	
	private IEnumerator Move(float speed){
		while(transform.position.x > -13){
			transform.position = new Vector3(transform.position.x - speed, transform.position.y, transform.position.z);
			yield return null;
		}
	}
}
