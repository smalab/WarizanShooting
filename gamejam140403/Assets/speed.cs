using UnityEngine;
using System.Collections;

public class speed : MonoBehaviour {


	public float x;
	public float z;
	private int flag= 0;
	public static float sspd=0;

	// Use this for initialization
	void Start () {
		flag=1;
		StartCoroutine("speedM");
		x=transform.position.x;
		z=transform.position.z;
	}
	

	IEnumerator speedM(){
		while(flag==1)
		{  	
			float speed=(transform.position.x-x)*(transform.position.x-x)+(transform.position.z-z)*(transform.position.z-z);
			speed = Mathf.Sqrt(speed)*1400/1000;
			Meter.sp=(int)speed;
			x=transform.position.x;
			z=transform.position.z;
			sspd=speed;
			yield return new WaitForSeconds(1.0f);
	
		}
	}


}
