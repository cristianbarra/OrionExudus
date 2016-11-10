using UnityEngine;
using System.Collections;

public class Events : MonoBehaviour {
	public bool move = false;
	int distancia = 0;

	GameObject dios;
	GameObject [] player;

	void Start (){
		player = GameObject.FindGameObjectsWithTag ("player");
		dios = GameObject.Find ("GOD");
	}
	void OnMouseOver (){
		//Seleccionar el planeta al que te quieres mover
		if (player [0].transform.position.x < transform.position.x && !move) {
			distancia = Mathf.FloorToInt((transform.position.x - player [0].transform.position.x)*10);
			if (Input.GetMouseButtonUp (0)&& (dios.GetComponent<Variables>().c- distancia) >= 0) {
				move = true;
				dios.GetComponent<EventsGenerator>().MostrarEvento();
				dios.GetComponent<Variables> ().GastarCombustible ();
				print (transform.position.x - player [0].transform.position.x); 
			}
		}
	}
	void Update(){
		if (move){
			player [0].transform.position = Vector3.MoveTowards (player [0].transform.position,transform.position, 0.1f);
			if (player [0].transform.position == transform.position) {
				move=false;
				//Lanzar evento
				dios.GetComponent<EventsGenerator>().MostrarEvento();
			}
		}
	}
}
