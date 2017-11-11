using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
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
}
