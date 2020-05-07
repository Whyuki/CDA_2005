/**
 * 
 */
package com.crm.algo05;

import java.util.Scanner;

/**
 * @author Joanna
 *
 */
public class Ex3_3 {

	public static void main(String[] args) {

		Scanner sc = new Scanner(System.in);

		int occurrence = 0;

		System.out.println("Veuillez saisir un texte d'au moins 120 caractères :");
		String txt = sc.nextLine().toLowerCase();

		char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r',
				's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

		if (txt.length() >= 120) {

			System.out.println("Nombres de lettres :");

			for (int i = 0; i < alphabet.length; i++) {
				for (int j = 0; j < txt.length(); j++) {
					if (txt.charAt(j) == alphabet[i]) {
						occurrence++;
					}
				}
				System.out.println("La lettre " + alphabet[i] + " est présente " + occurrence + " fois");
				occurrence = 0;
			}

		} else {

			System.out.println("Le texte contient moins de 120 caractères");

		}

		sc.close();

	}

}
