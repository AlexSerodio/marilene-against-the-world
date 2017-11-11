using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleController : MonoBehaviour {

	public Transform m_People;
	public Player m_Player;

	private int[] positionY = {-3, 0, 3};

	// Use this for initialization
	void Start () {
		StartCoroutine(InstantiatePerson(3));
	}

	private IEnumerator InstantiatePerson(float time){

		int random;
		Vector3 position;

		while(m_Player.Lives != 0){
			random = Random.Range(0,3);
			position = new Vector3(transform.position.x, positionY[random], transform.position.z);

			Instantiate(m_People, position, Quaternion.identity);

			yield return new WaitForSeconds(time);
		}
	}
}
