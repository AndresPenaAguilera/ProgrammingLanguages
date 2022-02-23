import { shallowMount } from '@vue/test-utils'
import Counter from '@/components/Counter'

describe('Counter component' ,()=>{

    // test('Debe hacer match con el jest --updateSnapshot', ()=>{

    //     const wrapper = shallowMount( Counter )
        
    //     expect(wrapper.html()).toMatchSnapshot()
    // })

    let wrapper

    beforeEach(()=>{
        wrapper = shallowMount( Counter )
    })

    test('H2 debe tener valor por defecto',()=>{
         
        const h2 = wrapper.find('h2')

        expect(h2.text()).toBe('Counter')

    })

    test('El valor por defecto debe ser 100 en el p' , ()=>{
        
        const value = wrapper.find('[data-testid="counter"]').text()
        
        expect(value).toBe('100')
    })

    test('Debe incrementar en 1 el valor del contador', async()=>{
        
        const increaseBtn = wrapper.find('button')

        await increaseBtn.trigger('click')

        const value = wrapper.find('[data-testid="counter"]').text()

        expect(value).toBe('101')

    })

    test('Debe decrementar en 1 el valor del contador', async()=>{
        
        const decreaseBtn = wrapper.findAll('button')[1]

        await decreaseBtn.trigger('click')

        const value = wrapper.find('[data-testid="counter"]').text()

        expect(value).toBe('99')

    })

    test('Debe de establecer el valor por defecto',()=>{
        
        const { start } = wrapper.props()
        
        const value = wrapper.find('[data-testid="counter"]').text()

        expect(Number(value)).toBe( start )
    })

    test('Debe mostrar la pror title',()=>{

        const title ='Hola mundo'

        const wrapper = shallowMount( Counter,{
            props:{
                title
            }
        })

        const h2 = wrapper.find('h2')

        expect(h2.text()).toBe(title)


    })
})