using UnityEngine;
using System.Collections;

public class Deck_P2 : MonoBehaviour {


    void OnMouseDown()
    {
        GameObject tmp1 = GameObject.Find("Jogador_2");
		GameObject mao = GameObject.Find("Deck_P2");
		tmp1.GetComponent<Jogador>().puxar(mao);
    }
}
