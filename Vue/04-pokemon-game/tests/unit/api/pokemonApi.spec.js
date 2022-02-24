
import pokemonAPI from '@/api/pokemonAPI'

describe('PokemonApi', ()=>{

    test('avios debe de estar configurado el baseURL ',()=>{

        expect(pokemonAPI.defaults.baseURL).toBe('https://pokeapi.co/api/v2/pokemon')

    })


})