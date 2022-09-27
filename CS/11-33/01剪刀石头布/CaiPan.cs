using System;
using System.Collections.Generic;
using System.Text;

namespace _01剪刀石头布
{
    enum Result
    {
        玩家赢,
        电脑赢,
        平手
    }
    class CaiPan
    {
        public Result GetResult(int playerNumber,int cpuNumber)
        {
            if(playerNumber-cpuNumber==-1||playerNumber-cpuNumber==2)
            {
                return Result.玩家赢;
            }
            else if(playerNumber-cpuNumber==0)
            {
                return Result.平手;
            }
            else
            {
                return Result.电脑赢;
            }
        }
    }
}
