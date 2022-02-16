

const miPromesa=()=>{
    return new Promise(resolve =>{
        setTimeout(() => {
            resolve('Tenemos un valos en la empresa')
        }, 1000);
    })
}

const medirTiempoAsync = async()=>{
    console.log('Inicio')

    const respuesta = await miPromesa()
    console.log(respuesta)

    console.log('Fin')
}

medirTiempoAsync()