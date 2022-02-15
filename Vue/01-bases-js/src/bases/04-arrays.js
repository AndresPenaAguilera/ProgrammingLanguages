
console.log('Arreglos con New Array')
const arreglo  = new Array(4)
arreglo[0]=1;
arreglo[1]=2;
arreglo[2]=3;
arreglo[3]=4;
console.log(arreglo)

console.log('Arreglos con New Array inicializado desde el constructor')
const arreglo2  = new Array(1,2,3,4)
console.log(arreglo2)

console.log('Arreglos con push')
const arreglo3  = [1,2,3,4]
arreglo3.push(5)
console.log(arreglo3)

console.log('Copia arreglo y agregar un valor')
const arreglo4 = arreglo3
arreglo4.push( 6 )

console.log(arreglo3)
console.log(arreglo4)

console.log('Copia arreglo rompiendo la referencia')
const arreglo5 = [...arreglo4]
arreglo5.push( 7 )

console.log(arreglo4)
console.log(arreglo5)

console.log('Funciones que devuelven un nuevo arreglo, no es necesario romper la referencia')

const arregloFuncion = arreglo5.map(function(n){
    return n + 1
})

arregloFuncion.push(9)

console.log(arregloFuncion)