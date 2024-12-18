using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day21
{
    //확장메소드 만들기 위해선, 정적클래스 필요
    static class SHYExtendedMethod //스태틱 붙이기
    {
        //정적 메서드 생성하되, 반환값, 함수 이름, 기능을 추가하고자 하는 this 클래스 명
        public static int NextInclueEndNum(this Random rd, int startNum, int endNum)
        {
            int temp = rd.Next(startNum, endNum + 1);

            return temp;
        }

        public static void AddedFunc(this DontTouch dt)
        {
            Console.WriteLine(dt.messageToOther + " 했지롱");
        }

        //List<T> 여기에 기능 추가해볼 것

        public static void PrintAllMembers<T>(this List<T> list)
        {
            foreach( T element in list)
            {
                Console.Write( element + "\t");
            }

            Console.WriteLine();
        }

    }
}
