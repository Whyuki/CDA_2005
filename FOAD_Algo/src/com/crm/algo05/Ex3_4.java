/**
 * 
 */
package com.crm.algo05;

/**
 * tri a bulle
 * 
 * @author Joanna
 *
 */
public class Ex3_4 {

	static void bubulle(int[] tabl) {

		int temp = 0;
		//parcours tableau
		for (int i = 0; i < tabl.length; i++) {
			//parcours tableau de l'indice 1 à length-1
			for (int j = 1; j < (tabl.length - 1); j++) {
				//comparaison index[1] à index [0], [2] à [1] etc..
				if (tabl[j-1] > tabl[j]) {
					//swap
					temp = tabl[j-1];
					tabl[j-1] = tabl[j];
					tabl[j] = temp;
				}
			}

		}

	}

	public static void main(String[] args) {

		int[] tableau = { 5, 9, 7, 6, 4, 2, 3, 1, 8 };
		System.out.println("avant tri :");

		for (int i = 0; i < tableau.length; i++) {
			System.out.println(tableau[i]);
		}

		bubulle(tableau);

		System.out.println("tri croissant :");

		for (int i = 0; i < tableau.length; i++) {
			System.out.println(tableau[i]);
		}
	}

}
