using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnClick()
	{
		print ("我被点击了");	
	}

	public void OnValueChange(bool isSelected)
	{
		print ("Troggle Value is Changed   " + isSelected);
	}
}
