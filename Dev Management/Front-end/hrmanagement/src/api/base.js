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

    async Delete(controller,id){
        var res =  await Axios.delete(this.api + controller + `/${id}`);
        return res;
    },

    async Insert(controller,data){
        var res =  await Axios.post(this.api + controller + "/insert", data);
        return res;
    },

    async Update(controller,data){
        var res =  await Axios.post(this.api + controller + "/update", data);
        return res;
    },

    //Hàm get ALL
    async GetAll(controller){
        return  await Axios.get(this.api +controller + "/get-all");
    }
}
