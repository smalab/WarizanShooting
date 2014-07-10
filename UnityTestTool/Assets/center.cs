using UnityEngine;
using System.Collections;

public class center : MonoBehaviour {

	public int [] cells = new int[]{0,0,0};
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public int GetEmpty(){

		int sum=1;
		for(int i=0;i<3;i++){
			if(cells[i]==0)break;
			sum++;
		}
		if(sum==4)sum=0;

		return sum;
	}
}
