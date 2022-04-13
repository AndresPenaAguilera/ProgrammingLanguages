<template>
  <h1>Counter - vuex</h1>
  <h2> Direct access: {{ $store.state.count }}</h2>
  <h2> Computed: {{ countComputed }}</h2>
  <h2> mapState: {{ count }}</h2>
  <h2> mapState other value: {{ lastMutation }}</h2>
  <h2> mapState object: {{ counter }}</h2>
  <h2> Direct getters: {{ $store.getters.squareCount }}</h2>

<button @click="increment">increment +1</button>
<button @click="incrementBy"> +5</button>
<button @click="randomInt" :disabled="isLoading"> random</button>



</template>

<script>

import { mapState, mapActions } from 'vuex'

export default {
    computed:{
        countComputed(){
            return this.$store.state.count
        },

        ...mapState(['count','lastMutation','isLoading']),

        ...mapState({
            counter: state => state.count
        })
    }, 
    
    methods:{

        increment(){
            this.$store.commit('increment')
        },

        incrementBy(){
            this.$store.commit('incrementBy', 5)
        },

        ...mapActions({
            randomInt : 'incrementRandomInt'
        })
    }
}
</script>

