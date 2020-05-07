/**
 * 
 */
package com.crm.algo05;

import java.util.Scanner;

/**
 * @author Joanna
 *
 */
public class Ex3_2 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		// TODO Auto-generated method stub

		Scanner sc = new Scanner(System.in);
		int occurrence = 0;
		char c;
		String str = ".";

		System.out.println("Veuillez saisir une cha�ne de caract�re se terminant par un point (.) :");
		str = sc.nextLine();

		if (str.endsWith(".")) {

			System.out.println("Veuillez saisir un caract�re � rechercher :");
			c = sc.next().charAt(0);

			if (str.equals(".")) {
				System.out.println("La phrase est vide");
			}

			for (int i = 0; i < str.length(); i++) {
				if (str.charAt(i) == c) {
					occurrence++;
				}
			}
			if (occurrence > 0) {
				System.out.println("La lettre est pr�sente " + occurrence + " fois");
			} else {
				System.out.println("La lettre n'est pas pr�sente");
			}

		} else if (str.contentEquals("") || str.contains(" ")) {

			System.out.println("La phrase n'est pas pr�sente");

		} else {

			System.out.println("La phrase ne se termine pas par un point");

		}

		sc.close();
	}

}
