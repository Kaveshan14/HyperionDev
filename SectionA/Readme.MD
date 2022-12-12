Good Day Student

Thank you for your submission, overall the logic and the structure is working,there's just a few changes which were required to get the program to run properly such as the calling method and incorrectly naming of a variable. Additionally, the incorrect technique was used for the second required solution.

# Spacing and Syntax

1. We need to make sure the spacing between lines of code and the spacing between characters on each line remains consistent. Line 5 for example has a spacing between the second '/' and the 'S' and line 9 does not contain this particular spacing between the '/' and 'c'. This makes the overall code much more readable and consistent.

```
    // Saves the string that would be reversed
		String myStr = "emosewA si avaJ";
 
 
	//create Method and pass and 
```

* Line 14 has the closing '}' 3 lines after the last line of code

```
		
        System.out.println("The reversed string is: " + reversed + "\nFibonacci Series of 10 numbers:0 1 1 2 3 5 8 13 21 34 ");
	

	}

```

* Line 26 below has the closing brace directly after the semi colon
```
return reverseString(myStr.substring(1)) + myStr.charAt(0);}
```
* Line 19 has the opening curling brace 1 line below function declaration
```
public static String reverse_string(String myStr)
	{
```
*Line 28 has the opening curly brace on the same line as the function declaration

```
public static <T> void function(T maxNumber) {
```
### Naming convention
*Method name in line28 should not be function and something more descriptive of the functions purpose eg. FibonacciCalc
```
public static <T> void function(T maxNumber) {
```    

# Compilation Error

1. The following compilation errors occured

```
/recursion.java:26: error: cannot find symbol
		return reverseString(myStr.substring(1)) + myStr.charAt(0);}
		       ^
  symbol:   method reverseString(String)
  location: class recursion
/recursion.java:30: error: variable maxNumber is already defined in method <T>function(T)
		int maxNumber = 10; 
		    ^
  where T is a type-variable:
    T extends Object declared in method <T>function(T)
2 errors
```
2. Line 26 calls the method incorrectly as the call doesn't match the method name 
```
return reverseString(myStr.substring(1)) + myStr.charAt(0);}
```
 * Changing the above code to the one below is required

 ```
 return reverse_string(myStr.substring(1)) + myStr.charAt(0);}
 ```

 *Line 30 creates a variable which matches the name of the parameter. This will lead to a compilation error as creation of a new variable cannot match the parameter variable name

 ```
 public static <T> void function(T maxNumber) {
		// Set it to the number of elements you want in the Fibonacci Series
		int maxNumber = 10; 
```

# Incorrect solution as recursion not used

1) The logic used within the Fibonacci method does output the first 10 numbers of the Fibonacci sequence however it does not utilize recursion and it utilizes a generic template which is not needed for such a solution. The solution also does not allow for a number to be inputted but rather an hardcoded output in line 11. Please see below code for recursion solution

```
public static int fibonacciRecursion(int n){
	if(n == 0){
		return 0;
	}
	if(n == 1 || n == 2){
			return 1;
		}
	return fibonacciRecursion(n-2) + fibonacciRecursion(n-1);
	}
```    




