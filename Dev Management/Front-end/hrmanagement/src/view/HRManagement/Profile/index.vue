<template>
    <div class="cc-profile">
        Hồ sơ
        <div style="height: 500px;">
            <ccTable 
                :listHeader="listHeader" 
                :dataSource="dataSource">
            </ccTable>
        </div>
    </div>
</template>
<script>
import ccTable from '../../../components/table/ccTable';
export default {
    components: {
        ccTable
    },
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
</style>