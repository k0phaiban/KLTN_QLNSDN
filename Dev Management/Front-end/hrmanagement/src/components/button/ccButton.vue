<template>
    <div>
        <button
            :class="['btn-common','btn-' + type]"
            @click="handleClick"
        >
            <slot></slot>
        </button>
    </div>
</template>
<script>
export default {
    name: 'ccButton',
    props: {
        type: {
            Type: String,
            default: "primary"
        }
    },
    methods: {
        handleClick(){
            this.$emit("click");
        }
    }
}
</script>
<style lang="scss" scoped>
@import '@/styles/var-color.scss';
.btn-common{
    height: 36px;
    padding: 0 16px;
    display: flex;
    align-items: center;
    justify-content: center; 
    border-radius: 4px;
    font-size: 14px;
    font-weight: 500;
    outline: none;
    min-width: 80px;
    cursor: pointer;
}
.btn-primary{
    color: #ffffff;
    background-color: $primary;
    border: none;
    &:hover{
        background-color: $primary-hover;
    }
    &:active{
        background-color: $primary-active;
    }
}
.btn-secondary{
    color: #000000;
    background-color: #ffffff;
    border: none;
    &:hover{
        background-color: #e0e0e0;
    }
    &:active{
        background-color: #d0d0d0;
    }
}
</style>
