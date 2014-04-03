using UnityEngine;
using System.Collections;

public class CarController : MonoBehaviour {

	public float carSpeed=20f;
	public float bleakPower=40f;
	public float speedMater=0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
			ForwardPower ();
	}

	void ForwardPower(){

		if(Input.GetKey(KeyCode.UpArrow)){

			speedMater=carSpeed*Time.deltaTime;
			this.transform.rigidbody.AddForce(transform.forward*speedMater);

		}
		if(Input.GetKey(KeyCode.DownArrow)){

			speedMater=carSpeed*Time.deltaTime;
			this.transform.rigidbody.AddForce(transform.forward*speedMater);
				
		}
		if(Input.GetKey(KeyCode.LeftArrow)){
			
			this.transform.Rotate (0,30f,0);
				
		}
		if(Input.GetKey(KeyCode.RightArrow)){
			
			this.transform.Rotate (0,30f,0);
			
		}
		 
	}


	
}