using UnityEngine;
using System.Collections;

public class atari : MonoBehaviour {
	
    	
	

	
	 private void OnCollisionEnter(Collision collision){
 
  	       
	
		
		
    if(collision.gameObject.tag == "teki"){		
      HP.hp=HP.hp-10;	
     Destroy(collision.gameObject);
		
		}

		if(HP.hp<1){
		Destroy(this.gameObject);}
			
 }

	

	
	// Use this for initialization
	void Start () {

 
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
