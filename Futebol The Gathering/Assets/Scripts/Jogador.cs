using UnityEngine;
using System.Collections;

public class Jogador : MonoBehaviour {
	private int pontos;
	public GameObject[] deck;
    private int posicao;


	// Use this for initialization
	void Start () {
		deck = new GameObject[20];

		//posição da proxima carta a ser puxada no deck
		posicao = 5;

		

	}
    public void mao(string player)
    {
        string strTmp;
        //passando as cartas do deck para a mao do jogador 
        for (int i = 0; i < 5; i++)
        {
            GameObject tmp = (GameObject)GameObject.Instantiate(deck[i]);
            strTmp = ("Table_Model" + "/" + player+ "_" + (i + 1));
           tmp.transform.position = GameObject.Find(strTmp).transform.position;
        }
        
       
    }
	//set e get de Pontos
	public void setPontos(int pts){
		pontos += pts;
	}

	public int getPontos(){
		return pontos;
	}


	public void setDeck(GameObject[] dk){
		deck = dk;
	}



    public void descarta(GameObject card) {
        Destroy(card);
    }


	public void puxar(GameObject mao) {
        if (posicao <= deck.Length)
        {
			    GameObject tmp =(GameObject) GameObject.Instantiate(deck[posicao]);
			    tmp.transform.position = mao.transform.position;
			    posicao++;			    
				//mao.GetComponent<MaoP1> ().setBool (true);		
			
        }
    }



}
