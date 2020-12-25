<template>
    <div class="cc-sidebar">
        <div class="cc-menu">
            <div v-for="(item,index) in listMenu" :key="(index)" :class="['flex align-center cc-item f-caption',{'cc-active': item.ID == activeID}]" @click="active(item)">
                <div :class="item.Icon">
                </div>
                <div>
                    {{item.Name}}
                </div>
            </div>
        </div>
    </div>
</template>
<script>
export default {
    data(){
        return{
            listHRManagement: [
                {
                    ID: 1,
                    Icon: "icon-home20",
                    Name: "Tổng quan",
                    Router: "",
                },
                {
                    ID: 2,
                    Icon: "icon-user20",
                    Name: "Hồ sơ",
                    Router: ""
                },
                {
                    ID: 3,
                    Icon: "icon-note20",
                    Name: "Hợp đồng",
                    Router: ""
                },
                {
                    ID: 4,
                    Icon: "",
                    Name: "Chấm công",
                    Router: ""
                },
                {
                    ID: 5,
                    Icon: "",
                    Name: "Bổ nhiệm",
                    Router: ""
                },
                {
                    ID: 6,
                    Icon: "",
                    Name: "Miễn nhiệm",
                    Router: ""
                },
                {
                    ID: 7,
                    Icon: "",
                    Name: "Thuyên chuyển",
                    Router: ""
                },
                {
                    ID: 8,
                    Icon: "icon-help20",
                    Name: "Báo cáo",
                    Router: ""
                },
                {
                    ID: 9,
                    Icon: "icon-setting20",
                    Name: "Thiết lập",
                    Router: ""
                },
            ],
            listMenu: [],
            activeID: 1
        }
    },
    methods: {
        active(item){
            this.activeID = item.ID;
        }
    },
    created(){
        this.listMenu = this.listHRManagement;
    }
}
</script>
<style lang="scss" scoped>
.cc-sidebar{
    position: absolute;
    top: 60px;
    left: 0px;
    bottom: 0px;
    width: 200px;
    border-right: 1px solid #DDDDDD;
    .cc-menu{
        padding: 24px 16px;
        .cc-item{
            height: 50px;
            border-radius: 8px;
            margin-bottom: 4px;
            padding: 0 16px;
            color: #0075FF;
            &:hover{
                background-color: #EBF4FF;
            }
        }
        .cc-active{
            background-color: #EBF4FF;
        }
    }
}
</style>