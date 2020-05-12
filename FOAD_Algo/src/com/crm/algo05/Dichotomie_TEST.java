/**
 * 
 */
package com.crm.algo05;

import java.util.Scanner;

/**
 * test dichotomie formation
 * 
 * @author Joanna
 *
 */
public class Dichotomie_TEST {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		// TODO Auto-generated method stub

		int[] tableau = { 4, 8, 16, 32, 64, 128 };
		Scanner sc = new Scanner(System.in);
		System.out.println("saisir nb");
		int nb = sc.nextInt();

		int min = 0, max = tableau.length - 1;
		int mid = (min + max) / 2;

		while (nb != tableau[mid] && min < max) {
			if (nb < tableau[mid]) {
				max = mid - 1;
			} else {
				min = mid + 1;
			}
			mid = (min + max) / 2;
		}

		if (nb == tableau[mid]) {
			System.out.println("trouvé à l'indice " + mid);
			mid++;
			System.out.println("soit : à la case n° " + mid);

		}
		sc.close();
	}

}
