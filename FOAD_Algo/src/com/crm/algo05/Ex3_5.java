/**
 * 
 */
package com.crm.algo05;

import java.util.Scanner;

/**
 * @author Joanna
 *
 */
public class Ex3_5 {

	public static void main(String[] args) {

		// TODO Auto-generated method stub
		Scanner sc = new Scanner(System.in);
		String phraseSaisie = "", phraseInverse = "";
		char c;

		System.out.println("Veuillez saisir une phrase : ");
		phraseSaisie = sc.nextLine();
		phraseSaisie = phraseSaisie.replaceAll(" ", "");
		// System.out.println(phraseSaisie);

		if (phraseSaisie.equalsIgnoreCase(".") || phraseSaisie.equalsIgnoreCase("") ) {
			System.out.println("La phrase est vide");
		} else {

			for (int i = phraseSaisie.length() - 1; i >= 0; i--) {
				c = phraseSaisie.charAt(i);
				phraseInverse = phraseInverse + c;

			}

			if (phraseSaisie.equals(phraseInverse)) {
				System.out.println("Cette phrase est un palindrome");
			} else {
				System.out.println("Cette phrase n'est pas un palindrome");
			}
		}

		sc.close();
	}

}
