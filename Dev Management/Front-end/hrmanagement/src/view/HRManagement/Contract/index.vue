<template>
    <div class="h-100">
        <div class="cc-contract" v-if="type == 1">
            <div class="contract-header m-b-12">
                <div class="f-title">Hợp đồng</div>
                <div class="flex">
                    <cc-organization-unit class="m-r-12" style="width: 250px;"></cc-organization-unit>
                    <cc-button class="m-r-12" icon="icon-import" type="primary-border">Nhập khẩu</cc-button>
                    <cc-button icon="icon-plus-white" @click="type = 2">Thêm</cc-button>
                </div>
            </div>
            <div style="height: calc(100% - 48px);">
                <ccTable 
                    :listHeader="listHeader" 
                    :dataSource="dataSource">
                </ccTable>
            </div>
        </div>
        <AddContract v-if="type == 2"></AddContract>
    </div>
</template>
<script>
import ContractAPI from "@/api/ContractAPI.js";
import AddContract from "./AddContract"
export default {
    components: {
        AddContract
    },
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
            dataSource: [],
            type: 1
        }
    },
    methods: {
        async getAll(){
            this.type = 1;
            let me = this;
            var res = await ContractAPI.GetAll();
            if(res.data && res.data.success){
                me.dataSource = res.data.data;
            }
        }
    },
    async created(){
        await this.getAll();
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