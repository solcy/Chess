using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessBoard : MonoBehaviour {
	public GameObject whiteSquare;
	public GameObject blackSquare;
	private float x, y, z;
	private List<GameObject> boardSquares;
	private const int SCALE_FACTOR = 2;
	private const int BOARD_OFFSET = 8;

	// Use this for initialization
	void Start () {
		x = 0f;
		y = 1f;
		z = 0f;

		int row = 1;
		int column = 1;
		int switchInitColor = 0;

		for(int r=1; r<=8; r++){
			column = 1;

			for(int c=1; c<=8; c++){
				x = (float)(row * SCALE_FACTOR - BOARD_OFFSET);
				z = (float)(column * SCALE_FACTOR);

				GameObject squareGameObject;
				if ((column % 2) == switchInitColor) {
					squareGameObject = (GameObject)Instantiate (whiteSquare, new Vector3 (x, y, z), transform.rotation);
				} else {
					squareGameObject = (GameObject)Instantiate (blackSquare, new Vector3 (x, y, z), transform.rotation);
				}

				column++;
				//boardSquares.Add (squareGameObject);
				Square squareObj = squareGameObject.GetComponent<Square> ();
				squareObj.ColumnID = (char)(column + 96);
				Debug.Log (squareObj.ColumnID);
			}
			if(switchInitColor==0){
				switchInitColor = 1;
			}else{
				switchInitColor = 0;
			}
			row++;
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
