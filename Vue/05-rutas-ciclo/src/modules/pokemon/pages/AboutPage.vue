<template>
    <h1>About page</h1>


    <h2>{{ name }}</h2>
    <button @click="onChangeName">change name</button>
</template>

<script>


export default {

    data(){
        return {
            name:'Sin nombre'
        }
    },
    methods:{
        onChangeName(){
            console.log('Se cambiará el  nombre')
            this.name = 'Andres'
        }
    },


    beforeCreate(){
        console.log("beforeCreate")
    },
    created(){
        // peticiones http
        console.log("created")
    },
    beforeMount(){
        console.log("beforeMount")
    },
    mounted(){
        console.log("mounted")
    },
    beforeUpdate(){
        console.log("beforeUpdate")
    },
    updated(){
        console.log("updated")
    },
    activated(){
        console.log("activated")
    },
    deactivated(){
        console.log("deactivated")
    },
    beforeUnmount(){
        console.log("beforeUnmount")
    },
    unmounted(){
        console.log("unmounted")
    },
    errorCaptured(){
        console.log("errorCaptured")
    },
    renderTracked(){
        console.log("renderTracked")
    },
    renderTriggered(){
        console.log("renderTriggered")
    },

}
</script>
