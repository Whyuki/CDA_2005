/**
 * 
 */
package com.crm.algo05;

import java.util.Arrays;

/**
 * @author Joanna
 *
 */
public class Ex3_4 {

	public static void main(String[] args) {

		int[] tableau = { 5, 9, 7, 6, 4, 2, 3, 1, 8 };

		for (int i = 0; i < tableau.length; i++) {
			System.out.println(tableau[i]);
		}
		System.out.println("Ordre croissant :");
		Arrays.sort(tableau);

		for (int i = 0; i < tableau.length; i++) {
			System.out.println(tableau[i]);
		}
	}

}
