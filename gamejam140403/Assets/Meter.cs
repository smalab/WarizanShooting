using UnityEngine;
using System.Collections;

public class Meter : MonoBehaviour {
	public static int sp;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.guiText.text = sp+"" ;
	}
}
