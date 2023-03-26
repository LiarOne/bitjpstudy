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
                      v-model="inputUserName"
                    ></v-text-field>
                </v-row>
                <v-row>
                    <v-chip>用户年龄</v-chip>
                    <v-text-field
                      v-model="inputUserAge"
                    ></v-text-field>
                </v-row>
            </v-container>
        </v-card-text>
        <v-card-actions class="justify-center">
            <v-btn @click="register()">添加</v-btn>
        </v-card-actions>
      </v-card>
    </v-dialog>
</template>

<script>
export default {
    props:['registerDialogFlag'],
    data(){
        return {
            inputUserName:'',
            inputUserAge:'',
        }
    },
    computed:{
        dialogFlag:{
            get(){
                return this.registerDialogFlag
            },
            set(val){
                this.$emit('update:registerDialogFlag',val)
            }
        },
    },
    methods: {
        register(){
            const queries = {
                userName: this.inputUserName,
                userAge: this.inputUserAge,
            }
            const self = this
            this.$axios
              .post('/api/WeatherForecast', queries)
              .then((response)=>{
                console.log('userId: '+ response.data.userId)
                console.log('userName: '+ response.data.userName)
                console.log('userAge: '+ response.data.userAge)
                console.log('registerTime: '+ response.data.registerTime)
                self.dialogFlag=false
              })
              .catch(function (error){
                console.log('register failed:', error)
              })
        },
    },
}
</script>