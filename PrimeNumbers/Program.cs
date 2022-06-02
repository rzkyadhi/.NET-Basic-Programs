// See https://aka.ms/new-console-template for more information
using System;

class Program {
    static void Main() {
        Console.WriteLine("Enter a number : ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (isPrime(number)) {
            Console.WriteLine(number + " is a prime number");
        } else {
            Console.WriteLine(number + " is not a prime number");
        }
    }

    
    public static bool isPrime(int n) {
        if (n <= 1) {
            return false;
        } else if (n == 2) {
            return true;
        }
        for (int i = 2; i < n; i++) {
            if (n % i == 0) {
                return false;
            }
        }
        return true;
    }
}
