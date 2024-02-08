using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParamArgs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /**
         * Form이 처음 표시(로드)될 때 발생한다.
         * 폼이 생성되고 메모리에 로드된 후 사용자에게 처음 보여지기 직전에 발생한다.
         * 폼이 로드되고 사용자에게 보여지기 전에 코드를 실행할 수 있다.
         */
        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("\n----- Start -----------------------------------\n");

            /** 파라미터, 아규먼트 사용 */
            UseParameterArgument();

            Console.WriteLine("\n----- End -----------------------------------\n");
        }

        private void UseParameterArgument()
        {
            object param = "매개변수(Parameter) 보내기.";
            Console.WriteLine(param);

            CallMethod(param);
        }

        private void CallMethod(object args)
        {
            object param = args;
            param += "그리고, 인수(Argument) 받기";

            Console.WriteLine(param);
        }
    }
}
