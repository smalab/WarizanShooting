using UnityEngine;
using System.Collections;

public class MyGUI : MonoBehaviour {
	
	public GameObject cube;
	
	public float interval = 3.0f;
	
	private int flag= 0;
	private int sum = 0;
	
	void Start () {
				flag = 1;
				StartCoroutine("generateCube");
				
	}


	IEnumerator generateCube()
	{
		while(flag==1)
		{   float rx = Random.Range(-10.0f, 10.0f);
			float ry = Random.Range(1.0f, 6.0f);
			
			float x = transform.position.x+rx;
			float y = transform.position.y+ry;
			
			float z = transform.position.z;
			
			Instantiate(this.cube, new Vector3(x, y,z), Quaternion.identity);

			sum=sum+1;
			
			if(sum>11){
				flag = 0;
			}

			yield return new WaitForSeconds(6.0f);


			
		}
	}
}

