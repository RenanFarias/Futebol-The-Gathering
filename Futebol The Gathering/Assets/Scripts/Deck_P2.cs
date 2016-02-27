using UnityEngine;
using System.Collections;

public class Deck_P2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnMouseDown()
    {
        GameObject[] tmp1 = GameObject.FindGameObjectsWithTag("Jogador_2");
		GameObject[] tmp2 = GameObject.FindGameObjectsWithTag("HandP2");
		tmp1[0].GetComponent<Jogador>().puxar(tmp2[0]);
    }
}
