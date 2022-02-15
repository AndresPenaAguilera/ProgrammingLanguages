console.log('Desestructuración')
const person = {
    name:'Andres',
    age:32,
    codeName:'Iroman'
}

const {name, age, codeName} = person

console.log(name)
console.log(age)
console.log(codeName)

console.log('Desestructuración valor por default')
const person2 = {
    name2:'Andres',
    age2:32,
    codeName2:'Iroman'
}
const {name2, age2, codeName2, power='No tengo poder'} = person2

console.log(name2)
console.log(age2)
console.log(codeName2)
console.log(power)



console.log('Ejercicio desestructuración - Sin desestructuración')
const createHeroConVariable = ( p )=>{

    return {
        id:11,
        name:p.name,
        age:p.age,
        codeName:p.codeName
    }
}

console.log(createHeroConVariable(person))

console.log('Ejercicio desestructuración - Con desestructuración')
const createHeroSinVariable = ( p )=>{

    const {name, age, codeName} = p

    return {
        id:11,
        name:name,
        age:age,
        codeName:codeName
    }
}

console.log(createHeroSinVariable(person))



console.log('Ejercicio desestructuración - Con desestructuración Sin Asignación la propiedad se llama igual')
const createHeroSinVariableIgual = ( p )=>{

    const {name, age, codeName} = p

    return {
        id:11,
        name,
        age,
        codeName
    }
}

console.log(createHeroSinVariableIgual(person))


console.log('Ejercicio desestructuración - Con desestructuración desde los parametros')
const createHeroParametros = ( {name, age, codeName}  )=>{
    return {
        id:11,
        name,
        age,
        codeName
    }
}

console.log(createHeroParametros(person))


console.log('Ejercicio desestructuración - Funcion flecha')
const createHeroFunctionFlecha = ( {name, age, codeName}  )=>({ 
                                     id:11, 
                                     name, 
                                     age, 
                                     codeName 
                                 })

console.log(createHeroFunctionFlecha(person))