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

		System.out.println("Veuillez saisir un caract�re � rechercher :");
		c = sc.next().charAt(0);

		if (str.endsWith(".")) {

			if (str.equals(".")) {
				System.out.println("La phrase est vide");
			}

			for (int i = 0; i < str.length(); i++) {
				if (str.charAt(i) == c) {
					occurrence++;
				}
			}
			System.out.println("La lettre est pr�sente " + occurrence + " fois");

		} else {

			System.out.println("La phrase n'est pas pr�sente ou ne se termine pas par un point");
		}
		
		sc.close();
	}

}
