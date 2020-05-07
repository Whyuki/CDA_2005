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

	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		
		int occurrence = 0;
		char character;
		String sentence = ".";

		System.out.println("Veuillez saisir une chaîne de caractère se terminant par un point (.) :");
		sentence = sc.nextLine();

		if (sentence.endsWith(".")) {

			System.out.println("Veuillez saisir un caractère à rechercher :");
			character = sc.next().charAt(0);

			if (sentence.equals(".")) {
				System.out.println("La phrase est vide");
			}

			for (int i = 0; i < sentence.length(); i++) {
				if (sentence.charAt(i) == character) {
					occurrence++;
				}
			}
			if (occurrence > 0) {
				System.out.println("La lettre est présente " + occurrence + " fois");
			} else {
				System.out.println("La lettre n'est pas présente");
			}

		} else if (sentence.contentEquals("") || sentence.contains(" ")) {

			System.out.println("La phrase n'est pas présente");

		} else {
			System.out.println("La phrase ne se termine pas par un point");
		}

		sc.close();
	}

}
