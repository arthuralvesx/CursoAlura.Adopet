using Alura.Adopet.Console.Comandos;
using Alura.Adopet.Console.Modelos;

namespace Alura.Adopet.Console
{
    [DocComando(instrucao: "list",
      documentacao: "adopet list comando que exibe no terminal o conteúdo cadastrado na base de dados da AdoPet.")]
    internal class List
    {
        public Task ExecutarAsync(string[] args)
        {
            return this.ListaDadosPetsDaAPIAsync();
        }

        private async Task ListaDadosPetsDaAPIAsync()
        {
            var httpListPet = new HttpClientPet();
            IEnumerable<Pet>? pets = await httpListPet.ListPetsAsync();
            System.Console.WriteLine("----- Lista de Pets importados no sistema -----");
            foreach (var pet in pets)
            {
                System.Console.WriteLine(pet);
            }
        }

    }
}