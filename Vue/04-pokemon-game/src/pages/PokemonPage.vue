<template>
    <div>
    <h1>¿Quién es este pokémon?</h1>
        
    </div>

    <div v-if="!pokemon">Espere por favor...</div>
    <div v-else>
        <PokemonPicture :pokemonId="pokemon.id" :showPokemon="showPokemon"/>
        <PokemonOptions :pokemons="pokemonArr" @selection="checkAnswer"/>
        
        <div v-if="showAnswer">
        <h2 class="fade-in">{{ message }}</h2>
        <button @click="newGame">
            Nuevo juego
        </button>
        </div>
       
    </div>




</template>

<script>

import PokemonOptions from '@/components/PokemonOptions'
import PokemonPicture from '@/components/PokemonPicture'

import getPokemonOptions from '@/helpers/getPokemonOptions'



export default {
    components:{ PokemonOptions, PokemonPicture, getPokemonOptions },
    data(){
        return {
            pokemonArr: [],
            pokemon :null,
            showPokemon : false,
            message: null,
            showAnswer : false
        }
    },
    methods:{
        async mixPokemonArray(){
            this.pokemonArr = await getPokemonOptions()
            
            const randonInt = Math.floor( Math.random() * 4)

            this.pokemon  = this.pokemonArr[ randonInt ]

        },
        checkAnswer( pokemonId ){
            
            this.showPokemon = true
            this.showAnswer = true

            const { id, name } = this.pokemon

            this.message = (id==pokemonId)?`Correcto, ${name}`: `Oops era ${name}`
           

        },
        newGame(){
            this.showPokemon = false
            this.showAnswer = false
            this.pokemonArr =[]
            this.pokemon = null
            this.mixPokemonArray() 
        }
    },
    mounted(){
        this.mixPokemonArray()
    }
}
</script>

