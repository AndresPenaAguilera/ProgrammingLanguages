import { normalizeStyle } from "vue"



const isAuthenticatedGuard= (to, from, next ) =>{
    //console.log( { to, from, next } )

    return new Promise( resolve => {

              const random = Math.random()*100
        
              if (random >50 ){
                console.log(random, 'is Authenticated')
                next()
              }else{
                console.log(random, 'UnAuthenticated')
                next('pokemon-home')
              }
        
           })

}

export default isAuthenticatedGuard