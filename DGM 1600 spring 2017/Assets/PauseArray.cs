using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseArray : MonoBehaviour {

	public int [] newList;

	public void arrayIncrease(){
		int[] temp= new int [newList.Length + 1];
		newList.CopyTo(temp,0);
		newList = temp;
		newList [newList.Length -1] = newList.Length -1;
	}

}
