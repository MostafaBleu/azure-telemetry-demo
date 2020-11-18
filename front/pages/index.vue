<template>
  <div class="min-h-screen bg-gray-200 flex flex justify-center items-center">
    <div class="max-w-2xl w-full rounded bg-white p-8 border border-gray-300">
      <div class="border-b pb-6 flex justify-between items-end">
        <div>
          <button
            @click="fetchData"
            class="rounded bg-green-200 text-green-700 px-6 py-2"
          >
            Data
          </button>
          <button
            @click="fetchError"
            class="rounded bg-red-200 text-red-700 px-6 py-2"
          >
            Error
          </button>
        </div>
        <div class="text-sm text-gray-600">
          API : {{ $axios.defaults.baseURL }}
        </div>
      </div>
      <div v-if="error" class="text-red-600">
        {{ error }}
      </div>
      <div v-else>
        <div
          v-for="forcat in forcats"
          :key="forcat.date"
          class="my-4 flex justify-between"
        >
          <div>{{ forcat.date }}</div>
          <div>{{ forcat.summary }}</div>
          <div>{{ forcat.temperatureC }}</div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  data() {
    return {
      forcats: [],
      error: '',
    }
  },
  methods: {
    async fetchData() {
      this.reset()
      const forcats = await this.$axios.$get('/WeatherForecast')
      this.forcats = forcats
    },
    async fetchError() {
      try {
        this.reset()
        await this.$axios.$get('/failure')
      } catch (error) {
        this.error = error
      }
    },
    reset() {
      this.error = ''
      this.forcats = []
    },
  },
}
</script>