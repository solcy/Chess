﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour {
	private string color;
	private int rowID;
	private char columnID;
	//GamePiece currentGamePiece;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public char ColumnID{
		get{
			return columnID;
		}
		set{
			columnID = value;
		}
	}
}
