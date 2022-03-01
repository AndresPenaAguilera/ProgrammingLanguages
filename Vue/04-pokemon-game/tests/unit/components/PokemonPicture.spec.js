import { shallowMount } from '@vue/test-utils'
import PokemonPicture from '@/components/PokemonPicture'

describe('PokemonPicture component',()=>{


    test('debe hacer match con el snapshot',()=>{

        let wrapper = shallowMount( PokemonPicture,{
            props:{
                pokemonId:1,
                showPokemon:false,
            }
        } )

        expect( wrapper.html() ).toMatchSnapshot()

    })


    test('debe mostrar la imagen oculta y el pokemon 100',()=>{

        let wrapper = shallowMount( PokemonPicture,{
            props:{
                pokemonId:100,
                showPokemon:false,
            }
        } )
        const [img1, img2] = wrapper.findAll('img')

        expect( img1.exists() ).toBeTruthy()
        expect( img2 ).toBe(undefined)
        expect( img1.classes('hidden-pokemon') ).toBeTruthy()

        const srcExpect = 'https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/dream-world/100.svg'

        expect( img1.attributes('src') ).toBe( srcExpect )

    })



    test('debe mostrar si showPokemon: true',()=>{

        let wrapper = shallowMount( PokemonPicture,{
            props:{
                pokemonId:100,
                showPokemon:true,
            }
        } )
        const img = wrapper.find('img')

        expect( img.exists() ).toBeTruthy()
        expect( img.classes('fade-in') ).toBeTruthy()

    })
})