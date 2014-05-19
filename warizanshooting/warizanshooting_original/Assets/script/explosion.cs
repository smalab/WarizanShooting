using UnityEngine;
using System.Collections;

public class explosion : MonoBehaviour {
	
	
	public GameObject ExplotionPrefab;
	
	private void OnCollisionEnter(Collision collision){
  	
Instantiate(ExplotionPrefab, transform.position, transform.rotation);		


			
			
 }
	

	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
