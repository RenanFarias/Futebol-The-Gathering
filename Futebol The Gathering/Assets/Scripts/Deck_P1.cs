using UnityEngine;
using System.Collections;

public class Deck_P1 : MonoBehaviour {


    void OnMouseDown()
    {
        GameObject tmp1 = GameObject.Find("Jogador_1");
		GameObject mao = GameObject.Find("Table_Model/Deck_P1");
		tmp1.GetComponent<Jogador>().puxar(mao);
    }
}
