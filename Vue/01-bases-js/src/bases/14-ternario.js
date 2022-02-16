

console.log('Check value - Evalua si trae o no valor')
let firstName
let lastName 

console.log(`${ firstName || 'No firstName'} ${ lastName || 'No lastName'}`)

console.log('Ternario')

const isActive = true

if(!isActive){
    message ='Activo'
}else{
    message ='Inactivo'
}
console.log(message)

const message2 = ( isActive ) ? 'Activo':'Inactivo'

console.log(message2)