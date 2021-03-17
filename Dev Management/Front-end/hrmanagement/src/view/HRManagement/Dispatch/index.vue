<template>
  <div class="ms-draggable">
    
              
              <div class="item-dragg flex" v-for="element in columnInfo__" :key="element.id">
                  <DxCheckBox :value="element.visible"  @valueChanged="handleValueChange($event,element)" />
                  <span class="dragg-text">{{element.name}}</span>
                  <span class="icon icon-draggable"></span>
              </div>
              
  </div>

</template>

<script>
import { DxCheckBox } from 'devextreme-vue/check-box';
export default {
  name:"MsDraggable",
  components:{
     DxCheckBox
  },
  props:{
    columnInfo_: Array
  },
  data() {
    return {
      columnInfo__: {
          id: 1,
          name: "a"
      }
    }
  },
  watch:{
  },
  methods: {
    handleValueChange(e,id){
      
      // this.columnInfo__.forEach(element => {
      //   if(element.id == id){
      //     element.visible = e.value;
      //     console.log(e.value);
      //   }
      // });
      debugger
      console.log(e,id);
    }
  },
}
</script>

<style scoped>
  .draggable-menu{
  position: absolute;
  z-index: 111111;
   top:170px;
   padding: 10px;
   background: #fff;
   border-radius: 5px;
   -webkit-box-shadow: 0 5px 25px 0 rgb(0 0 0 / 10%);
   box-shadow: 0px 0px 10px 0 rgb(0 0 0 / 15%); 
   padding: 8px;
   margin: 0;
}

.dragg-text{
  width: 150px;
}
.item-dragg{
    color: #333;
    font-weight: 400;
    --vs-primary: 4,24,71;
    --vs-success: 40,199,111;
    --vs-danger: 234,84,85;
    --vs-warning: 255,159,67;
    --vs-dark: 30,30,30;
    --vs-orange: 255,145,0;
    line-height: 1.35715;
    pointer-events: auto;
    visibility: visible;
    -webkit-tap-highlight-color: transparent;
    font-size: 14px;
    border-radius: 6px;
    padding: 11px 6px 8px 10px;
     justify-content: space-between;
    
}
.draggable-menu .search{
 
    width: 210px;
    margin-left: 10px;

}
.title-text{
  font-size: 20px;
    letter-spacing: .384px!important;
    font-weight: 700;
}
.filter-title{
  height: 30px;
  margin: 0 0 12px ;
  justify-content: space-between;
}
</style>