<template>
    <div class="h-100">
        <div class="header flex align-center between">
            <div class="flex align-center">
                <div class="btn-icon-2 m-r-16" @click="back">
                    <div class="icon-back"></div>
                </div>
                <div class="title" v-if="mode == 1">Thêm hợp đồng</div>
                <div class="title" v-if="mode == 2 && contract.ContractName">{{contract.ContractName}}</div>
            </div>
            <div class="flex align-center">
                <cc-button class="m-r-12" type="secondary" @click="back">Hủy</cc-button>
                <cc-button @click="save">Lưu</cc-button>
            </div>
        </div>
        <div class="content">
            <cc-group title="Thông tin chung">
                <cc-row>
                    <cc-col w="15">
                        Tên hợp đồng
                    </cc-col>
                    <cc-col w="30" class="m-r-60">
                        <cc-input v-model="contract.ContractName"></cc-input>
                    </cc-col>
                    <cc-col w="15">
                        Loại hợp đồng
                    </cc-col>
                    <cc-col w="30">
                        <cc-select-box></cc-select-box>
                    </cc-col>
                </cc-row>
                <cc-row>
                    <cc-col w="15">
                        Nhân viên
                    </cc-col>
                    <cc-col w="30" class="m-r-60">
                        <cc-input v-model="contract.EmployeeName"></cc-input>
                    </cc-col>
                    <cc-col w="15">
                        Đơn vị công tác
                    </cc-col>
                    <cc-col w="30">
                        <cc-organization-unit v-model="contract.OrganizationUnitID" @selected="changeOrg"></cc-organization-unit>
                    </cc-col>
                </cc-row>
                <cc-row>
                    <cc-col w="15">
                        Vị trí công việc
                    </cc-col>
                    <cc-col w="30" class="m-r-60">
                        <cc-select-box></cc-select-box>
                    </cc-col>
                    <cc-col w="15">
                        Ngày áp dụng
                    </cc-col>
                    <cc-col w="30">
                        <cc-date v-model="contract.Date"></cc-date>
                    </cc-col>
                </cc-row>
                <cc-row>
                    <cc-col w="15">
                        Ngày bắt đầu
                    </cc-col>
                    <cc-col w="30" class="m-r-60">
                        <cc-date v-model="contract.FromDate"></cc-date>
                    </cc-col>
                    <cc-col w="15">
                        Ngày kết thúc
                    </cc-col>
                    <cc-col w="30">
                        <cc-date v-model="contract.ToDate"></cc-date>
                    </cc-col>
                </cc-row>
                 <cc-row>
                    <cc-col w="15">
                        Lương cơ bản
                    </cc-col>
                    <cc-col w="30" class="m-r-60">
                        <cc-input></cc-input>
                    </cc-col>
                    <cc-col w="15">
                        Phúc lợi
                    </cc-col>
                    <cc-col w="30">
                        <cc-input></cc-input>
                    </cc-col>
                </cc-row>
                <cc-row>
                    <cc-col w="15">
                        Chế độ lương thưởng
                    </cc-col>
                    <cc-col w="30" class="m-r-60">
                        <cc-input></cc-input>
                    </cc-col>
                </cc-row>
            </cc-group>
            <cc-group title="Ghi chú" class="m-t-24">
                <cc-row>
                    <cc-col w="35">
                        <cc-input></cc-input>
                    </cc-col>
                </cc-row>
            </cc-group>
        </div>
    </div>
</template>
<script>
import ContractAPI from "@/api/ContractAPI.js";
export default {
    props: {
        mode: {
            type: [String,Number],
            default: 1
        },
        dataDetail: {
            type: Object,
            default: () => {}
        }
    },
    data(){
        return{
            listType: [
                {
                    ID: 1
                }
            ],
            contract: {
                ContractID: null,
                ContractName: null,
                EmployeeID: null,
                EmployeeCode: null,
                EmployeeName: null,
                OrganizationUnitID: null,
                OrganizationUnitName: null,
                Type: null,
                CreatorID: null,
                CreatorName: null,
                Date: null,
                FromDate: null,
                ToDate: null,
                JobtitleName: null,
                JobtitleID: null,
                Salary: null,
                Note: null
            }
        }
    },
    watch: {
        dataDetail:{
            handler(val){
                if(this.mode == 2){
                    this.contract = val;
                }
            },
            immediate: true
        }
    },
    methods: {
        back(){
            this.$emit("close",false);
        },
        async save(){
            this.contract.OrganizationUnitID = this.contract.OrganizationUnitID[0];
            if(this.mode == 1){
                var res = await ContractAPI.Insert(this.contract);
                if(res.data && res.data.Success){
                    this.$emit("close", true);
                }
                else{
    
                }
            }
            else if(this.mode == 2){
                var res = await ContractAPI.Update(this.contract);
                if(res.data && res.data.Success){
                    this.$emit("close", true);
                }
                else{
    
                }
            }
        },
        changeOrg(val){
            this.contract.OrganizationUnitName = val.OrganizationUnitName;
        }
    }
}
</script>
<style lang="scss" scoped>
.header{
    margin-bottom: 16px;
    .title{
        font-size: 24px;
        font-weight: 500;
    }
}
.content{
    height: calc(100% - 52px);
    overflow: auto;
}
</style>