
// Asignación por referencia
console.log('Asignación por referencia')
const persona = {
    nombre: 'Andres', 
    apellido: 'Peña',
    edad: 45,
    direccion: {
        ciudad: 'Bogota',
        zip: 005
    }
}

const persona2 = persona
persona2.nombre = 'Peter'

console.log(persona)
console.log(persona2)


// Asignación por valor - spread operator
console.log('Asignación por valor')

const personaValor = {
    nombre: 'Andres', 
    apellido: 'Peña',
    edad: 45,
    direccion: {
        ciudad: 'Bogota',
        zip: 005
    }
}

const personaValor2 = { ...personaValor }
personaValor2.nombre = 'Peter'

console.log(personaValor)
console.log(personaValor2)