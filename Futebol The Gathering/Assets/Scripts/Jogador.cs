using UnityEngine;
using System.Collections;

public class Jogador : MonoBehaviour {
	private int pontos;
	private GameObject[] deck;
	private GameObject[] descarte;
	private GameObject[] mao;

	public void setPontos(int pts){
		pontos = pts;
	}
	public void setDeck(GameObject[] dk){
		deck = dk;
	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
