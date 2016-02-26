using UnityEngine;
using System.Collections;
using System;

public class Carta : MonoBehaviour{

	private string nome;
	private int passe;
	private int defesa;
	private int ataque;
	//public bool isMoto;
	public bool vira;
	public Texture2D frente;
	public Texture2D verso;
	




	public void setAtaque(int atk){
		ataque = atk;
	}

	public int getAtaque(){
		return ataque;
	}

	public int getDefesa(){
		return defesa;
	}

	public int getPasse(){
		return passe;
	}

}