<template>
    <div class="cc-contract">
        <div class="contract-header m-b-12">
            <div class="f-title">Hợp đồng</div>
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
                    dataField: "contractName",
                    caption: "Tên hợp đồng",
                    dataTyle: "text",
                    minWidth: 150
                },
                {
                    dataField: "employeeName",
                    caption: "Nhân viên",
                    dataTyle: "text",
                    minWidth: 150
                },
                {
                    dataField: "organizationUnitName",
                    caption: "Đơn vị",
                    dataTyle: "text",
                    minWidth: 150
                },
                {
                    dataField: "jobtitleName",
                    caption: "Vị trí công việc",
                    dataTyle: "text",
                    minWidth: 150
                },
                {
                    dataField: "salary",
                    caption: "Lương cơ bản",
                    dataTyle: "text",
                    minWidth: 150
                },
                {
                    dataField: "dateApply",
                    caption: "Ngày áp dụng",
                    dataTyle: "number",
                    minWidth: 150
                },
                {
                    dataField: "type",
                    caption: "Loại hợp đồng",
                    dataTyle: "text",
                    minWidth: 150
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
.cc-contract{
    height: 100%;
    .contract-header{
        height: 36px;
        display: flex;
        align-items: center;
        justify-content: space-between;
    }
}
</style>