const nombre ='Andres'

console.log("Función basica")
function saludar( n )
{
    return `Hola ${ n }`
}

//Intento reasignar - cambia la referencia y lo vulve el tipo de dato asignado
//saludar = true 
//console.log(saludar)

console.log(saludar(nombre))

console.log("Funcion variable - mas segura porque no se puede reasignar")
const saludar2 = function( n )
{
    return `Hola ${ n }`
}
/*
Intento reasignar
saludar2 = true 
*/
console.log( saludar2(nombre) )


console.log("Función flecha - lamda funcion")

const saludarFeclaLarga = ( n ) => {
    return `Hola larga - ${ n }`
}
console.log( saludarFeclaLarga(nombre) )

const saludarFeclaCorta = ( n ) => `Unico return - Hola corta - ${ n }`
console.log( saludarFeclaCorta(nombre) )

const saludarSinParentesis = n => `Sin parentesis - Hola corta - ${ n }`
console.log( saludarSinParentesis(nombre) )

const saludarValorPorDefecto = ( n='Juan') => `Valor por defecto - Hola corta - ${ n }`
console.log( saludarValorPorDefecto() )


const saludarReturnObject = () => ({
    uid:'Abc',
    userName:'Name'
})
console.log(`Return Object: ${ saludarReturnObject() }` )
console.log(saludarReturnObject() )

console.log("Función flecha - usado en funciones ")
const heroes = [{id:1, name:'Batman'},{id:2, name:'Superman'}]
const existe = heroes.some((heroe)=> heroe.id===1)
console.log('Some: ' + existe)

const existe2 = heroes.find((heroe)=> heroe.id===1)
console.log('find: ' +existe2)
console.log(existe2)