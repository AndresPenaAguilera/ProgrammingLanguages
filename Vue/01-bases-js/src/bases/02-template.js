

const nombre   = 'Tony'
const apellido = 'Stark'

const nombreCompleto = nombre +' '+apellido 

//Alt + 96 / Alt + 096
const nombreCompleto_BackTick = `${ nombre } ${ apellido }` 

console.log(nombreCompleto_BackTick)

console.log(nombreCompleto)

console.log(`Resultado = ${ 1 + 1}`)


console.log(`Resultado = ${ getSaludo(nombre) }`)

function getSaludo(nombre)
{
    return 'Hola function ' + nombre
}

