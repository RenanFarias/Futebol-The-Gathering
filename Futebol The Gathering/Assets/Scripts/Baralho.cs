using UnityEngine;
using System.Collections;
//[ExecuteInEditMode]
public class Baralho : MonoBehaviour {

	public GameObject[] vetor; 
	public GameObject[] deck1;
	public GameObject[] deck2;

	void Awake(){
		vetor = new GameObject[6];
	}
	// Use this for initialization
	void Start () {
		deck1 = new GameObject[vetor.Length/2];
		deck2 = new GameObject[vetor.Length/2];
		embaralhar();
		distribuir();
	}

	// Update is called once per frame
	void Update () {
	
	}

	private void embaralhar(){
		
	}
	
	private void distribuir(){
		for(int i = 0; i < vetor.Length/2; i++){
			deck1[i] = vetor[i];
			deck2[i] = vetor[i*2];
		}

		GameObject[] tmp1 = GameObject.FindGameObjectsWithTag("Jogador_1");
		tmp1[0].GetComponent<Jogador>().setDeck(deck1);
		GameObject[] tmp2 = GameObject.FindGameObjectsWithTag("Jogador_2");
		tmp1[0].GetComponent<Jogador>().setDeck(deck2);
	}
}
