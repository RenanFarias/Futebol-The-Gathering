using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class GameManager : MonoBehaviour {

	public bool turn = true;
	public GameObject camera;
	public Text uiTurn;
	public Text p1;
	public Text p2;

	// Use this for initialization
	void Start () {
		camera = GameObject.Find("Main Camera");
		GameObject temp = GameObject.Find ("Point1");
		camera.transform.position = temp.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
		if (turn == true) {
			GameObject temp = GameObject.Find ("Point1");
			camera.transform.position = temp.transform.position;	
			uiTurn.text = "Vez do Jogador 1  ";

		}

		if (turn == false) {
			GameObject temp = GameObject.Find ("Point2");
			camera.transform.position = temp.transform.position;		
			//Text uiTurn = GameObject.Find ("turns");
			uiTurn.text = "Vez do Jogador 2  ";
		}
	}
}
