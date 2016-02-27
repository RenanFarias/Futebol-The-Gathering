using UnityEngine;
using System.Collections;
using System;

public class Carta : MonoBehaviour{

	private string nome;
	private int passe;
	private int defesa;
	private int ataque;
	public bool isbonus;
	//public bool isMoto;
	//public bool vira;
	public Texture2D frente;
	public Texture2D verso;


	//Set e get do nome
	public void setNome(string name){
		nome = name;
	}
	public string getNome(){
		return nome;
	}


	//Set e get de ataque
	public void setAtaque(int atk){
		ataque = atk;
	}
	public int getAtaque(){
		return ataque;
	}


	//Set e get de defesa
	public void setDefesa(int def){
		defesa = def;
	}
	public int getDefesa(){
		return defesa;
	}


	//Set e get de passe
	public void setPasse(int pass){
		passe = pass;
	}
	public int getPasse(){
		return passe;
	}

}