
import { shallowMount, mount } from '@vue/test-utils'
import PokemonPage from '@/pages/PokemonPage'
import { pokemons } from '../mocks/pokemons.mock'

describe('PokemonPage', ()=>{

    let wrapper
    beforeEach(()=>{
        wrapper = shallowMount( PokemonPage )

    })

    test('debe de llamar el mixPokemonArray al montar', ()=>{

        const mixPokemonArraySpy = jest.spyOn( PokemonPage.methods, 'mixPokemonArray')
        wrapper = shallowMount( PokemonPage )
        expect( mixPokemonArraySpy ).toHaveBeenCalled()


    })


    test('debe de hacer match con el snapshot cuando cargan los componentes', ()=>{

        const wrapper = shallowMount( PokemonPage,{
            data(){
                return {
                    pokemonArr: pokemons,
                    pokemon :pokemons[0],
                    showPokemon : false,
                    message: '',
                    showAnswer : false
                }
            }
        })


        expect( wrapper.html() ).toMatchSnapshot()


    })

    test('debe mostrar los componentes de PokemonPicture y PokemonOptions', ()=>{

        const wrapper = shallowMount( PokemonPage,{
            data(){
                return {
                    pokemonArr: pokemons,
                    pokemon :pokemons[0],
                    showPokemon : false,
                    message: '',
                    showAnswer : false
                }
            }
        })

        const pokemonPicture = wrapper.find('pokemon-picture-stub')

        expect( pokemonPicture.exists() ).toBeTruthy()
        expect( pokemonPicture.attributes('pokemonid') ).toBe("1")

        const pokemonOptions = wrapper.find('pokemon-options-stub')

        expect( pokemonOptions.exists() ).toBeTruthy()
        expect( pokemonOptions.attributes('pokemons') ).toBeTruthy()
        
    })



    test('debe checkAnswer validar estado the seleccion', async()=>{

        const wrapper = shallowMount( PokemonPage,{
            data(){
                return {
                    pokemonArr: pokemons,
                    pokemon :pokemons[0],
                    showPokemon : false,
                    message: '',
                    showAnswer : false
                }
            }
        })


       await wrapper.vm.checkAnswer(1)

       expect( wrapper.find('h2').exists() ).toBeTruthy()
       expect( wrapper.find('h2').text() ).toBe(`Correcto, ${ pokemons[0].name }`)

       await wrapper.vm.checkAnswer(10)

       expect( wrapper.vm.message ).toBe(`Oops era ${ pokemons[0].name }`)

    })


})