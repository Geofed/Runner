using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MapFish : MonoBehaviour {
	[Range(4, 20)]
	public int rangeOfPieces;
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
		int minPieceIndex = PlayerData.Instance().level - 1;
		int maxPieceIndex = minPieceIndex + rangeOfPieces;
		if (maxPieceIndex > piecePrefabs.Length) {
			maxPieceIndex = piecePrefabs.Length;
			minPieceIndex = maxPieceIndex - rangeOfPieces;
		}
		int rand = Random.Range(minPieceIndex, maxPieceIndex);
		Debug.Log(rand);
		GameObject randomPiece = piecePrefabs [rand];
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

