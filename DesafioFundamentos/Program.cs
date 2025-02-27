﻿using DesafioFundamentos.Models;
using static System.Console;

// Coloca o encoding para UTF8 para exibir acentuação
OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                  "\nDigite o preço inicial:");
precoInicial = Convert.ToDecimal(Console.ReadLine());

WriteLine("\nAgora digite o preço por hora:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Clear();
    WriteLine("Digite a sua opção:");
    WriteLine("1 - Cadastrar veículo");
    WriteLine("2 - Remover veículo");
    WriteLine("3 - Listar veículos");
    WriteLine("4 - Encerrar");

    switch (ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            
            exibirMenu = false;
            break;

        default:
            WriteLine("Opção inválida");
            break;
    }

    WriteLine("Pressione uma tecla para continuar");
    ReadLine();
}

WriteLine("O programa se encerrou." +
    "Até breve!");
