<template>
    <div class="cc-sidebar" v-on:mouseleave="settingActive = false">
        <div class="cc-menu">
            <div v-for="(item,index) in listMenu" :key="(index)" :class="['flex align-center cc-item f-caption pointer',{'cc-active': item.ID == activeID}]" @click="active(item)">
                <div :class="['m-r-8',item.Icon]">
                </div>
                <div class="m-t-2">
                    {{item.Name}}
                </div>
            </div>
        </div>
        <div class="cc-setting" v-if="settingActive">
            <div v-for="(item,index) in listSetting" :key="(index)">
                <div v-if="item.Type == 1" class="m-t-2 cc-item flex align-center f-caption pointer" @click="activeSetting(item)">
                    {{item.Name}}
                </div>
                <div v-if="item.Type == 0" class="m-t-2 flex align-center cc-caption" >
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
                    Router: "/HRManagement/Dashboard",
                },
                {
                    ID: 2,
                    Icon: "icon-user20",
                    Name: "Hồ sơ",
                    Router: "/HRManagement/Profile"
                },
                {
                    ID: 3,
                    Icon: "icon-note20",
                    Name: "Hợp đồng",
                    Router: "/HRManagement/Contract"
                },
                {
                    ID: 4,
                    Icon: "icon-users20",
                    Name: "Chấm công",
                    Router: "/HRManagement/Timekeeping"
                },
                {
                    ID: 5,
                    Icon: "icon-appoint",
                    Name: "Bổ nhiệm",
                    Router: "/HRManagement/Appoint"
                },
                {
                    ID: 6,
                    Icon: "icon-dismissed",
                    Name: "Miễn nhiệm",
                    Router: "/HRManagement/Dismissed"
                },
                {
                    ID: 7,
                    Icon: "icon-dispatch",
                    Name: "Thuyên chuyển",
                    Router: "/HRManagement/Dispatch"
                },
                {
                    ID: 8,
                    Icon: "icon-help20",
                    Name: "Báo cáo",
                    Router: "/HRManagement/Report"
                },
                {
                    ID: 9,
                    Icon: "icon-setting20",
                    Name: "Thiết lập",
                    Router: "/HRManagement/Setting"
                },
            ],
            listMenu: [],
            listSetting: [
                {
                    Type: 0,
                    Name: "Hệ thống"
                },
                {
                    Type: 1,
                    ID: 1,
                    Name: "Cơ cấu tổ chức",
                    Router: "/HRManagement/OrganizationUnit"
                },
                {
                    Type: 1,
                    ID: 2,
                    Name: "Vị trí công việc",
                    Router: "/HRManagement/Jobtitle"
                },
                {
                    Type: 1,
                    ID: 3,
                    Name: "Mẫu email",
                    Router: "/HRManagement/Account"
                },
                {
                    Type: 1,
                    ID: 4,
                    Name: "Nhật ký truy cập",
                    Router: "/HRManagement/Role"
                },
                {
                    Type: 0,
                    Name: "Người dùng"
                },
                {
                    Type: 1,
                    ID: 3,
                    Name: "Thông tin người dùng",
                    Router: "/HRManagement/Account"
                },
                {
                    Type: 1,
                    ID: 4,
                    Name: "Vai trò người dùng",
                    Router: "/HRManagement/Role"
                },
                {
                    Type: 0,
                    Name: "Thùng rác"
                },
                {
                    Type: 1,
                    ID: 5,
                    Name: "Hồ sơ",
                    Router: "/HRManagement/TrashProfile"
                },
                {
                    Type: 1,
                    ID: 6,
                    Name: "Hợp đồng",
                    Router: "/HRManagement/TrashContract"
                },
            ],
            activeID: 1,
            settingActive: false
        }
    },
    methods: {
        active(item){
            if(item.ID == 9){
                this.settingActive = true;
            }
            else{
                this.activeID = item.ID;
                this.settingActive = false;
                this.$router.push(item.Router);
            }
        },
        activeSetting(item){
            this.activeID = 9;
            this.$router.push(item.Router);
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
    width: 220px;
    border-right: 1px solid #DDDDDD;
    .cc-menu{
        padding: 24px 16px;
        .cc-item{
            height: 50px;
            border-radius: 8px;
            margin-bottom: 4px;
            padding: 0 16px;
            color: #142142;
            &:hover{
                background-color: #EBF4FF;
            }
        }
        .cc-active{
            color: #0075FF;
            background-color: #EBF4FF;
        }
    }
    .cc-setting{
        position: absolute;
        top: 0px;
        left: 220px;
        bottom: 0px;
        width: 220px;
        background-color: #efefef;
        z-index: 10000000;
        padding: 24px 16px;
        .cc-caption{
            height: 40px;
            border-radius: 8px;
            margin-bottom: 4px;
            padding: 0 16px;
            color: #142142;
        }
        .cc-item{
            height: 40px;
            border-radius: 4px;
            margin-bottom: 4px;
            padding: 0 16px;
            width: 188px;
            color: #142142;
            &:hover{
                background-color: #DDDDDD;
            }
        }
    }
}
</style>