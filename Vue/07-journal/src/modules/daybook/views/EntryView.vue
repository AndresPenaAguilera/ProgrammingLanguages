<template>
  <template v-if="entry">
 <div class="entry-title d-flex justify-content-between p-2">
      <div>
          <span class="text-success fs-5 fw-bold"> {{ day }} </span>
          <span class="mx-1 fs-3">{{ months }}</span>
          <span class="mx-2 fs-4 fw-light">{{ yearDay }}</span>

      </div>
    
    
      <div>
        <button class="btn btn-danger mx-2" title="Borrar">
          <i class="fa fa-trash-alt"></i>
        </button>

         <button class="btn btn-primary" title="Subir foto">
          <i class="fa fa-upload"></i>
        </button>

      </div>
    </div>

  <hr>
  <div class="d-flex flex-column px-3 h-75">
    <textarea
      v-model="entry.text"
      placeholder="¿Qué sucedió hoy?"
    ></textarea>

  </div>

  <img src="https://http2.mlstatic.com/D_NQ_NP_993171-MCO43437205853_092020-O.webp"
  class="img-thumbnail"
>

  </template>
   
<Fab icon="fa-save"/>




</template>

<script>


import { defineAsyncComponent } from 'vue'
import { mapGetters } from 'vuex'
import getDayMonthYear from '../helpers/getDayMonthYear'

export default {
   props:{
     id:{
       type: String,
       required: true
     }
   },
   computed:{
      ...mapGetters('journal',['getEntriesById']),

        day(){
            
            const { day } = getDayMonthYear( this.entry. date )
            return day
        },
        months(){
             const { month } = getDayMonthYear( this.entry. date )
            return month
        },
        yearDay(){
             const { yearDay } = getDayMonthYear( this.entry. date )
            return yearDay
        }
      




   },
   components:{
       Fab: defineAsyncComponent( ()=> import('../components/Fab.vue') ),
   },
   data(){
     return {
       entry: null
     }
   }, 

    methods:{
        
        loadEntry(){
          const entry = this.getEntriesById( this.id )    
          if( !entry ) return this.$router.push({ name: 'no-entry'})
          this.entry= entry
        }
        
    },

   created(){
      this.loadEntry()
   },

   watch:{
     id(){
       this.loadEntry()
     }
   }
}
</script>

<style lang="scss" scoped>
  textarea{
    font-size: 20px;
    border: none;
    height: 100%;
    &:focus{
      outline: none;
    }
  }

  img{
      width: 200px;
      position: fixed;
      bottom: 150px;
      right: 20px;
      box-shadow: 0px 5px 10px rgba($color: #000000, $alpha: 0.2)
  }
</style>