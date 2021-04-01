<template>
    <div class="cc-organization-unit">
        <div v-if="type == 1" class="h-100">
            <div class="organization-header m-b-12">
                <div class="f-title">Đơn vị</div>
                <div>
                    <cc-button @click="openAdd">Thêm</cc-button>
                </div>
            </div>
            <div style="height: calc(100% - 48px);">
                <ccTreeList
                    keyField="OrganizationUnitID"
                    parentKey="ParentID"
                    :listHeader="listHeader" 
                    :dataSource="dataSource"
                >
                </ccTreeList>
            </div>
        </div>
        <AddOrganizationUnit v-if="type == 2" @close="getAll"></AddOrganizationUnit>
    </div>
</template>
<script>
import AddOrganizationUnit from "./AddOrganizationUnit";
import OrganizationUnitAPI from "@/api/OrganizationUnitAPI.js";
export default {
    components: {
        AddOrganizationUnit
    },
    data(){
        return{
            listHeader: [
                {
                    dataField: "OrganizationUnitName",
                    caption: "Tên đơn vị",
                    dataTyle: "text"
                },
                {
                    dataField: "Address",
                    caption: "Địa chỉ",
                    dataTyle: "text"
                },
                {
                    dataField: "Note",
                    caption: "Ghi chú",
                    dataTyle: "text"
                },
                {
                    dataField: "Status",
                    caption: "Trạng thái",
                    dataTyle: "text"
                }
            ],
            dataSource: null,
            type: 1
        }
    },
    methods: {
        openAdd(){
            this.type = 2;
        },
        async getAll(){
            this.type = 1;
            let me = this;
            var res = await OrganizationUnitAPI.GetAll();
            if(res.data && res.data.Success){
                me.dataSource = res.data.Data;
                debugger
            }
        }
    },
    async created(){
        await this.getAll();
    }
}
</script>
<style lang="scss" scoped>
.cc-organization-unit{
    height: 100%;
    .organization-header{
        height: 36px;
        display: flex;
        align-items: center;
        justify-content: space-between;
    }
}
</style>