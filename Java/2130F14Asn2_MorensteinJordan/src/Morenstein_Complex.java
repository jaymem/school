/**
 * 
 */

/**
 * @author jayrue
 *
 */
public class Morenstein_Complex implements Cloneable{

	/**
	 * 
	 */
	private double realPart;
	private double imaginaryPart;
	
	/**
	 * Create a complex object for number 0
	 */
	public Morenstein_Complex() {
		this(0.0, 0.0);
	}

	/**
	 * Create a complex object using realnumbers provided by param
	 * 
	 * @param realPart
	 * @param imaginaryPart
	 */
	public Morenstein_Complex(double realPart, double imaginaryPart) {
		super();
		this.realPart = realPart;
		this.imaginaryPart = imaginaryPart;
	}

	/**
	 * Create a complex object using one realnumber and 0 for the imaginary part
	 * 
	 * @param realPart
	 */
	public Morenstein_Complex(double realPart) {
		super();
		this.realPart = realPart;
		this.imaginaryPart = 0;
	}

	/**
	 * @return the realPart
	 */
	public double getRealPart() {
		return realPart;
	}

	/**
	 * @return the imaginaryPart
	 */
	public double getImaginaryPart() {
		return imaginaryPart;
	}

	/* (non-Javadoc)
	 * @see java.lang.Object#toString()
	 */
	@Override
	public String toString() {
		if (this.imaginaryPart == 0) 
			return "a = " + realPart;
		else
			return this.realPart + " + " + this.imaginaryPart + "i";
	}
	
	/**
	 * 
	 * @param a the realPart
	 * @param b the imaginaryPart
	 * @return Complex Object
	 */
	public static Morenstein_Complex add(Morenstein_Complex a, Morenstein_Complex b) {
		return new Morenstein_Complex(
					( a.getRealPart() + b.getRealPart() ),
					( a.getImaginaryPart() + b.getImaginaryPart() )
				);
	}
	
	/**
	 * 
	 * @param a the realPart
	 * @param b the imaginaryPart
	 * @return Complex Object
	 */
	public static Morenstein_Complex subtract(Morenstein_Complex a, Morenstein_Complex b) {
		return new Morenstein_Complex(
					( a.getRealPart() - b.getRealPart() ),
					( a.getImaginaryPart() - b.getImaginaryPart() )
				);
	}
	
	/**
	 * 
	 * @param a the realPart
	 * @param b the imaginaryPart
	 * @return Complex Object
	 */
	public static Morenstein_Complex multiply(Morenstein_Complex a, Morenstein_Complex b) {
		return new Morenstein_Complex(
					( ( a.getRealPart() * b.getRealPart() ) - ( a.getImaginaryPart() * b.getImaginaryPart() ) ),
					( ( a.getImaginaryPart() * b.getRealPart() ) + ( a.getRealPart() * b.getImaginaryPart() ) )
				);
	}
	
	/**
	 * 
	 * @param a the realPart
	 * @param b the imaginaryPart
	 * @return Complex Object
	 */
	public static Morenstein_Complex divide(Morenstein_Complex a, Morenstein_Complex b) {
		// TODO: change b to the power of two, clean up formula
		return new Morenstein_Complex(
					( (a.getRealPart() * b.getRealPart()) + (a.getImaginaryPart() * b.getImaginaryPart()) )
							/ 
					( b.getRealPart() * b.getRealPart() ) + ( b.getImaginaryPart() * b.getImaginaryPart() ),
					( ( a.getImaginaryPart() * b.getRealPart() ) - ( a.getRealPart() * b.getImaginaryPart() ) )
						/
					( (b.getRealPart() * b.getRealPart()) + (b.getImaginaryPart() * b.getImaginaryPart()) )
				);
	}
	
	public static String displayFormula(double a, double b, double c, double d, String symbol) {
		return "(" + a + " + " + b + "i)" + symbol + "(" + c + " + " + d + "i) = ";
	}
}
