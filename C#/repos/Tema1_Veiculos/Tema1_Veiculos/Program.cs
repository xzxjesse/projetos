using System;
using Tema1_Veiculos.Classes;
using Tema1_Veiculos.Enumerados;

namespace Tema1_Veiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Selecione a categoria do veículo:");
                Console.WriteLine("1. Veículos Terrestres");
                Console.WriteLine("2. Veículos Aéreos");
                Console.WriteLine("3. Veículos Marítimos");
                Console.WriteLine("0. Sair");

                int categoria = int.Parse(Console.ReadLine());

                if (categoria == 0) break;

                switch (categoria)
                {
                    case 1:
                        MenuTerrestre();
                        break;
                    case 2:
                        MenuAereo();
                        break;
                    case 3:
                        MenuMaritimo();
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }

        static void MenuTerrestre()
        {
            Console.WriteLine("Selecione o tipo de veículo terrestre:");
            Console.WriteLine("1. Carro");
            Console.WriteLine("2. Bicicleta");

            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    TestarCarro();
                    break;
                case 2:
                    TestarBicicleta();
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }

        static void TestarCarro()
        {
            Carro carro = new("Modelo A", "Marca X", 2022, 4, TipoTerreno.Rodovia, 500, TipoCombustivel.Gasolina);
            carro.Acelerar();
            carro.Parar();
            carro.Estacionar();
            carro.AbrirPortaMalas();
        }

        static void TestarBicicleta()
        {
            Bicicleta bicicleta = new("Modelo B", "Marca Y", 2023, 2, TipoTerreno.Terra, true);
            bicicleta.Acelerar();
            bicicleta.TrocarMarcha();
            bicicleta.Parar();
            bicicleta.Estacionar();
        }

        static void MenuAereo()
        {
            Console.WriteLine("Selecione o tipo de veículo aéreo:");
            Console.WriteLine("1. Avião");
            Console.WriteLine("2. Helicóptero");

            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    TestarAviao();
                    break;
                case 2:
                    TestarHelicoptero();
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }

        static void TestarAviao()
        {
            Aviao aviao = new("Boeing 747", "Boeing", 2022, 35000, TipoVoo.Comercial, 4, TipoCombustivel.AvGas);
            aviao.Decolar();
            aviao.Acelerar();
            aviao.Pousar();
        }

        static void TestarHelicoptero()
        {
            Helicoptero helicoptero = new("Bell 206", "Bell Helicopter", 2020, 15000, TipoVoo.Resgate, TipoCombustivel.QueroseneDeAviacao);
            helicoptero.Decolar(); 
            helicoptero.Acelerar();
            helicoptero.AtivarModoResgate();
            helicoptero.DesativarModoResgate();
            helicoptero.Pousar();
        }

        static void MenuMaritimo()
        {
            Console.WriteLine("Selecione o tipo de veículo marítimo:");
            Console.WriteLine("1. Navio");
            Console.WriteLine("2. Lancha");

            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    TestarNavio();
                    break;
                case 2:
                    TestarLancha();
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }

        static void TestarNavio()
        {
            Navio navio = new("Modelo E", "Marca V", 2019, 300, TipoCarga.CargaValiosa, TipoCombustivel.GasNaturalLiquefeito, 2, TipoCasco.Catamara);
            navio.Acelerar();
            navio.LevantarAncora();
            navio.Atracar();
            navio.Descarregar();
            navio.Ancorar();
        }

        static void TestarLancha()
        {
            Lancha lancha = new("Modelo F", "Marca U", 2018, 8, TipoCombustivel.Nuclear, 0, TipoCasco.Monocasco);
            lancha.Acelerar();
            lancha.Ancorar();
            lancha.Desembarque();
        }
    }
}
