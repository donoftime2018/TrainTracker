<template>
    {{trainData}}
</template>

<script>
    import { onMounted } from "vue";
    import axios from "axios";

    export default {
        data() {
            return {
                trainData: []
            };
        },
        mounted() {
            console.log("Mounted!")

            axios.get("http://localhost:5118/api/getJsonData").then(response => {
                console.log(response);
                this.trainData = response.data
            })
        }
    }
</script>