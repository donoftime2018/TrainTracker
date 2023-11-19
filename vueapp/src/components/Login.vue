<template>
    <div class="flex justify-center">
        <div class="mt-20 w-full max-w-xl">
            <form class="bg-white shadow-md rounded px-12 pt-6 pb-8 mb-4">
                    <div class="mb-4">
                        <h2 class="text-center font-bold text-2xl">Login</h2>
                    </div>
                 
                    <div class="mb-4">
                        <label class="text-center block text-gray-700 text-sm font-bold mb-2" for="username">
                            Username
                        </label>
                        <input class="shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline" id="username" type="text" placeholder="Username">
                    </div>

                    <div class="mb-4">
                        <label class="text-center block text-gray-700 text-sm font-bold mb-2" for="password">
                            Password
                        </label>
                        <input class="shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline" id="password" type="password" placeholder="Password">
                    </div>
            </form>
        </div>
    </div>
    
</template>