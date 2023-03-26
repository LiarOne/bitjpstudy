<template>
  <v-row>
    <v-col class="text-center">
      <img src="/v.png" alt="Vuetify.js" class="mb-5" />
      <blockquote class="blockquote">
        &#8220;First, solve the problem. Then, write the code.&#8221;
        <footer>
          <small>
            <em>&mdash;John Johnson</em>
          </small>
        </footer>
      </blockquote>
      <div>
        <h3>当前时间：{{time}}</h3>
        <button @click="getTime()">Get time</button>
      </div>
    </v-col>
  </v-row>
</template>

<script>
export default {
  name: 'InspirePage',
  data(){
    return {
      time:""
    }
  },
  methods: {
    getTime(){
      console.log("start method: getTime")
      const self = this
      self.$axios.get('/api/WeatherForecast/time')
      .then(function(response){
        console.log(response.data)
        self.time = response.data
        console.log(self.time)
      })
      .catch(err=>console.log(err))
    }
  }
}
</script>
