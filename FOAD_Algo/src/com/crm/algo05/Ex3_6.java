/**
 * 
 */
package com.crm.algo05;

import java.util.Scanner;

/**
 * Le pendu
 * 
 * @author Joanna
 *
 */
public class Ex3_6 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		String mot = "";
		boolean present = false;
		int tentative = 6;
		boolean end = false;

		System.out.println("Joueur 1 : Proposez un mot (min 5 caractères !) :");
		mot = sc.nextLine();

		if (mot.length() >= 5) {

			char[] devine = mot.toCharArray();
			for (int i = 0; i < devine.length; i++) {
				devine[i] = '_';
				System.out.print(devine[i]+" ");
			}
			System.out.println();
			while (tentative > 0 && end == false) {

				System.out.println("Joueur 2 : Saisir une lettre");

				char lettre = sc.next().charAt(0);

				for (int i = 0; i < devine.length; i++) {

					if (mot.charAt(i) == lettre) {
						devine[i] = lettre;
						present = true;
					}

				}
				if (present == true) {
					System.out.println("Lettre présente");
				} else {
					System.out.println("Lettre non présente");
					tentative--;
					System.out.println(tentative + " tentative(s) restante(s)");
				}
				for (int i = 0; i < devine.length; i++) {
					System.out.print(devine[i]+" ");
				}
				System.out.println();
				

				for (int i = 0; i < devine.length; i++) {
					if (devine[i] == '_') {
						end = false;
						break;
					} else {
						end = true;
					}
				}
				present = false;
			}

			if (tentative == 0 || end == true) {
				System.out.println("FIN");
				if (tentative == 0) {
					System.out.println("DEFAITE");
					System.out.println("Le mot était : " + mot);
				}
				if (tentative > 0 && end == true) {
					System.out.println("VICTOIRE");
				}
			}
		} else {
			System.out.println("Ce mot fait moins de 5 caractères");
		}
		sc.close();
	}
}
