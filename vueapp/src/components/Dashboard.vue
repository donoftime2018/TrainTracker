<template>
    {{date}}
    {{trainData}}
</template>

<script>
    import { onMounted } from "vue";
    import axios from "axios";
    
    export default {
        data() {
            return {
                trainData: [],
                date: null
            };
        },
        mounted() {
            console.log("Mounted!")

            axios.get("http://localhost:5118/api/getStationData").then(response => {
                console.log(response);
                this.trainData = response.data.ctatt.eta
                this.date = response.data.ctatt.tmst
                
            })
        }
    }
</script>