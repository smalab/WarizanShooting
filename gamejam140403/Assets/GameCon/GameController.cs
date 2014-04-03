using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GameObject target;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private void OnCollisionEnter(Collision collision){

		if (collision.gameObject.name ==  "Car") {

			target.SetActive(true);
			Time.timeScale = 0f;
		}

	}


}
