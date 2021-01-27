import Axios from 'axios';

export default{

    api: "https://localhost:44343/api/",

    controller: "",

    async Get(route){
        var res =  await Axios.get(this.api + this.controller + route)
        return res
    },

    async Post(route,data){
        var res =  await Axios.get(this.api + this.controller + route, data)
        return res
    },

    async Delete(route){
        var res =  await Axios.get(this.api + this.controller + route)
        return res
    },

    async Insert(controller,data){
        var res =  await Axios.post(this.api + controller + "/insert", data)
        return res
    },

    //Hàm get ALL
    async GetAll(controller){
        return  await Axios.get(this.api +controller + "/get-all");
    }
}
