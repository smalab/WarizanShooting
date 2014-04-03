using UnityEngine;

using System.Collections;



public class shot : MonoBehaviour {
	
	
	
	// Use this for initialization
	
	void Start () {


		
	}
	
	
	
	// Update is called once per frame
	
	void Update () {


		rigidbody.AddForce(
			
			( transform.forward ) * 5,
			
			ForceMode.Acceleration);

		

		
	}
	
}

