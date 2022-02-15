

const characters = ['Goku', 'Vegeta', 'Trunks']

const [ g, v, k ] = characters

console.log(g, v, k)


const returnArray =()=>{
    return ['ABC', 123]
}

const [letters, numbers] = returnArray()

console.log(letters, numbers)