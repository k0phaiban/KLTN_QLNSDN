<template>
    <div class="cc-table">
        <DxDataGrid
            :data-source="dataSource"
            :remote-operations="false"
            :allow-column-reordering="true"
            :row-alternation-enabled="false"
            :show-borders="true"
            @content-ready="onContentReady"
        >
            <DxColumn
                v-for="(item,index) in listHeader"
                :key="index"
                :data-field="item.dataField"
                :caption="item.caption"
            />
        </DxDataGrid>
    </div>
</template>
<script>
import {
  DxDataGrid,
  DxColumn
} from 'devextreme-vue/data-grid';
export default {
    components: {
        DxDataGrid,
        DxColumn,
    },
    props: {
        listHeader: {
            type: Array,
            default: ()=>[]
        },
        dataSource: { 
            type: Array,
            default: ()=>[]
        }
    },
    data(){
        return{

        }
    }
    
}
</script>
<style lang="scss">
.cc-table{
    .dx-datagrid-rowsview .dx-row{
        height: 48px;
        border-top: 1px solid #dddddd !important;
        border-bottom: none;
    }
    .dx-datagrid-borders > .dx-datagrid-headers{
        border-top-left-radius: 8px;
        border-top-right-radius: 8px;
        border: none;
        background-color: #ffffff;
        .dx-datagrid-table {
            height: 50px;
        }
    }
    .dx-datagrid{
        border-radius: 8px;
    }
    .dx-datagrid-borders > .dx-datagrid-rowsview{
        border: none;
    }

    .dx-datagrid-rowsview .dx-row > td{
        border: none;
    }
    .dx-datagrid-headers .dx-datagrid-table .dx-row > td{
        border: none;
        &:hover{
            border-right: 1px solid #dddddd;
        }
    }
    .dx-datagrid-headers .dx-datagrid-table .dx-row > td:last-child{
        border: none !important;
    }
}
</style>