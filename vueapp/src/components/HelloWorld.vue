<template>
    <div class="post">
        <div v-if="loading" class="loading">
            Loading... Please refresh once the ASP.NET backend has started. See <a href="https://aka.ms/jspsintegrationvue">
                https://aka.ms/jspsintegrationvue</a> for more details.
        </div>

        <div v-if="post" class="content">
            <table>
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>FirstName</th>
                        <th>SecondName</th>
                        <th>SurName</th>
                        <th>Adress</th>
                        <th>Phone</th>
                    </tr>
                </thead>
                <tbody>
                    <tr v-for="Users in post" :key="Users.Id">
                        <td>{{ Users.Id }}</td>
                        <td>{{ Users.FirstName }}</td>
                        <td>{{ Users.SecondName }}</td>
                        <td>{{ Users.SurName }}</td>
                        <td>{{ Users.Adress }}</td>
                        <td>{{ Users.Phone }}</td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
</template>

<script lang="js">
    import { defineComponent } from 'vue';

    export default defineComponent({
        data() {
            return {
                loading: false,
                post: null
            };
        },
        created() {
            // fetch the data when the view is created and the data is
            // already being observed
            this.fetchData();
        },
        watch: {
            // call again the method if the route changes
            '$route': 'fetchData'
        },
        methods: {
            fetchData() {
                this.post = null;
                this.loading = true;

                fetch('https://localhost:7108/api/Users/')
                    .then(r => r.json())
                    .then(json => {
                        this.post = json;
                        console.log(json);
                        this.loading = false;
                        return;
                    });
            }
        },
    });
</script>