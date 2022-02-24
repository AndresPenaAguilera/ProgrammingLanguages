import getPokemonOptions, { getPokemons, getPokemonNames } from '@/helpers/getPokemonOptions'

describe('getPokemonOptions helpers',()=>{

    test('debe retornar un arreglo de numeros',()=>{
        
        const pokemons = getPokemons()

        expect(pokemons).toHaveLength(650)
        expect(pokemons[0]).toBe(1)
        expect(pokemons[649]).toBe(650)
    })

    test('debe retornar un arreglo de 4 elementos con nombres de pokemon', async()=>{
        
        const result = [
            { name: 'bulbasaur', id: 1 },
            { name: 'ivysaur', id: 2 },
            { name: 'venusaur', id: 3 },
            { name: 'charmander', id: 4 }
        ]

        const pokemonNames = await getPokemonNames([1,2,3,4])

        expect( pokemonNames ).toMatchObject( result )

       
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