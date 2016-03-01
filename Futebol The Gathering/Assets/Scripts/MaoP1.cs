using UnityEngine;
using System.Collections;

public class MaoP1 : MonoBehaviour
{
	public bool ocupado = false;

	public bool getBool(){
		return ocupado;
	}

	public void setBool( bool bo){
		ocupado = bo;
	}
}

