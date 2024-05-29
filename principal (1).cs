/******************************************************************************
app 
-suma
+resta
-multiplicacion
-division
deber terminar la ejecucion al usuatio elegir opcon "salir"

*******************************************************************************/
using System;
using System.Threading;
class HelloWorld {
  static void Main() {
   
     // 1 pantalla bienvenida (imagen ascii)
        Console.WriteLine("          _            _           _              ");
  Console.WriteLine("   ___ __ _| | ___ _   _| | __ _  __| | ___  _ __ __ _  ");
  Console.WriteLine("  / __/ _` | |/ __| | | | |/ _` |/ _` |/ _ !| '__/ _` | ");
  Console.WriteLine(" | (_| (_| | | (__| |_| | | (_| | (_| | (_) | | | (_| | ");
   Console.WriteLine(" !___!__,_|_|!___|!__,_|_|!__,_|!__,_|!___/|_|  !__,_| ");
       Console.WriteLine("  bienvenidos a la minicalculadora"); 
       Thread.Sleep(4000); // 3 segundos = 4000 milisegundos
     // 2  mostrar menu de opciones
     Console.WriteLine("menu de opciones");
     Console.WriteLine("seleccionar la opcion deseada:");
     Console.WriteLine(" 1.  suma");
     Console.WriteLine(" 2. resta");
     Console.WriteLine(" 3. division");
     Console.WriteLine("5. salir");
     
     // 3 capturar  opcion elegida por usuario
      Console.WriteLine("numero de digitos deseado:");
      int opcion = Int32.Parse(Console.ReadLine());
     if (opcion == 5)
      goto Salir;
    

      //3.5 captura los numeros elegidos por el usuario
      Console.Write("\nDigitar numero 1:");
       int numero1 = Int32.Parse(Console.ReadLine());
       Console.Write("\nDigitar numero 2:");
        int numero2 = Int32.Parse(Console.ReadLine());
     // 4 validar opcion elegida
     
     if(opcion == 1){
         Console.WriteLine ("la suma es:"+ (numero1+numero2));
         
     }
     
     if(opcion == 2){
         Console.WriteLine ("la resta es:"+ (numero1+numero2));
         
     }
     
     if(opcion == 3){
         Console.WriteLine ("la multiplicacion es:"+ (numero1+numero2));
         
     }
     
     if (opcion== 4){
         if (numero1 != 0 || numero2 != 0){
              Console.WriteLine ("la division es :"+ (numero1/numero2));
         }
     }
     
     else{
         Console.WriteLine("No se puede dividir por cero.");
     
         
     }
    
       // 5 mostrar resultados o finalizar ejecucion 
    Salir:
        Console.WriteLine("Saliendo del programa...");
     
  }
}