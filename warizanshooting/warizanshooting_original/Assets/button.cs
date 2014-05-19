using UnityEngine;
using System.Collections;

public class button : MonoBehaviour {

	
	
	public GameObject twogun;
	public GameObject threegun;
	public GameObject fivegun;
	public GameObject sevengun;
	private GameObject tat;


	void Start () {
		
		tat= GameObject.Find("player/shot");
		
	}

	
	void OnMouseDown(){
			
   
		        

				switch(shotcounter.counter){
					
				case 2: Instantiate(this.twogun, tat.transform.position, tat.transform.rotation);
					break;
					
				case 3: Instantiate(this.threegun, tat.transform.position, tat.transform.rotation);
					break;
					
				case 5: Instantiate(this.fivegun, tat.transform.position, tat.transform.rotation);
					break;
					
					
				case 7: Instantiate(this.sevengun, tat.transform.position, tat.transform.rotation);
					break;
					
					
					
					
				}

}

}

