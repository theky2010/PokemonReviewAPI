using PokemonReview.Models;

namespace PokemonReview.Interfaces
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemons();
        bool PokemonExists(int pokeId);
        Pokemon GetPokemon(int id);
        decimal GetPokemonRating(int pokeId);
    }
}
