<template>
    <div class="cc-profile">
        <div class="profile-header m-b-12">
            <div class="f-title">Hồ sơ</div>
            <div>
                <cc-button>Thêm</cc-button>
            </div>
        </div>
        <div style="height: calc(100% - 48px);">
            <ccTable 
                :listHeader="listHeader" 
                :dataSource="dataSource">
            </ccTable>
        </div>
    </div>
</template>
<script>
import ccButton from '../../../components/button/ccButton.vue'
export default {
  components: { ccButton },
    data(){
        return{
            listHeader: [
                {
                    dataField: "FullName",
                    caption: "Họ và tên",
                    dataTyle: "text"
                },
                {
                    dataField: "Code",
                    caption: "Mã",
                    dataTyle: "text"
                },
                {
                    dataField: "Gender",
                    caption: "Giới tính",
                    dataTyle: "text"
                },
                {
                    dataField: "Old",
                    caption: "Tuổi",
                    dataTyle: "number"
                },
                {
                    dataField: "Email",
                    caption: "Email",
                    dataTyle: "text"
                },
            ],
            dataSource: [
                {
                    FullName: "Cao Văn Cường",
                    Code: "122424",
                    Gender: "Name",
                    Old: 19,
                    Email: "caocuong61299@gmail.com"
                },
                {
                    FullName: "Cao Văn Cường",
                    Code: "122424",
                    Gender: "Name",
                    Old: 19,
                    Email: "caocuong61299@gmail.com"
                },
                {
                    FullName: "Cao Văn Cường",
                    Code: "122424",
                    Gender: "Name",
                    Old: 19,
                    Email: "caocuong61299@gmail.com"
                },
                {
                    FullName: "Cao Văn Cường",
                    Code: "122424",
                    Gender: "Name",
                    Old: 19,
                    Email: "caocuong61299@gmail.com"
                },
                {
                    FullName: "Cao Văn Cường",
                    Code: "122424",
                    Gender: "Name",
                    Old: 19,
                    Email: "caocuong61299@gmail.com"
                },
                {
                    FullName: "Cao Văn Cường",
                    Code: "122424",
                    Gender: "Name",
                    Old: 19,
                    Email: "caocuong61299@gmail.com"
                }
            ]
        }
    }
}
</script>
<style lang="scss" scoped>
.cc-profile{
    height: 100%;
    .profile-header{
        height: 36px;
        display: flex;
        align-items: center;
        justify-content: space-between;
    }
}
</style>