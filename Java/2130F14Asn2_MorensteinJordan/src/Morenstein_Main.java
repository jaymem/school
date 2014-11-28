import java.util.Scanner;

/**
 * 
 */

/**
 * @author jayrue
 *
 */
public class Morenstein_Main {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		
		try {
			// get first complex number from user
			System.out.print("Please enter the first complex number: ");
			double a = input.nextDouble();
			double b = input.nextDouble();
			
			// create complex object with those real numbers
			Morenstein_Complex complexNum1 = new Morenstein_Complex(a, b);
			
			// get second complex number from user
			System.out.print("Please enter the second complex number: ");
			double c = input.nextDouble();
			double d = input.nextDouble();
			
			// create second complex object with those real numbers
			Morenstein_Complex complexNum2 = new Morenstein_Complex(c, d);
			
			// do arithmetic with them
			Morenstein_Complex add = Morenstein_Complex.add(complexNum1, complexNum2);
			Morenstein_Complex minus = Morenstein_Complex.subtract(complexNum1, complexNum2);
			Morenstein_Complex multiply = Morenstein_Complex.multiply(complexNum1, complexNum2);
			Morenstein_Complex divide = Morenstein_Complex.divide(complexNum1, complexNum2);
			
			// show the arithmetic
			System.out.println(Morenstein_Complex.displayFormula(a, b, c, d, "+") + add);
			System.out.println(Morenstein_Complex.displayFormula(a, b, c, d, "-") + minus);
			System.out.println(Morenstein_Complex.displayFormula(a, b, c, d, "*") + multiply);
			System.out.println(Morenstein_Complex.displayFormula(a, b, c, d, "/") + divide);
		} catch (NumberFormatException e) { //TODO: Make proper exception classes and do a better job at validation
			System.out.print("Please ensure you only enter in numbers \n" + e.getMessage());
		} catch (Exception e) {
			return;
		}
	}

}
