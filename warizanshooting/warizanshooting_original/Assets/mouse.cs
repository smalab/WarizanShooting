using UnityEngine;
using System.Collections;
 
public class mouse : MonoBehaviour
{
	public Transform target2;
 
	private void Start()
	{
		
	}
 
	private void Update()
	{	
		transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(target2.position - transform.position), 0.1f);
	}
}