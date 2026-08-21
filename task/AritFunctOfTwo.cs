using System;

namespace GestorPrincipal
{
    class Operate
    {
        public static double sum (double a, double b){
            return a + b;
        }

        public static double rest (double a, double b){
            return a - b;
        }

        public static double mult (double a, double b){
            return a * b;
        }
        public static double div (double a, double b){
            if (a == 0 ) return 0;
            return a / b;
        }
    }
}