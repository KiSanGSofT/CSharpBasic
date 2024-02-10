using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendParam_ReceiveArgu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

private void Form1_Load(object sender, EventArgs e)
{

    Console.WriteLine($"\n----- Start --------------------\n");

    object param = "100";

    Console.WriteLine($"매개변수(파라미터/Parameter) : {param} 값을 보냅니다.");

    SendParamReceiveArgument(param);

    Console.WriteLine($"\n----- End --------------------\n");
}

private void SendParamReceiveArgument(object args)
{
    Console.WriteLine($"인수(아규먼트/Argument) : {args} 값을 받습니다.");
}
    }
}