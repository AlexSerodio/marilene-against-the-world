using UnityEngine;

public class PlayerController : MonoBehaviour {

	private Player mPlayer;
	// Use this for initialization
	void Start () {
		mPlayer = GetComponent<Player>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown("w")){
			if(transform.position.y < 3)
				transform.position = new Vector3(transform.position.x, transform.position.y + 3, transform.position.z);
		}else if(Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown("s")){
			if(transform.position.y > -3)
				transform.position = new Vector3(transform.position.x, transform.position.y - 3, transform.position.z);
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		if(other.tag == "Enemy") {
			if(mPlayer.Lives > 1) {
				mPlayer.Lives--;
				Debug.Log("Vidas restante: " + mPlayer.Lives);
			} else {
				Debug.Log("Fim do jogo. Pontuação total: " + mPlayer.Score);
				FindObjectOfType<PeopleController>().StopAllCoroutines();
			}
			Destroy(other.gameObject);
			//other.GetComponent<PersonMovement>().StopAllCoroutines();
		}
	}
}
