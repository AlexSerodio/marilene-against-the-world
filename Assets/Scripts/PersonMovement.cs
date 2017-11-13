using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonMovement : MonoBehaviour {

	private Player mPlayer;
	// Use this for initialization
	void Start () {
		mPlayer = FindObjectOfType<Player>();
		StartCoroutine(Move(.05f));
	}
	
	private IEnumerator Move(float speed){
		while(transform.position.x > -11){
			transform.position = new Vector3(transform.position.x - speed, transform.position.y, transform.position.z);

			yield return null;
		}
		mPlayer.Score += 10;
		Debug.Log("Pontuação: " + mPlayer.Score);
		Destroy(gameObject);
	}

	
}
