import BaseApi from './base';

export default{
    //Hàm get ALL
    controller: "Contract",
    async GetAll(){
        return  BaseApi.GetAll(this.controller);
    },
    //Hàm thêm
    async Insert(data){
        return  BaseApi.Insert(this.controller,data);
    },
    //Hàm sửa
    async Update(data){
        return  BaseApi.Update(this.controller,data);
    },
    //Hàm xóa
    async Delete(id){
        return  BaseApi.Delete(this.controller,id);
    },
}
