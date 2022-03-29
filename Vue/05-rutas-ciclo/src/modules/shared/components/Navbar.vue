<template>
    
    <div>
        <!-- <router-link :to="{ name:'home' }">Pokemon list</router-link>
        <router-link :to="{ name:'pokemon-id', params: { id: 1 }}">Pokemon por id</router-link>
        <router-link :to="{ name:'about' }">About</router-link> -->
<custom-link
    v-for="link in links"
    :key="link.to"
    :link="link"

/>


    </div>

</template>

<script>
import { defineAsyncComponent } from '@vue/runtime-core'

export default {

    data(){
        return {

            links: [
                {to:'pokemon-home', name :'Pokemons'},
                {to:'pokemon-id', name :'Por ID', id:50},
                {to:'pokemon-about', name :'About'},

                {to:'dbz-characters', name :'Characters'},
                {to:'dbz-about', name :'DBZ-About'},

                {to:'https://google.com', name :'google'}
            ]

        }
    }, 

    components:{
        CustomLink: defineAsyncComponent(()=> import('./CustomLink.vue'))
    }
}
</script>


<style scoped>


    div{
        padding: 0 30px;
    }

    div a{
        font-weight: bold;
        color: #2c3e50;
        margin: 0 10px;
    }

    a .router-link-exact-active{
        color: #42b983;
    }

</style>