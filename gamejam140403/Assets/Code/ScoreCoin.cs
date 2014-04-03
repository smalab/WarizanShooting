using UnityEngine;
using System.Collections;

public class ScoreCoin : MonoBehaviour {

	int SCORE = 0;

	private void OnCollisionEnter(Collision collision){
		if(collision.gameObject.tag == "Coin"){
			Destroy(collision.gameObject);
			SCORE = SCORE + 100;
			Debug.Log ("Score : " + (SCORE));
		}
	}
}
