import getPokemonOptions, { getPokemons, getPokemonNames } from '@/helpers/getPokemonOptions'
import { pokemons } from '../mocks/pokemons.mock'

describe('getPokemonOptions helpers',()=>{

    test('debe retornar un arreglo de numeros',()=>{
        
        const pokemons = getPokemons()

        expect(pokemons).toHaveLength(650)
        expect(pokemons[0]).toBe(1)
        expect(pokemons[649]).toBe(650)
    })

    test('debe retornar un arreglo de 4 elementos con nombres de pokemon', async()=>{

        const pokemonNames = await getPokemonNames([1,2,3,4])

        expect( pokemonNames ).toMatchObject( pokemons )

       
    })

    test('getPokemonOptions debe retornar arreglo mezclado',async ()=>{

        const pokemons = await getPokemonOptions()
        
        expect( pokemons ).toHaveLength(4)

        expect( pokemons ).toEqual(
            [
                { name: expect.any(String), id: expect.any(Number) },
                { name: expect.any(String), id: expect.any(Number) },
                { name: expect.any(String), id: expect.any(Number) },
                { name: expect.any(String), id: expect.any(Number) }
            ]
        )



    })

})