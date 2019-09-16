<template>
  <div class="about">
    <h1>This is an about page</h1>
  </div>
</template>

<script>
  export default {
    name: 'About',
    mounted() {
      fetch('https://localhost:44338/api/AboutData')
            .then(response => response.json())
            .then(data => console.log(data))
            .catch(error => '');
    }
  }
</script>
