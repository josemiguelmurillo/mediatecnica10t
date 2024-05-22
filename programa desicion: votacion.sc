/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
     //variables
     int edad;
     int valorMatricula;
     //validacion
     Console.WriteLine("digite tu edad:");
     edad= Int32.Parse(Console.ReadLine());
     
     Console.WriteLine("digite su valor de matricula: ");
     valorMatricula = Int32.Parse(Console.ReadLine());
     
     //validacion
     if(edad >= 18){
         Console.WriteLine("felicidades, usted puede votar");
         Console.WriteLine("usted pagara de matricula:" + (valorMatricula * 0,85));
     }
  }
}
