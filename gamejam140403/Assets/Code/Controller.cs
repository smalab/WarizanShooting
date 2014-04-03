using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {
	
	public float carSpeed=40f;
	public float speedMater=0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		ForwardPower ();
	
	}

	void ForwardPower(){
		float v = Input.GetAxis("Vertical");
		float h = Input.GetAxis("Horizontal");
		this.transform.rigidbody.AddForce(transform.forward*v*carSpeed);
		this.transform.Rotate(0,h,0);

	}

}
