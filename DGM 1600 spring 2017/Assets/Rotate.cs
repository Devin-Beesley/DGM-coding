using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
	public int number = 12;
	public int rotSpeed = 5;

	// Use this for initialization
	void Start () {
		Debug.Log(number);
	}
	
	// Update is called once per frame
	void Update () {
	transform.Rotate(0,4,3);
	//transform.Rotate(Vector3.up,4*Time.deltaTime);
	}
}
