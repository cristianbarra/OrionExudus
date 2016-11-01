using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EventsGenerator : MonoBehaviour {

	public GameObject preguntas;
	void Start(){
		//preguntas = GameObject.Find ("Evento");
	}

	public void MostrarEvento(){
		preguntas.SetActive(true);
	}
	public void CambiarVariables(){
		
	}
}
