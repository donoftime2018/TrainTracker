import './assets/main.css'

import { createApp } from 'vue'
import { createRouter, createWebHistory } from "vue-router";
import App from './App.vue'
import Login from "./components/Login.vue"
import Dashboard from "./components/Dashboard.vue"
import ChangePassword from "./components/ChangePassword.vue"
import Register from "./components/Register.vue"


const router = createRouter({
    history: createWebHistory(),
    routes: [
        { path: '/', component: Dashboard },
        { path: '/login', component: Login },
        { path: '/register', component: Register },
        { path: '/changePassword', component: ChangePassword }
    ]
})

const app = createApp(App)
app.use(router)
app.mount('#app')
