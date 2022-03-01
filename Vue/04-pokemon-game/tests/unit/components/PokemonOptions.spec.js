import { shallowMount } from '@vue/test-utils'
import PokemonOptions from '@/components/PokemonOptions'
import { pokemons } from '../mocks/pokemons.mock'



describe('Pokemon options Component', ()=>{

    let wrapper
    beforeEach(()=>{
        wrapper = shallowMount( PokemonOptions,{
            props:{
                pokemons
            }
        } )

    })


    test('debe hacer match con el snapshot',()=>{

        expect( wrapper.html() ).toMatchSnapshot()

    })

    test('debe de mostrar las 4 opciones correctamente',()=>{

        const tagsLi = wrapper.findAll('li')
        expect(tagsLi).toHaveLength(4)

        expect(tagsLi[0].text()).toBe('bulbasaur')
        expect(tagsLi[1].text()).toBe('ivysaur')
        expect(tagsLi[2].text()).toBe('venusaur')
        expect(tagsLi[3].text()).toBe('charmander')

    })

    test('debe de emitir "selection" con sus respectivos párametros valores al hacer click',()=>{

        const [li1, li2, li3, li4] = wrapper.findAll('li')
        
        li1.trigger('click')
        li2.trigger('click')
        li3.trigger('click')
        li4.trigger('click')

        expect( wrapper.emitted('selection') ).toHaveLength(4)
        expect( wrapper.emitted('selection')[0] ).toEqual( [1] )
        expect( wrapper.emitted('selection')[1] ).toEqual( [2] )
        expect( wrapper.emitted('selection')[2] ).toEqual( [3] )
        expect( wrapper.emitted('selection')[3] ).toEqual( [4] )

    })

})