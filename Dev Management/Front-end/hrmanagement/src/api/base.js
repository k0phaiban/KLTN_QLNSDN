import Axios from 'axios';

export default{
    api: "https://localhost:44367/api/",

    async Get(name){
        var res =  await Axios.get(this.api+name)
        return res
    },

    async Insert(name,data){
        var res =  await Axios.post(this.api+name, {data: data})
        return res
    }
}