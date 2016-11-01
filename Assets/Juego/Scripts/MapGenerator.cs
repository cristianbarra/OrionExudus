using UnityEngine;
using System.Collections;

public class MapGenerator : MonoBehaviour {
	int currentX=0;
	int yVariable = 0;
	int yVariableA = 0;
	int xRangeDown=2;
	int xRangeUp=5;
	int yRangeDown=-3;
	int yRangeUp=3;
	int xLimit=100;
	int i = 1;

	public Transform planet;
	//public Texture2D Hud;

	void Start () {
		//Crear un primer planeta que estará en el origen en el (0,0,0)
		planet.name = "Evento" + 0;
		Instantiate(planet,new Vector3(0,0,0),Quaternion.identity);
		currentX=Random.Range(xRangeDown,xRangeUp);

		//Realizar un loop. mientras no hayamos llegado a la coordenada de xLimit, seguir creando planetas
		while(currentX<xLimit){
			planet.name = "Evento" + i;
			yVariable = Random.Range (yRangeDown, yRangeUp);
			while(yVariable == yVariableA){
				yVariable = Random.Range (yRangeDown, yRangeUp);
			}
			Instantiate(planet,new Vector3(currentX,yVariable,0),Quaternion.identity);
			yVariableA = yVariable;
			currentX+=Random.Range(xRangeDown,xRangeUp);
			i++;
		}
	}
}
