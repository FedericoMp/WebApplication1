using System;

namespace ClassLibrary1 {
    //La clase tiene que ser publica, y una vez referenciada se puede usar
    public class Calculadora {
        //Sumar method
        public static int Sumar(string num1, string num2) {
            int n1 = Int32.Parse(num1);
            int n2 = Int32.Parse(num2);
            int suma = n1 + n2;
            return suma;
        }

        //Restar method
        public static int Restar(string num1, string num2) {
            int n1 = Int32.Parse(num1);
            int n2 = Int32.Parse(num2);
            int resta = n1 - n2;
            return resta;
        }
    }
}
