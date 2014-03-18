﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MapFish : MonoBehaviour {
	public int numOfPieces;
	public GameObject[] piecePrefabs;
	protected Queue<GameObject> piecesOfTrackToPutOnTheThinginiOhAreTheyOkay;
	public GameObject startPiece;
	public GameObject endPiece;
	public Vector3 startPosition;
	protected GameObject lastPiece;
	// Use this for initialization
	void Start () {
		piecesOfTrackToPutOnTheThinginiOhAreTheyOkay = new Queue<GameObject>();
		while (piecesOfTrackToPutOnTheThinginiOhAreTheyOkay.Count<numOfPieces) 
			AddRandomPieceOfTrackOnThePlayField ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void AddRandomPieceOfTrackOnThePlayField () {
		GameObject randomPiece = piecePrefabs [Random.Range (0, piecePrefabs.Length)];
		Vector3 position;
		if (piecesOfTrackToPutOnTheThinginiOhAreTheyOkay.Count == 0) {
			randomPiece = startPiece;
			position = startPosition;
		} else if (piecesOfTrackToPutOnTheThinginiOhAreTheyOkay.Count == numOfPieces - 1) {
			randomPiece = endPiece;
			position = lastPiece.transform.position+Vector3.Scale(lastPiece.collider.bounds.size,Vector3.forward);
		} else {
			position = lastPiece.transform.position+Vector3.Scale(lastPiece.collider.bounds.size,Vector3.forward);

		}
		lastPiece = (GameObject)Instantiate(randomPiece, position, Quaternion.identity);
		piecesOfTrackToPutOnTheThinginiOhAreTheyOkay.Enqueue ( lastPiece );
	}
}

