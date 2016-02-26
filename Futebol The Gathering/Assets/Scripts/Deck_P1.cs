using UnityEngine;
using System.Collections;

public class Deck_P1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        GameObject[] tmp1 = GameObject.FindGameObjectsWithTag("Jogador_1");
        tmp1[0].GetComponent<Jogador>().puxar();
    }
}
