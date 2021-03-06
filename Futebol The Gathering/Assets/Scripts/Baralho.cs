﻿using UnityEngine;
using System.Collections;
//[ExecuteInEditMode]
public class Baralho : MonoBehaviour {

	public GameObject[] vetor; 
	public GameObject[] deck1;
	public GameObject[] deck2;

	void Awake(){
		//Instancia o vertor de cartas
		vetor = new GameObject[40];
		//Cria GameObjects Vazios que vao receber os prefabs, ser adicionados ao vetor e instanciados.
		GameObject tmp;
		//string nomeCarta;
		

		//Preenche o vetor com as cartas

		/**     IMPORTANTE
		 * Lembrar que o trecho abaixo deve ir de 
		 * 0 a N, sendo N o total de prefabas criados.
		 * */

		for(int i = 0; i < vetor.Length; i++){
			if(i<13){
				tmp = (GameObject) (Resources.Load("Prefabs/Carta_1", typeof(GameObject)));
				tmp.name = ("" + i);
                vetor[i] = tmp;
                //vetor[i] =GameObject.Instantiate (tmp);
            }
            else if(i<26){
				tmp = (GameObject) (Resources.Load("Prefabs/Carta_2", typeof(GameObject)));;
				tmp.name = ("" + i);
                vetor[i] = tmp;
                //vetor[i] = GameObject.Instantiate(tmp2);
            }
            else
            {
                tmp = (GameObject)(Resources.Load("Prefabs/Carta_3", typeof(GameObject))); ;
                tmp.name = ("" + i);
                vetor[i] = tmp;
            }
			//nomeCarta = ("Prefabs/"+i);
			//tmp = (GameObject) (Resources.Load(nomeCarta, typeof(GameObject)));;
			//vetor[vetor.Length/2-i] = GameObject.Instantiate(tmp);

		}
		/**OBSERVACAO
		 * Para que funcione corretamente,
		 * se faz necessaria a nomeacao das cartas
		 * numericamente, iniciando de 0 e indo ateh
		 * N
		 * */
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

		for (int i = vetor.Length-1; i > 0; i--)
		{
			int rnd = Random.Range(0,i);
			GameObject tmp = vetor[i];
			vetor[i] = vetor[rnd];
			vetor[rnd] = tmp;
		}

	}
	
	private void distribuir(){
		//Separa o Baralho em dois 
		//Decks 
		for(int i = 0; i <vetor.Length; i++){
			if(i<(vetor.Length/2))
				deck1[i] = vetor[i];
			else
			deck2[i-deck2.Length] = vetor[i];
		}
        //Distribui os Decks para os jogadores
        //GameObject P1 = (GameObject) GameObject.FindGameObjectWithTag("Jogador_1");
        //P1.GetComponent<Jogador>().setDeck(deck1);
        GameObject tmp1 = GameObject.Find("Jogador_1");
        tmp1.GetComponent<Jogador>().setDeck(deck1);
        tmp1.GetComponent<Jogador>().mao("P1");
        GameObject tmp2 = GameObject.Find("Jogador_2");
		tmp2.GetComponent<Jogador>().setDeck(deck2);
        tmp2.GetComponent<Jogador>().mao("P2");

    }
}
