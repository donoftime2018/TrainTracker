<template>
    <div class="flex flex-wrap gap-4 justify-between">
      
        <div v-for="t in trainData" class="mt-20 text-center text-white px-6 py-4">
            <div class="flex bg-[#c60c30] mb-5 p-3 w-full max-w-xl">
                <div class="flex flex-col"><h2 class="font-bold underline">Parent Station:</h2> <p>{{t.staNm}}</p></div>
                <div class="flex flex-col"><h2 class="font-bold underline">Station Description:</h2> <p>{{t.stpDe}}</p></div>
                <div class="flex flex-col"><h2 class="font-bold underline">Destination Station:</h2> <p>{{t.destNm}}</p></div>
                <div class="flex flex-col"><h2 class="font-bold underline">Arrival Time:</h2> <p>{{t.arrT}}</p></div>

            </div>
        </div>
     
    </div>
    
</template>

<script>
    import axios from "axios";
    
    export default {
        data() {
            return {
                trainData: [],
            };
        },
        mounted() {
            console.log("Mounted!")

            axios.get("http://localhost:5118/api/getStationData").then(response => {
                console.log(response);
                this.trainData = response.data.ctatt.eta  
            })
        }
    }
</script>