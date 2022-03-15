namespace examen1.modelos
{
    using System.Collections.Generic;
    public class Jugador
    {
        private int _dinero;
        private List<Tirada> _tiradas;

        public Jugador() {
            this._dinero = 300;
            this._tiradas = new List<Tirada>();
            menuPrincipal();
            Console.WriteLine(_dinero);
        }
        public void menuPrincipal(){
            int opcionJuego = 0;
            Console.Clear();
            do
            {
                Console.WriteLine("Bienvenido a este juego de dados, elige un modo de juego");
                Console.WriteLine("");
                Console.WriteLine("1. Apostar a un numero del 2-12 (apuesta x 10)");
                Console.WriteLine("2. Apostar a los extremos 2,3,4,10,11 o 12 (apuesta x 8)");
                Console.WriteLine("3. Apostar a los medios 5,6,7,8 o 9 (apuesta x 4)");
                Console.WriteLine("4. Apostar por par o impar (apuesta x 2)");
                Console.WriteLine("");
            } while (!validaJuego(4, ref opcionJuego));

            switch (opcionJuego)
            {
                case 1: 
                    unNumero2_12(ref _dinero);
                    break;
                case 2:
                    extremos(ref _dinero);
                    break;
                case 3:
                    medios(ref _dinero);
                    break;
                case 4:
                    parImpar(ref _dinero);
                    break;
            }
        }

        public bool validaJuego(int opciones, ref int opcionJuego){
            int n;
            if (int.TryParse(Console.ReadLine(), out n))
            {
                if (n <= opciones)
                {
                    opcionJuego = n;
                    return true;
                } else {
                    Console.Clear();
                    Console.WriteLine("Opcion invalida");
                    return false;
                }
            } else {
                Console.Clear();
                Console.WriteLine("El valor ingresado no es un numero");
                return false;
            }
        }

        public void unNumero2_12(ref int _dinero){
            int apuesta;
            int suma = 0;
            Tirada t = new Tirada();
            int dineroApostado;
            Console.WriteLine("Ingresa la cantidad de dinero que apostaras");
            if ( int.TryParse(Console.ReadLine(), out dineroApostado))
            {
                if (dineroApostado > _dinero)
                {
                    Console.WriteLine("no tienes dinero suficiente");
                } else {
                    Console.WriteLine($"Apostaras {dineroApostado}");
                }
            } else {
                Console.WriteLine("No ingresaste un numero valido");
            }

            Console.WriteLine("Ingresa el numero por el que apostaras");
            if ( int.TryParse(Console.ReadLine(), out apuesta))
            {
                suma = t.dado1 + t.dado2;
            } else {
                Console.WriteLine("No ingresaste un numero valido");
            }
            
            if (apuesta == suma)
            {
                _dinero = _dinero*10;
                Console.WriteLine($"¡Ganaste! Ahora tienes {_dinero}");
            } else {
                _dinero = _dinero-dineroApostado;
                Console.WriteLine($"Perdiste, ahora tienes {_dinero}");
            }
            Console.WriteLine($"Apostaste por {apuesta}. El dado 1 salio {t.dado1} y en el dado 2 {t.dado2}, sumando {suma}");
        }

        public void extremos(ref int _dinero){
            int apuesta;
            int suma = 0;
            Tirada t = new Tirada();
            int dineroApostado;
            Console.WriteLine("Ingresa la cantidad de dinero que apostaras");
            if ( int.TryParse(Console.ReadLine(), out dineroApostado))
            {
                if (dineroApostado > _dinero)
                {
                    Console.WriteLine("no tienes dinero suficiente");
                } else {
                    Console.WriteLine($"Apostaras {dineroApostado}");
                }
            } else {
                Console.WriteLine("No ingresaste un numero valido");
            }
            
            Console.WriteLine("Ingresa el numero por el que apostaras");
            if ( int.TryParse(Console.ReadLine(), out apuesta))
            {
                suma = t.dado1 + t.dado2;
            } else {
                Console.WriteLine("No ingresaste un numero valido");
            }
            
            if (apuesta == 2 || apuesta == 3 || apuesta == 4 || apuesta == 10 ||apuesta == 11 || apuesta == 12)
            {
                _dinero = _dinero*8;
                Console.WriteLine($"¡Ganaste! Ahora tienes {_dinero}");
            } else {
                _dinero = _dinero-dineroApostado;
                Console.WriteLine($"Perdiste, ahora tienes {_dinero}");
            }
            Console.WriteLine($"Apostaste por {apuesta}. El dado 1 salio {t.dado1} y en el dado 2 {t.dado2}, sumando {suma}");
        }

        public void medios(ref int _dinero){
            int apuesta;
            int suma = 0;
            Tirada t = new Tirada();
            int dineroApostado;
            Console.WriteLine("Ingresa la cantidad de dinero que apostaras");
            if ( int.TryParse(Console.ReadLine(), out dineroApostado))
            {
                if (dineroApostado > _dinero)
                {
                    Console.WriteLine("no tienes dinero suficiente");
                } else {
                    Console.WriteLine($"Apostaras {dineroApostado}");
                }
            } else {
                Console.WriteLine("No ingresaste un numero valido");
            }
            Console.WriteLine("Ingresa el numero por el que apostaras");
            if ( int.TryParse(Console.ReadLine(), out apuesta))
            {
                suma = t.dado1 + t.dado2;
            } else {
                Console.WriteLine("No ingresaste un numero valido");
            }
            
            if (apuesta == 5 || apuesta == 6 || apuesta == 7 || apuesta == 8 || apuesta == 9)
            {
                _dinero = _dinero*4;
                Console.WriteLine($"¡Ganaste! Ahora tienes {_dinero}");
            } else {
                _dinero = _dinero-dineroApostado;
                Console.WriteLine($"Perdiste, ahora tienes {_dinero}");
            }
            Console.WriteLine($"Apostaste por {apuesta}. El dado 1 salio {t.dado1} y en el dado 2 {t.dado2}, sumando {suma}");
        }

        public void parImpar(ref int _dinero){
            int apuesta;
            int suma = 0;
            Tirada t = new Tirada();
            int dineroApostado;
            Console.WriteLine("Ingresa la cantidad de dinero que apostaras");
            if ( int.TryParse(Console.ReadLine(), out dineroApostado))
            {
                if (dineroApostado > _dinero)
                {
                    Console.WriteLine("no tienes dinero suficiente");
                } else {
                    Console.WriteLine($"Apostaras {dineroApostado}");
                }
            } else {
                Console.WriteLine("No ingresaste un numero valido");
            }
            Console.WriteLine(@"Ingresa el numero por el que apostaras
            1.- Impar
            2.- Par");
            if ( int.TryParse(Console.ReadLine(), out apuesta))
            {
                suma = t.dado1 + t.dado2;
            } else {
                Console.WriteLine("No ingresaste un numero valido");
            }
            
            if (suma%2 == 0 && apuesta == 2 || suma%2 != 0 && apuesta ==1)
            {
                _dinero = _dinero*4;
                Console.WriteLine($"¡Ganaste! Ahora tienes {_dinero}");
            } else {
                _dinero = _dinero-dineroApostado;
                Console.WriteLine($"Perdiste, ahora tienes {_dinero}");
            }
            Console.WriteLine($"Apostaste por {apuesta}. El dado 1 salio {t.dado1} y en el dado 2 {t.dado2}, sumando {suma}");
        }
    }
}