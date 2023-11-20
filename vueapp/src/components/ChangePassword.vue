<template>
    <div class="flex justify-center">
        <div class="mt-20 w-full max-w-xl">
            <form class="bg-[#EE0034] text-white shadow-md rounded px-12 pt-6 pb-8 mb-4">
                <div class="mb-4">
                    <h1 class="text-center font-bold text-2xl underline">Register</h1>
                </div>

                <div class="mb-4">
                    <label class="text-center block text-lg font-bold mb-2" for="username">
                        Username
                    </label>
                    <input class="shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline" id="username" type="text" placeholder="Username goes here...">
                </div>

                <div class="mb-4">
                    <label class="text-center block text-lg font-bold mb-2" for="password">
                        New Password
                    </label>
                    <input class="shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline" id="password" type="password" placeholder="Password goes here...">
                </div>

                <div class="mb-4">
                    <label class="text-center block text-lg font-bold mb-2" for="password">
                        Confirm Password
                    </label>
                    <input class="shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline" id="password" type="password" placeholder="Retype New Password here..." />
                </div>

                <div class="mb-4 flex justify-center">
                    <button type="submit" class="bg-[#0039a6] hover:bg-blue-700 text-white font-bold py-2 px-4 rounded">
                        Reset Password
                    </button>
                </div>
            </form>
        </div>
    </div>
</template>
