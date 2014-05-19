using UnityEngine;
using System.Collections;

public class shotatari : MonoBehaviour {
	

	

	
	 private void OnCollisionEnter(Collision collision){
     
		
  	       
	 if(collision.gameObject.tag != "Player"){
      
	  Destroy(this.gameObject);	
	 
		}
	}

	

	
	// Use this for initialization
	void Start () {

    Destroy(this.gameObject,4.0f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
