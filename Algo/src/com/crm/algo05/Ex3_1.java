/**
 * 
 */
package com.crm.algo05;

import java.util.Scanner;

/**
 * Exercice 3.1 : Rechercher un nombre dans un tableau
 */

/**
 * @author Joanna
 *
 */
public class Ex3_1 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner sc = new Scanner(System.in);

		int[] tablow = { 41, 42, 43, 44, 45, 46, 47, 48, 49, 50 };

		int choix = 0;

		System.out.println("Saisir un nombre entre 41 et 50 inclus");

		if (sc.hasNextInt()) {

			choix = sc.nextInt();

			if (choix > 40 && choix <= 50) {

				for (int i = 0; i < tablow.length; i++) {
					if (tablow[i] == choix) {
						System.out.println("L'indice correspondant est : " + i);
					}

				}
			} else {
				System.out.println("Non trouvé");
			}
		} else {
			System.out.println("Ceci n'est pas un nombre entier");
		}

		sc.close();
	}

}
