using UnityEngine;
using System.Collections;

public class Jogador : MonoBehaviour {
	
	private int pontos;
	public GameObject[] deck;
	public GameObject[] mao;
    private int posicao;


    // Use this for initialization
    void Start () {
        deck = new GameObject[20];
        mao = new GameObject[5];

		pontos = 0;

        //posição da proxima carta a ser puxada no deck
        posicao = 5;

        //passando as cartas do deck para a mao
       /* for (int i = 0; i < 5; i++) {
            GameObject tmp = (GameObject)GameObject.Instantiate(deck[i]);
            mao[i] = tmp;
        }*/
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//seta os pontos do jogador
	public void setPontos(int pts){
		pontos += pts;
	}

	//seta o deck
	public void setDeck(GameObject[] dk){
		deck = dk;
	}

	//destroi a carta *tira ela do jogo*
	public void descarta(GameObject card) {
		Destroy(card);
	}

	//retira uma carta do deck e a cria no tabuleiro
	public void puxar(GameObject panel) {
		if (posicao <= deck.Length){
			GameObject tmp =(GameObject) GameObject.Instantiate(deck[posicao]);
			tmp.transform.SetParent (this.transform.parent);
			tmp.AddComponent<Draggable> ();
			posicao++;
		}
	}

}
