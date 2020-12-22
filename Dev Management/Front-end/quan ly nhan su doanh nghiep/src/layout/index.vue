<template>
    <div>
        <navbar></navbar>
        <sidebar></sidebar>
        <div class="cc-body">

        </div>
    </div>
</template>
<script>
import navbar from "./navbar";
import sidebar from "./sidebar";
export default {
    components: {
        navbar,
        sidebar
    }
}
</script>
<style lang="scss" scoped>
.cc-body{
    position: absolute;
    top: 60px;
    left: 200px;
    bottom: 0px;
    right: 0px;
    background-color: #F5F5F5;
}
</style>