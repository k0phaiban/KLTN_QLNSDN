<template>
    <div>
        <div class="header flex align-center between">
            <div class="flex align-center">
                <div class="btn-icon-2 m-r-16" @click="back">
                    <div class="icon-back"></div>
                </div>
                <div class="title">Thêm hợp đồng</div>
            </div>
            <div class="flex align-center">
                <cc-button class="m-r-12" type="secondary" @click="back">Hủy</cc-button>
                <cc-button @click="save">Lưu</cc-button>
            </div>
        </div>
        <div>
            <cc-group title="Thông tin chung">
                <cc-row>
                    <cc-col w="15">
                        Tên hợp đồng
                    </cc-col>
                    <cc-col w="30" class="m-r-60">
                        <cc-input v-model="organization.OrganizationUnitName" @childCode="setCCCOde"></cc-input>
                    </cc-col>
                    <cc-col w="15">
                        Loại hợp đồng
                    </cc-col>
                    <cc-col w="30">
                        <cc-input v-model="organization.OrganizationUnitName" @childCode="setCCCOde"></cc-input>
                    </cc-col>
                </cc-row>
                <cc-row>
                    <cc-col w="15">
                        Nhân viên
                    </cc-col>
                    <cc-col w="30" class="m-r-60">
                        <cc-input v-model="organization.OrganizationUnitName" @childCode="setCCCOde"></cc-input>
                    </cc-col>
                    <cc-col w="15">
                        Đơn vị công tác
                    </cc-col>
                    <cc-col w="30">
                        <cc-input v-model="organization.OrganizationUnitName" @childCode="setCCCOde"></cc-input>
                    </cc-col>
                </cc-row>
                <cc-row>
                    <cc-col w="15">
                        Vị trí công việc
                    </cc-col>
                    <cc-col w="30" class="m-r-60">
                        <cc-input v-model="organization.OrganizationUnitName" @childCode="setCCCOde"></cc-input>
                    </cc-col>
                    <cc-col w="15">
                        Ngày áp dụng
                    </cc-col>
                    <cc-col w="30">
                        <cc-input v-model="organization.OrganizationUnitName" @childCode="setCCCOde"></cc-input>
                    </cc-col>
                </cc-row>
                <cc-row>
                    <cc-col w="15">
                        Ngày bắt đầu
                    </cc-col>
                    <cc-col w="30" class="m-r-60">
                        <cc-input v-model="organization.OrganizationUnitName" @childCode="setCCCOde"></cc-input>
                    </cc-col>
                    <cc-col w="15">
                        Ngày kết thúc
                    </cc-col>
                    <cc-col w="30">
                        <cc-organization-unit v-model="organization.ParentID"></cc-organization-unit>
                    </cc-col>
                </cc-row>
                 <cc-row>
                    <cc-col w="15">
                        Lương cơ bản
                    </cc-col>
                    <cc-col w="30" class="m-r-60">
                        <cc-input v-model="organization.Address"></cc-input>
                    </cc-col>
                    <cc-col w="15">
                        Phúc lợi
                    </cc-col>
                    <cc-col w="30">
                        <cc-input v-model="organization.Address"></cc-input>
                    </cc-col>
                </cc-row>
                <cc-row>
                    <cc-col w="15">
                        Chế độ lương thưởng
                    </cc-col>
                    <cc-col w="30" class="m-r-60">
                        <cc-input v-model="organization.Address"></cc-input>
                    </cc-col>
                </cc-row>
            </cc-group>
            <cc-group title="Ghi chú" class="m-t-24">
                <cc-row>
                    <cc-col w="35">
                        <cc-input v-model="organization.Note"></cc-input>
                    </cc-col>
                </cc-row>
            </cc-group>
        </div>
    </div>
</template>
<script>
import OrganizationUnitAPI from "@/api/OrganizationUnitAPI.js";
export default {
    data(){
        return{
            organization: {
                OrganizationUnitID: null,
                OrganizationUnitName: null,
                ParentID: null,
                Address: null,
                CCCode: null,
                Status: 0,
                Note: null
            }
        }
    },
    methods: {
        back(){
            this.$emit("close",false);
        },
        async save(){
            this.organization.ParentID = [...this.organization.ParentID].join("");
            var res = await OrganizationUnitAPI.Insert(this.organization);
            if(res.data && res.data.success){
                this.$emit("close", true);
            }
            else{

            }
        },
        setCCCOde(val){
            this.organization.CCCode = val;
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
</style>