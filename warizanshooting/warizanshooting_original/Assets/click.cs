using UnityEngine;
using System.Collections;
 
public class click : MonoBehaviour
{
	public Transform target3;
	
	private void Update()
	{
		
		var y = Input.acceleration.y*30;
		var x = Input.acceleration.x*20;
		var z = transform.position.z+20;
		
		target3.transform.position= new Vector3(x,-y-10,z);
		
		
	}
}