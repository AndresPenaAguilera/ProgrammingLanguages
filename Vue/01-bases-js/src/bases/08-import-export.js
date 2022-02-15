
/*
file heroes.js
export const owners = ['DC','Marvel']; 
 */
console.log(`%c${"Export"}`, "background-color: green; border-radius: 2px;padding: 2px 4px;color: #fff;")

import { owners } from '../data/heroes'

console.log(owners)

const [dc, marvel] = owners

console.log(dc, marvel)


/*
file heroes.js
export const owners = ['DC','Marvel']; 
*/
console.log(`%c${"Export default"}`, "background-color: green; border-radius: 2px;padding: 2px 4px;color: #fff;")

import superHeroes from '../data/heroes'

console.log(superHeroes)

export const getHeroById = (id)=> superHeroes.find(hero => hero.id === id)

//console.log( getHeroById(2) )

export const getHeroesByOwner = ( Owner ) => superHeroes.find(h => h.owner === Owner)

//console.log( getHeroesByOwner('Marvel') )


/*
Exportar en otro archivo 


import {getHeroById, getHeroesByOwner} from './bases/08-import-export'

console.log( getHeroById(2) )

console.log( getHeroesByOwner('Marvel') )
*/ 