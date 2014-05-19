using UnityEngine;
using System.Collections;

public class shotcounter : MonoBehaviour {
	
	
	  public GameObject countertxt;
      public static int counter;
	
	  
	// Use this for initialization
	void Start () {
	counter = 2;
	}
	
	// Update is called once per frame
	void Update () {
	
    if (Input.GetKeyDown(KeyCode.RightArrow))
    {
     switch(counter){
				
			case 2: counter=3;
				    break;
			case 3: counter=5;
				    break;
			case 5: counter=7;
				    break;
			case 7: counter=2;
				    break;
				
			}			
				
    }

    if (Input.GetKeyDown(KeyCode.LeftArrow))
    {
     switch(counter){
				
			case 2: counter=7;
				    break;
			case 3: counter=2;
				    break;
			case 5: counter=3;
				    break;
			case 7: counter=5;
				    break;
				
			}			
				
    }
		
		
		
	TextMesh tm = (TextMesh)countertxt.GetComponent("TextMesh");

    
	tm.text = ""+counter; 
	
	}
}
