using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class Variables : MonoBehaviour {
	public int m; 
	public int o;
	public int v;
	public int c;
	public int p;
	public int t;
	public int masaF;
	public int consumo;

	public int [][] fConsumo;
	char[] delimetersChars = {';','.'};
	public string[] fConsumoL;
	public TextAsset csv;


	void Awake (){
		
		p = 2000;
		c = 5000;
		t = 1000;
		v = 100;
		o = 1000;
		CalcularMasa ();
		fConsumoL = csv.ToString().Split(delimetersChars);

		for (int i = 0; i < 9; i++) {
			for (int j = 0; j < 9; j++){
				fConsumo[i][j] = Int32.Parse(fConsumoL[0]);
			}
		}
	}
	public void CalcularMasa (){
		masaF = p * o * v * c * t;
	}
	public void GastarCombustible(){
		//consumo = Fconsumo[0] * (masaF / 1000000);
		c -= consumo;
	}
}
