<template>

    <div class="flex justify-evenly">
        <div class="flex flex-wrap gap-1 justify-evenly p-3 w-full max-w-xl">
            <h1 class="text-3xl border-4 border-[#565a5c] bg-[#f9461c] rounded-md text-center p-4 font-bold fixed text-white">{{currentTime}}</h1>
        </div>
    </div>

        <div v-if="errMessage !== '' && (trainData === undefined || trainData === [])" class="flex justify-evenly mt-40 text-3xl"><h1>{{errMessage}}</h1></div>

        <div v-else class="flex flex-wrap gap-1 justify-evenly">
            
            <div v-for="t in trainData" class="mt-20 text-center text-white px-6 py-4 divide-y">
                <div v-if="t.isApp === '1'" class="flex bg-[#c60c30] p-3 w-full max-w-xl">
                    <div class="flex flex-col"><h2 class="font-bold underline">Parent Station:</h2> <p>{{t.staNm}}</p></div>
                    <div class="flex flex-col"><h2 class="font-bold underline">Station Description:</h2> <p>{{t.stpDe}}</p></div>
                    <div class="flex flex-col"><h2 class="font-bold underline">Destination Station:</h2> <p>{{t.destNm}}</p></div>
                    <div class="flex flex-col"><h2 class="font-bold underline">Arrival Time:</h2> <p>{{t.arrT}}</p></div>

                </div>
                <div class="flex justify-evenly bg-[#c60c30] mb-5 p-3 w-full max-w-xl">
                    <div class="flex flex-col"><h2 class="font-bold underline">Approaching:</h2><p>{{t.isApp === "1" ? 'Yes' : 'No'}}</p></div>
                    <div class="flex flex-col"><h2 class="font-bold underline">Delayed:</h2><p>{{t.isDly === "1" ? 'Yes' : 'No'}}</p></div>
                    <div class="flex flex-col"><h2 class="font-bold underline">Faulty Data:</h2><p>{{t.isFlt === "1" ? 'Yes' : 'No'}}</p></div>
                </div>
            </div>

        </div>

</template>

<script>
    import axios from "axios";
    import { onMounted, ref } from 'vue';

    export default {
       
        data() {
            return {
                trainData: [],
                currentTime: null,
                errMessage: null
            };
        },
        async mounted() {
            console.log("Mounted!")

            let response = await axios.get("http://localhost:5118/api/getStationData")
            console.log(response);
            this.trainData = response.data.ctatt.eta
            this.currentTime = response.data.ctatt.tmst
            this.errMessage = response.data.ctatt.errNm
        },

        async updated() {
            let response = await axios.get("http://localhost:5118/api/getStationData").then(response => {
            console.log(response);
            this.trainData = response.data.ctatt.eta
            this.currentTime = response.data.ctatt.tmst
            this.errMessage = response.data.ctatt.errNm
            })
        },
        beforeMount() {
            this.currentTime = "Loading..."
        }
    }
</script>