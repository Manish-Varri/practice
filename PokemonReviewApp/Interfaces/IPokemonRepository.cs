using PokemonReviewApp.Model;

namespace PokemonReviewApp.Interfaces
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemons();
        Pokemon GetPokemon(int id);
        Pokemon GetPokemon(string name);
        //Decimal GetPokemonRating(int pokeid);
        bool PokemonExists(int pokeid);
    }
}
