<template>
    <div class="cc-dashboard">
        <div class="flex dashboard-header">
            <div class="flex tab-menu">
                <div :class="['item',{'active': active}]" @click="active = !active">Tổng quan</div>
                <div :class="['item',{'active': !active}]" @click="active = !active">Nhắc việc</div>
            </div>
        </div>
        <div v-if="active">
            <div class="flex">
                <div class="char-dashboard m-r-16 m-b-16">
                    <cc-char :dataSource="dataSource" :listHeaders="listHeaders" title="Biểu đồ biến động nhân sự vào ra theo tháng"></cc-char>
                </div>
                <div class="char-dashboard m-b-16">
                    <cc-bar-char ></cc-bar-char>
                </div>
            </div>
            <div class="flex">
                <div class="char-dashboard m-r-16 m-b-24">
                    <cc-pie-char :dataSource="areas" valueField="area" displayField="country" title="Biểu đồ số lượng nhân viên theo bộ phận công việc"></cc-pie-char>
                </div>
                <div class="char-dashboard m-b-24">
                    <cc-line-char></cc-line-char>
                </div>
            </div>
        </div>
        <div v-else>
            <Remind></Remind>
        </div>
    </div>
</template>
<script>
import Remind from "./Remind";
export default {
  components: { Remind },
    data(){
        return{
            active: true,

            areas:[{
                country: 'Nhóm phân tích nghiệp vụ',
                area: 12
                }, {
                country: 'Nhóm thiết kế',
                area: 7
                }, {
                country: 'Phòng hệ thống',
                area: 7
                }, {
                country: 'Phòng chăm sóc khách hàng',
                area: 7
                }, {
                country: 'Bộ phận nhân sự',
                area: 6
                }, {
                country: 'Bộ phận an ninh',
                area: 5
                }, {
                country: 'Bộ phận bán hàng',
                area: 2
                }, {
                country: 'Lập trình viên',
                area: 55
            }],

            dataSource:[
            {
                year: 1997,
                smp: 1000,
            },
            {
                year: 1998,
                smp: 1800,
            },
            {
                year: 1999,
                smp: 1600,
            },
            {
                year: 2000,
                smp: 3000,
            },
            {
                year: 2002,
                smp: 2300,
            },
        ],
        listHeaders :[
            { value: 'smp', name: 'Số lượng nhân viên' },
            ]
        }
    }
}
</script>
<style lang="scss" scoped>
.cc-dashboard{
    width: 100%;
    height: 100%;
    .char-dashboard{
        width: 50%;
        background-color: #ffffff;
        border-radius: 8px;
        padding: 16px;
    }
    .dashboard-header{
        height: 36px;
        position: relative;
        margin-bottom: 16px;
        .tab-menu{
            position: absolute;
            left: 50%;
            transform: translateX(-50%);
            border-radius: 5px;
            background-color: #e5e5e5;
            height: 36px;
            .item{
                height: 36px;
                display: flex;
                align-items: center;
                width: 90px;
                justify-content: center;
                cursor: pointer;
            }
            .active{
                background-color: #ffffff;
                color: #0477ffb8;
                border-radius: 5px;
            }
        }
    }
}
</style>