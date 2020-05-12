/**
 * 
 */
package com.crm.algo05;

import java.util.Scanner;

/**
 * Recherche par dichotomie d'un �l�ment dans un tableau class�
 * 
 * @author Joanna
 *
 */
public class Ex3_7 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		String[] tableau = { "agathe", "berthe", "chlo�", "cun�gonde", "olga", "raymonde", "sidonie" };

		String prenom = "";

		int min = 0, max = tableau.length - 1;
		int mid = (min + max) / 2;
		boolean present = false;

		Scanner sc = new Scanner(System.in);

		System.out.println("Saisir un pr�nom");
		prenom = sc.nextLine();

		while (present == false && min < max) {

			if (prenom.compareTo(tableau[mid]) == 0) { // si trouv� :
				present = true;
				break;

			} else if (prenom.compareTo(tableau[mid]) < 0) { // si avant
				max = mid - 1;

			} else { // si apr�s
				min = mid + 1;
			}
			mid = (min + max) / 2;
		}

		if (prenom.equals(tableau[mid])) {
			System.out.println("Pr�nom trouv� � la case n�" + (mid + 1));
		} else {
			System.out.println("Pr�nom non trouv�");
		}
		sc.close();
	}

}
