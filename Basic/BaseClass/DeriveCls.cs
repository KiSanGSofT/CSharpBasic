using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
    internal class DeriveCls : BaseCls
    {
        public void PrintBaseClassValue()
        {
            // 베이스 클래스의 Age 속성 사용
            Console.WriteLine($"기본클래스 값: {this.anyVal}");
        }
    }
}
