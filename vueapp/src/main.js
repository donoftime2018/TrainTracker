import './assets/main.css'

import { createApp } from 'vue'
import { createRouter, createRouterHistory } from "vue-router";
import App from './App.vue'
import Login from "./components/Login.vue"
import Dashboard from "./components/Dashboard.vue"
import ChangePassword from "./components/ChangePassword.vue"
import Register from "./components/Register.vue"

const app = createApp(App)
app.mount('#app')
