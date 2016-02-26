using UnityEngine;
using System.Collections;

public class Jogador : MonoBehaviour {
	private int pontos;
	public GameObject[] deck;
	private GameObject[] mao;
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

   public GameObject puxar() {
        if (posicao - 1 <= deck.Length)
        {
            posicao++;
            return deck[posicao - 1];
        }
        else
            return null;
    }

	// Use this for initialization
	void Start () {
        deck = new GameObject[20];

        //posição da proxima carta a ser puxada no deck
        posicao = 5;

        //passando as cartas do deck para a mao
        mao = new GameObject[6];
        for (int i = 0; i < 5; i++) {
            mao[i] = deck[i];
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
