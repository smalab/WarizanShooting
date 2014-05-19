using UnityEngine;
using System.Collections;

public class shot : MonoBehaviour {

	// Use this for initialization
	void Start () {

		rigidbody.AddForce(
			( transform.forward ) * 40,
			ForceMode.VelocityChange );
	
	}
	
	// Update is called once per frame
	void Update () {

	}
}
