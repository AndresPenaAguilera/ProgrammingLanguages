<template>
  <h1>Counter - vuex</h1>
  <h2> Direct access: {{ $store.state.counter.count }}</h2>
  <h2> Computed: {{ countComputed }}</h2>
  <h2> mapState: {{ count }}</h2>
  <h2> mapState other value: {{ lastMutation }}</h2>
  <h2> mapState object: {{ counter }}</h2>
  <h2> Direct getters: {{ $store.getters['counter/squareCount'] }}</h2>

<button @click="increment">increment +1</button>
<button @click="incrementBy"> +5</button>
<button @click="randomInt" :disabled="isLoading"> random</button>



</template>

<script>

import { mapState, mapActions } from 'vuex'

export default {
    computed:{
        countComputed(){
            return this.$store.state.counter.count
        },

        ...mapState('counter',['count','lastMutation','isLoading']),

        ...mapState({
            counter: state => state.counter.count
        })
    }, 
    
    methods:{

        increment(){
            this.$store.commit('counter/increment')
        },

        incrementBy(){
            this.$store.commit('counter/incrementBy', 5)
        },

        ...mapActions('counter',{
            randomInt : 'incrementRandomInt'
        })
    }
}
</script>

