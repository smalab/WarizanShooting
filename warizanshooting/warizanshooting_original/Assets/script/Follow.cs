using UnityEngine;
using System.Collections;
 
public class Follow : MonoBehaviour {
    
   private GameObject  target;
   private float speed = 0.1f;

	void Start () {

		target = GameObject.Find("player");

	}

 
    
   private void Update()
{
	transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(target.transform.position - transform.position), 0.1f);
	transform.position += transform.forward * speed;
}
	
}