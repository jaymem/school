/**
 * A team collaboration compiled and built by Ethan Duprey Spindal
 * and also Jordan Michael Morenstein
 */

import java.text.DecimalFormat;

/**
 * @author Jordan Michael Morenstein 100721333
 * @author Ethan Duprey Spindel 100929720
 *
 */
public class EthanJordanSupreme_Complex implements Cloneable {

    /**
     * Our properties
     */
    private double realPart;
    private double imaginaryPart;

    /**
     * Create a complex object for number 0
     */
    public EthanJordanSupreme_Complex() { this(0.0, 0.0); }

    /**
     * Create a complex object using realnumbers provided by param
     *
     * @param realPart
     * @param imaginaryPart
     */
    public EthanJordanSupreme_Complex(double realPart, double imaginaryPart) {
        super();
        this.realPart = realPart;
        this.imaginaryPart = imaginaryPart;
    }

    /**
     * Create a complex object using one realnumber and 0 for the imaginary part
     *
     * @param realPart
     */
    public EthanJordanSupreme_Complex(double realPart) {
        super();
        this.realPart = realPart;
        this.imaginaryPart = 0;
    }

    /**
     * Returns the real part of our complex number
     * @return the realPart
     */
    public double getRealPart() { return realPart; }

    /**
     * Returns the imaginary part of our complex number
     *
     * @return the imaginaryPart
     */
    public double getImaginaryPart() { return imaginaryPart; }

    /* (non-Javadoc)
     * @see java.lang.Object#toString()
     */
    @Override
    public String toString() {
        if (this.imaginaryPart == 0)
            return String.valueOf(realPart);
        else
            return this.realPart + " + " + this.imaginaryPart + "i";
    }

    public static double setDecimalPlace(String format, double equation) {
        DecimalFormat df = new DecimalFormat(format);
        String formatted = df.format(equation);

        return Double.parseDouble(formatted);
    }

    /**
     * Adds our complex numbers
     *
     * @param a the realPart
     * @param b the imaginaryPart
     * @return Complex Object
     */
    public static EthanJordanSupreme_Complex add(EthanJordanSupreme_Complex a, EthanJordanSupreme_Complex b) {
        return new EthanJordanSupreme_Complex(
                a.realPart + b.realPart,
                a.imaginaryPart + b.imaginaryPart
        );
    }

    /**
     * Subtracts our complex numbers
     *
     * @param a the realPart
     * @param b the imaginaryPart
     * @return Complex Object
     */
    public static EthanJordanSupreme_Complex subtract(EthanJordanSupreme_Complex a, EthanJordanSupreme_Complex b) {
        return new EthanJordanSupreme_Complex(
                a.realPart - b.realPart,
                a.imaginaryPart - b.imaginaryPart
        );
    }

    /**
     * Multiplies our complex numbers
     *
     * @param a the realPart
     * @param b the imaginaryPart
     * @return Complex Object
     */
    public static EthanJordanSupreme_Complex multiply(EthanJordanSupreme_Complex a, EthanJordanSupreme_Complex b) {
        return new EthanJordanSupreme_Complex(
                (a.realPart * b.realPart)  -  (a.imaginaryPart * b.imaginaryPart),
                (a.imaginaryPart * b.realPart)  +  (a.realPart * b.imaginaryPart)
        );
    }

    /**
     * Divides our complex numbers
     *
     * @param a the realPart
     * @param b the imaginaryPart
     * @return Complex Object
     */
    public static EthanJordanSupreme_Complex divide(EthanJordanSupreme_Complex a, EthanJordanSupreme_Complex b) {
        double imaginary = ((a.getImaginaryPart() * b.getRealPart())  -  (a.getRealPart() * b.getImaginaryPart()))
                            /
                         ((b.getRealPart() * b.getRealPart())  +  (b.getImaginaryPart() * b.getImaginaryPart()));
        double real = ((a.getRealPart() * b.getRealPart())  +  (a.getImaginaryPart() * b.getImaginaryPart()))
                          /
                    (b.getRealPart() * b.getRealPart())  +  (b.getImaginaryPart() * b.getImaginaryPart());

        return new EthanJordanSupreme_Complex(
                setDecimalPlace("#0.00000", real),
                setDecimalPlace("#0.0", imaginary)
        );
    }

    /**
     * Returns an absolute value of our complex numbers
     *
     * @param a the realPart
     * @param b the imaginaryPart
     * @return Math Object
     */
    public static EthanJordanSupreme_Complex absolute(EthanJordanSupreme_Complex a, EthanJordanSupreme_Complex b) {
        return new EthanJordanSupreme_Complex(
                Math.sqrt((a.realPart * a.realPart)  +  (a.imaginaryPart * a.imaginaryPart))
        );
    }

    /**
     * Returns a string representation of the complex number formulas
     *
     * @param a
     * @param b
     * @param c
     * @param d
     * @param symbol
     * @return String
     */
    public static String displayFormula(double a, double b, double c, double d, String symbol) {
        return "(" + a + " + " + b + "i)" + symbol + "(" + c + " + " + d + "i) = ";
    }
}
