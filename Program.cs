using System;

public class Empresa{
    
    static void Main(){
        Console.WriteLine("************************************");
        Console.WriteLine("         EMPRESA IMPRENTA");
        Console.WriteLine("************************************");
        Console.WriteLine("Ingresa el departamento al que perteneces: ");
        Console.WriteLine("1.- A");
        Console.WriteLine("2.- B");
        Console.WriteLine("3.- C");
        if (int.TryParse(Console.ReadLine(), out int depa)){
            Console.WriteLine("---------------------------------------------");
            if(depa >= 1 && depa <= 3){
                Console.WriteLine("Ingresa tu antiguedad en meses: ");
                if(int.TryParse(Console.ReadLine(), out int antiguedad) && antiguedad > 0){
                    Console.WriteLine("---------------------------------------------");
                    Empresa empresa = new Empresa();
                    decimal bono = empresa.CalcularBono(depa, antiguedad);
                    // Console.WriteLine($"El bono calculado es: ${bono}");
                    Console.WriteLine("¿Tiene hijos? 1.- Si   2.- No");
                    if(int.TryParse(Console.ReadLine(), out int hijos)){
                        Console.WriteLine("---------------------------------------------");
                        if(hijos == 1){
                            Console.WriteLine("Ingrese el numero de hijos que tiene:");
                            if(int.TryParse(Console.ReadLine(), out int numHijos) && numHijos >0 && numHijos <=10){
                                Console.WriteLine("---------------------------------------------");
                                decimal regalo = empresa.CalcularRegaloNavideno(numHijos);
                                Console.WriteLine("///////////////////////////////////////////////////////////////////////////");
                                Console.WriteLine($"El monto para los regalos de sus {numHijos} hijos es de : ${regalo}");
                                Console.WriteLine($"Bono: ${bono}");
                                Console.WriteLine($"Total a recibir: ${bono+regalo}");
                                Console.WriteLine("///////////////////////////////////////////////////////////////////////////");
                            }else{
                                Console.WriteLine("El dato ingresado NO ES UN NÚMERO VALIDO DE HIJOS");
                            }
                        }else if(hijos == 2){
                            Console.WriteLine("///////////////////////////////////////////////////////////////////////////");
                            Console.WriteLine("No tiene hijos, por lo tanto no recibirá más dinero aparte de su bono");
                            Console.WriteLine($"El bono total calculado es: ${bono}");
                            Console.WriteLine("///////////////////////////////////////////////////////////////////////////");
                        }else{
                            Console.WriteLine("No es una opción VALIDA");
                        }
                        
                    }else{
                        Console.WriteLine("El dato ingresado NO ES UN NÚMERO");
                    }
                }else{
                    Console.WriteLine("El dato ingresado NO ES UN NÚMERO o es Un numero negativo");
                }
            }else{
                Console.WriteLine("OPCIÓN NO VALIDA");
            }
            
        }else{
            Console.WriteLine("El dato ingresado NO ES UN NÚMERO");
        }
    }

    public decimal CalcularBono(int depa, int antiguedad){
        decimal salarioMinimo = 207.44m;
        decimal bonoEmpleado=0;

        switch ((depa, antiguedad))
        {
            case (1, var a) when a < 24:
                bonoEmpleado = salarioMinimo * 5m;
                break;
            case (1, var a) when a >= 24:
                bonoEmpleado = salarioMinimo * 8m;
                break;
            case (2, var a) when a < 36:
                bonoEmpleado = salarioMinimo * 9m;
                break;
            case (2, var a) when a >= 36:
                bonoEmpleado = salarioMinimo * 12m;
                break;
            case (3, var a) when a < 60:
                bonoEmpleado = salarioMinimo * 14m;
                break;
            case (3, var a) when a >= 60:
                bonoEmpleado = salarioMinimo * 17m;
                break;
            default:
                bonoEmpleado = 0;
                break;
        }
        // Console.WriteLine($"El bono del empleado es: ${bonoEmpleado}");
        return bonoEmpleado;
    }

    public decimal CalcularRegaloNavideno(int numhijos){
        decimal regalo = 150m;
        decimal totalRegalo = 0;

        totalRegalo = regalo * numhijos;
        return totalRegalo;
    }
    
    
}