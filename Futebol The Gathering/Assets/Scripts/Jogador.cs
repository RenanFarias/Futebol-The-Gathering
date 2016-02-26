using UnityEngine;
using System.Collections;

public class Jogador : MonoBehaviour {
	private int pontos;
	public GameObject[] deck;
	public GameObject[] mao;
    private int posicao;

	public void setPontos(int pts){
		pontos += pts;
	}
	public void setDeck(GameObject[] dk){
		deck = dk;
	}

    public void descarta(GameObject card) {
        Destroy(card);
    }

   public void puxar() {
        if (posicao <= deck.Length)
        {
            GameObject tmp =(GameObject) GameObject.Instantiate(deck[posicao]);
            posicao++;

        }

    }

    // Use this for initialization
    void Start () {
        deck = new GameObject[20];
        mao = new GameObject[5];

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
}
