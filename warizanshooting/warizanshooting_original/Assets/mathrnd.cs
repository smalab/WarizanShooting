using UnityEngine;
using System.Collections;

public class mathrnd : MonoBehaviour {

  public TextMesh myTextMesh;
  public float T =0;  
  public int k =0;
	
	// Use this for initialization
	void Start () {
	
	float[] hako = new float[10] {4,9,12,14,15,18,21,25,27,30};
	
    k= Random.Range(0, 9);
		
	T=hako[k];	
		
    myTextMesh.text = ""+T;	
		
	}
	
	
	
 	 private void OnCollisionEnter(Collision collision){
     
		
  	  if(collision.gameObject.tag == "Dtwo" && T%2==0){	     
	  
	
			
      Score.score=Score.score+5;
	  Destroy(this.gameObject);
			
	  }	
		
      if(collision.gameObject.tag == "Dthree" && T%3==0){	     
	 
      Score.score=Score.score+5;
	  Destroy(this.gameObject);
			
	  }	
		
  	  if(collision.gameObject.tag == "Dfive" && T%5==0){	     
	 
      Score.score=Score.score+5;
	  Destroy(this.gameObject);
			
	  }	
		
  	  if(collision.gameObject.tag == "Dseven" && T%7==0){	     
	 
      Score.score=Score.score+5;
	  Destroy(this.gameObject);
			
	  }	
		
		
	 
		
	}

	// Update is called once per frame
	void Update () {

	}
}
