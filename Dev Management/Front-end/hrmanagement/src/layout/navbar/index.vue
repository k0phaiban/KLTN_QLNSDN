<template>
    <div class="cc-navbar">
        <div class="block-left">
            <div class="app-store">
                <div class="icon-chocolate2"></div>
            </div>
            <img class="logo m-r-12" src="@/assets/icon/sidebar/user.svg"/>
            <div class="f-logo pointer">
                Hồ sơ
            </div>
        </div>
        <div class="block-right">
            <div class="ico-notify m-r-8" title="Thông báo">
                <div class="icon-notify"></div>
            </div>
            <div class="ico-notify m-r-12" title="Help">
                <div class="icon-help"></div>
            </div>
            <img class="logo m-r-24" src="@/assets/icon/sidebar/user.svg"/>
        </div>
    </div>
</template>
<script>
export default {
    
}
</script>
<style lang="scss" scoped>
.cc-navbar{
    position: relative;
    display: flex;
    align-items: center;
    top: 0px;
    left: 0px;
    right: 0px;
    height: 60px;
    box-shadow: 0 2px 4px rgba(0,0,0,.175);
    z-index: 10;
    .block-left{
        position: absolute;
        left: 0;
        display: flex;
        align-items: center;
        .app-store{
            display: flex;
            align-items: center;
            justify-content: center;
            width: 34px;
            height: 34px;
            border-radius: 50px;
            margin-left: 35px;
            margin-right: 12px;
            cursor: pointer;
            &:hover{
                background-color: #f5f5f5;
            }
        }
        .logo{
            width: 34px;
            height: 34px;
            cursor: pointer;
        }
    }
    .block-right{
        position: absolute;
        right: 0;
        display: flex;
        align-items: center;
        .logo{
            width: 34px;
            height: 34px;
            cursor: pointer;
        }
        .ico-notify{
            display: flex;
            align-items: center;
            justify-content: center;
            width: 34px;
            height: 34px;
            border-radius: 50px;
            cursor: pointer;
            &:hover{
                background-color: #f5f5f5;
            }
        }
    }
}
</style>