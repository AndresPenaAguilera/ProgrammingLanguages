
//tarea asincrona que permite ejecutar un codigo en diferente momento en el tiempo 
console.log('Inicio')

new Promise((resolve, reject) => {
    
    console.log('cuerpo de la promesa')
    //resolve('Promesa resuelta')
    reject('Promesa con error')

})
.then(msg => console.log( msg ))
.catch( console.log )

console.log('Fin')

/////////////////////////////////////////////
import {getHeroById} from './bases/08-import-export'

const getHeroByIdAsync = (id)=>{
    return  new Promise((resolve, reject) =>{
        setTimeout(()=>{
            const hero = getHeroById( id )

            if(hero)
            {
                resolve(hero)
            }else{
                reject('Heroe no existe')
            }

        },1000)
    })
}

getHeroByIdAsync(100)
.then( h => {
    console.log(`El heroe es: ${ h.name}`)
}).catch( console.log )