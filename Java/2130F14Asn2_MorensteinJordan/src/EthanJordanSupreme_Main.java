import java.util.InputMismatchException;
import java.util.Scanner;

import static java.lang.System.*;

/**
 * A team collaboration compiled and built by Ethan Duprey Spindal
 * and also Jordan Michael Morenstein
 *
 * email: jmorenstein@georgebrown.ca
 * email: eduprey@georgebrown.ca
 */

/**
 * @author Jordan Michael Morenstein 100721333
 * @author Ethan Duprey Spindel 100929720
 */
public class EthanJordanSupreme_Main {

    /**
     * @param args
     */

    private static double a;
    private static double b;
    private static double c;
    private static double d;
    private static EthanJordanSupreme_Complex complexNum1, complexNum2;
    private static Scanner input = new Scanner(in);

    public static void main(String[] args){
        for (;;) {
            try {
                // get first complex number from user
                System.out.print("Please enter the first complex number: ");
                a = input.nextDouble();
                b = input.nextDouble();

                // get second complex number from user
                System.out.print("Please enter the second complex number: ");
                c = input.nextDouble();
                d = input.nextDouble();
                break;
            }catch (InputMismatchException e) {
                System.out.println("Please try again," +
                        " this time make sure you enter a proper double");
                input.nextLine();
            }
        }

        // create complex object with those real numbers
        complexNum1 = new EthanJordanSupreme_Complex(a, b);
        complexNum2 = new EthanJordanSupreme_Complex(c, d);

        // do arithmetic with them
        EthanJordanSupreme_Complex add = EthanJordanSupreme_Complex.add(complexNum1, complexNum2);
        EthanJordanSupreme_Complex minus = EthanJordanSupreme_Complex.subtract(complexNum1, complexNum2);
        EthanJordanSupreme_Complex multiply = EthanJordanSupreme_Complex.multiply(complexNum1, complexNum2);
        EthanJordanSupreme_Complex divide = EthanJordanSupreme_Complex.divide(complexNum1, complexNum2);
        EthanJordanSupreme_Complex absolute = EthanJordanSupreme_Complex.absolute(complexNum1, complexNum2);

        System.out.println("\nHere is an example run of Ethan Duprey and Jordan Morensteins COMP 2130 Assignment 2:");
        System.out.println("\nYour results are here for you:");
        System.out.println("**********************************************");

        // show the arithmetic
        System.out.println(EthanJordanSupreme_Complex.displayFormula(a, b, c, d, "+") + add.toString());
        System.out.println(EthanJordanSupreme_Complex.displayFormula(a, b, c, d, "-") + minus.toString());
        System.out.println(EthanJordanSupreme_Complex.displayFormula(a, b, c, d, "*") + multiply.toString());
        System.out.println(EthanJordanSupreme_Complex.displayFormula(a, b, c, d, "/") + divide.toString());
        System.out.println(EthanJordanSupreme_Complex.displayFormula(a, b, c, d, "|") + absolute.toString());
        
        System.out.println("**********************************************");
    }

}
