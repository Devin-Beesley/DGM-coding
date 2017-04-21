using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DivisionCalculator : MonoBehaviour {
public InputField input1;
public InputField input2;
public Text result;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}
public void Proses() {

	int variableWhile;
	variableWhile = int.Parse (input1.text) / int.Parse (input2.text);

	result.text = variableWhile.ToString();

	}
}
