<template>
  <div class="entry-container mb-3 pointer p-2"
    @click="$router.push({ name:'entry', params:{ id:10 }})"
  >
      <div class="entry-title d-flex">
          <span class="text-success fs-5 fw-bold">15</span>
          <span class="mx-1 fs-5">Julio</span>
          <span class="mx-2 fw-light">2021, Jueves</span>
      </div>

      <dvi class="entry-description">
Consequat mollit ut sunt et id magna ex voluptate aliquip ipsum. Ex veniam cillum consectetur ea ut veniam magna aliquip laboris excepteur consequat. Minim non nulla in ex anim quis sit laboris id exercitation enim. In culpa irure commodo mollit exercitation amet commodo cupidatat reprehenderit occaecat aliquip ea labore dolore. Amet minim aute Lorem enim mollit culpa amet est. Sint ea in exercitation magna commodo enim incididunt do veniam. Velit ullamco voluptate qui ea velit ea laboris in anim aute aliqua velit ad excepteur.
      </dvi>
  </div>
</template>

<script>
export default {

}
</script>

<style lang="scss" scope>
.entry-container{
    border-bottom: 1px solid #2c3e50;
    transition: 0.2s all ease-in;

    &:hover{
        background-color: lighten($color: grey, $amount: 45);
    }

    .entry-description{
        font-size: 12px;
    }
}

</style>