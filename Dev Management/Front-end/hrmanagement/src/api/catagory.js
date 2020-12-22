import Api from './base';

export default{
    async GetListCatagory(){
        var res =  await Api.Get('Catagories')
        return res
    },

    async InsertCatagory(data){
        var res =  await Api.Insert('Catagories',data)
        return res
    }
}