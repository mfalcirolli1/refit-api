using Refit;
using RefitApi.Interface;
using System;
using System.Threading.Tasks;

namespace RefitApi
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var cepClient = RestService.For<IAPIService>("https://viacep.com.br");
            Console.WriteLine("Digite o CEP: ");
            var cep = Console.ReadLine();

            var address = await cepClient.GetAddressInformation(cep);

            Console.WriteLine($"Endereço: {address.Logradouro}");
        }
    }
}
