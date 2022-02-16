

const app = Vue.createApp({
    /*
    template:`
        <H1>Hola mundo</H1>
        <p>{{ 1 + 1 }}</p>
        <p>{{ true ? 'Activo' : 'Inactivo' }}</p>
    `
    */
    data(){
        return {
            message:'Hola mundo',
            author:'Andres'
        }
    },
    methods:{
        changeMessage( ){
            console.log('Change')
            this.author = 'Andres Peña'
            this.capitalize()
        },
        capitalize(){
            this.message = this.message.toUpperCase()
        }
    }
})

app.mount('#myApp')