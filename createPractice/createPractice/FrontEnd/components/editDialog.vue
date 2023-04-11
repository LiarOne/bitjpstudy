<template>
    <v-dialog
      v-model="dialogFlag"
      :retain-focus="false"
      scrollable
      width="900px"
    >
      <v-card>
        <v-container>
            <v-row justify="end" no-gutters>
                <v-col cols="auto">
                    <v-icon @click="dialogFlag=false"> mdi-close </v-icon>
                </v-col>
            </v-row>
        </v-container>
        <v-card-title class="justify-center">编辑页面</v-card-title>
        <v-card-text>
            <v-container>
                <v-row>
                    <v-chip>用户姓名</v-chip>
                    <v-text-field
                      v-model="editData.userName"
                    ></v-text-field>
                </v-row>
                <v-row>
                    <v-chip>用户年龄</v-chip>
                    <v-text-field
                      v-model="editData.userAge"
                    ></v-text-field>
                </v-row>
            </v-container>
        </v-card-text>
        <v-card-actions class="justify-center">
            <v-btn @click="edit()">修改</v-btn>
            <v-btn @click="deleteDialogFlag=true">删除</v-btn>
        </v-card-actions>
      </v-card>
      <!--删除确认界面-->
      <v-dialog v-model="deleteDialogFlag" :retain-focus="false" persistent width="500">
        <v-card-text>是否删除？</v-card-text>
        <v-card-actions>
            <v-btn @click="deleteData()">是</v-btn>
            <v-spacer></v-spacer>
            <v-btn @click="deleteDialogFlag=false">否</v-btn>
        </v-card-actions>
      </v-dialog>
      <!--删除确认界面-->
    </v-dialog>
</template>

<script>
export default {
    props:['value','editId'],
    data(){
        return {
            deleteDialogFlag:false,
            editData:{
                userId:'',
                userName:'',
                userAge:'',
                registerTime:'',
            },
        }
    },
    computed:{
      dialogFlag:{
        get(){
          return this.value
        },
        set(val){
          this.$emit('input',val)
        }
      }
    },
    mounted(){
      this.searchById(this.editId)
    },
    methods: {
      searchById(userId){
            const queries = {
                userId,
            }
            const self = this
            this.$axios
              .get('/api/WeatherForecast/search',{params:queries})
              .then((response)=>{
                self.editData=response.data
              })
              .catch(function (error){
                console.log('search by id failed:', error)
              })
        },
        edit(){
            const queries = {
                userId: this.editData.userId,
                userName: this.editData.userName,
                userAge: this.editData.userAge,
            }
            const self = this
            this.$axios
              .put('/api/WeatherForecast', queries)
              .then((response)=>{
                console.log('userId: '+ response.data.userId)
                console.log('userName: '+ response.data.userName)
                console.log('userAge: '+ response.data.userAge)
                console.log('registerTime: '+ response.data.registerTime)
                self.dialogFlag=false
              })
              .catch(function (error){
                console.log('edit failed:', error)
              })
        },
        deleteData(){
            const queries={
                userId:this.editData.userId
            }
            const self = this
            this.$axios
              .delete('/api/WeatherForecast', {params:queries})
              .then((response)=>{
                console.log('delete result: '+ response.data)
                self.dialogFlag=false
              })
              .catch(function (error){
                console.log('edit failed:', error)
              })
        },
    },
}
</script>