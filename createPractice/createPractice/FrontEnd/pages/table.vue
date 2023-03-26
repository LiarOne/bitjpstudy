<template>
    <div>
        <div>
            <v-row style="text-align: left;" class="mt-5 mb-5 ml-5">
                <v-btn class="mr-2" @click="registerDialogFlag=true">添加数据</v-btn>
                <v-btn class="mr-2" @click="searchAll()">检索全部</v-btn>
                <v-btn class="mr-2">检索数据(x)</v-btn>
            </v-row>
        </div>
        <v-data-table
        id="userInfoTable"
        :headers="header"
        :items="userInfoData"
        class="userTable"
        >
         <template #[`item.editButton`]="{ item }">
            <v-btn @click="editDialogFlag=true
                           editId=item.userId">
                编辑
            </v-btn>
         </template>
    </v-data-table>
    <registerDialog
       :registerDialogFlag.sync="registerDialogFlag"
    ></registerDialog>
    <editDialog
       v-if="editDialogFlag"
       v-model="editDialogFlag"
       :editId="editId"
    ></editDialog>
    </div>
  </template>
  
  <script>
  import registerDialog from '~/components/registerDialog.vue'
  import editDialog from '~/components/editDialog.vue'

  export default {
    name: 'TablePage',
    components:{
        registerDialog,
        editDialog,
    },
    data(){
      return {
        registerDialogFlag:false,
        editDialogFlag:false,
        editId:'',
        userName:'',
        userAge: '',
        userInfoData:[],
        header: [
            {
                text:'用户ID',
                value:'userId',
            },
            {
                text:'姓名',
                value:'userName',
            },
            {
                text:'年龄',
                value:'userAge',
            },
            {
                text:'注册时间',
                value:'registerTime',
            },
            {
                value:'editButton',
                sortable: false,
            },
        ],
      }
    },
    methods: {
      searchAll(){
        const self = this
        this.$axios
        .get('/api/WeatherForecast')
        .then((response)=>{
            self.userInfoData=response.data
        })
        .catch(function (error){
            console.log('search all failed:', error)
        })
      },
    }
  }
  </script>
  
  <style lang="scss" scoped>

.userTable :deep(){

}
</style>