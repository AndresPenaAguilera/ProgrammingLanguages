<template>
  <h2>{{ customTitle }}</h2>
  <p>{{ counter }}<sup>2</sup>={{ squareCounter }}</p>

  <div>
      <button v-on:click="increase">+1</button>
      <button v-on:click="decrease">-1</button>
  </div>
</template>

<script>
export default {
    props:['title'],

    data(){
        return{
            counter:5
        }
    },
    methods:{
        getSquareValue(){
            return this.counter + this.counter
        },
        increase(){
             this.counter += 1
        },
        decrease(){
             this.counter -= 1
        }
    },
    computed:{
        squareCounter(){
            console.log('Guarda en memoria el valor y solo se llama cuando cambia counter')
            return this.counter * this.counter
        },
        customTitle(){
            console.log(this.title)
            return this.title || 'Counter'
        }

    }
}
</script>

<style>

button{
    background-color: #64B687;
    border-radius: 5px;
    border: 1px solid white;
    color: white;
    cursor: pointer;
    margin: 0 5px;
    margin: 0 5px;
    padding: 5px 15px;
    transition: 0.3s ease-in-out;
}
button:hover{
    background-color: #5aa67b;
    transition: 0.3s ease-in-out;
}

</style>