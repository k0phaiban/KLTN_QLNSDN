import BaseApi from './base';

export default{
    //Hàm get ALL
    controller: "OrganizationUnit",
    async GetAll(){
        return  BaseApi.GetAll(this.controller);
    },
    async Insert(data){
        return  BaseApi.Insert(this.controller,data);
    }
}
