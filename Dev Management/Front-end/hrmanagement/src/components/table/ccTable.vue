<template>
    <div class="cc-table">
        <DxDataGrid
            :data-source="dataSource"
            :remote-operations="false"
            :allow-column-reordering="true"
            :row-alternation-enabled="false"
            :show-borders="true"
            :columnAutoWidth="true"
            :hoverStateEnabled="true"
            height="100%"
            @content-ready="onContentReady"
        >
            <DxColumn
                v-if="buttonMore"
                cell-template="button-more"
                :fixed="true"
                width="50"
            />
            <DxSelection
                select-all-mode="page"
                show-check-boxes-mode="always"
                mode="multiple"
                :fixed="true"
                width="50"
                />
            <DxColumn
                v-for="(item,index) in listHeader"
                :key="index"
                :data-field="item.dataField"
                :caption="item.caption"
                :width="item.width"
                :min-width="item.minWidth"
            />
            <template #button-more>
                <div class="btn-icon" style="margin: -6px;">
                    <div class="icon-three-dot"></div>
                </div>
            </template>
        </DxDataGrid>
    </div>
</template>
<script>
import {
  DxDataGrid,
  DxColumn,
  DxSelection
} from 'devextreme-vue/data-grid';
export default {
    components: {
        DxDataGrid,
        DxColumn,
        DxSelection
    },
    props: {
        listHeader: {
            type: Array,
            default: ()=>[]
        },
        dataSource: { 
            type: Array,
            default: ()=>[]
        },
        buttonMore: {
            type: [String,Boolean],
            default: true
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
    height: 100%;
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
        padding: 14px 12px;
        color: #000000;
    }
    .dx-datagrid-headers .dx-datagrid-table .dx-row > td{
        border: none;
        padding: 14px 12px;
        color: #000000;
        font-weight: 500;
        &:hover{
            border-right: 1px solid #dddddd;
        }
    }
    .dx-datagrid-headers .dx-datagrid-table .dx-row > td:last-child{
        border: none !important;
    }
    .dx-datagrid-checkbox-size .dx-checkbox-icon{
        width: 20px;
        height: 20px;
        border-radius: 4px;
        &:hover{
            border: 1px solid #0075FF;
        }
    }
    .dx-datagrid-checkbox-size.dx-checkbox-checked .dx-checkbox-icon{
        font-size: 14px;
    }
    .dx-checkbox-checked .dx-checkbox-icon{
        color:  #0075FF;
    }
    .dx-datagrid-rowsview .dx-selection.dx-row:not(.dx-row-focused) > td {
        background-color: #EBF4FF;
    }
    .dx-datagrid .dx-datagrid-rowsview .dx-data-row td.dx-pointer-events-none{
        border-left: none;
    }
    .dx-datagrid .dx-datagrid-rowsview .dx-freespace-row td.dx-pointer-events-none{
        border-left: none;
    }
}
</style>