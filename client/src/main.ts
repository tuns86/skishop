import './assets/main.css';
import './assets/tailwind.css';

import { createPinia } from 'pinia';
import { createApp } from 'vue';
import App from './App.vue';
import router from './router/router';

const app = createApp(App)

app.use(createPinia())
app.use(router)
// app.use(vuetify)

app.mount('#app')
