using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();           
        }

        delegate string CalculateAction(int a,int b);
        CalculateAction action;

        public int FirstNumber  //第一個輸入參數
        {
            get; private set;
        }

        public int SecondNumber  //第二個輸入參數
        {
            get; private set;
        }

        private string CalculatePlus(int a, int b)
        {
            string result = (a + b).ToString();
            return result;
        }

        private string CalculateLess(int a, int b)
        {
            string result = (a - b).ToString();
            return result;
        }

        //string symbol = string.Empty;

        //數字1
        private void One(object sender, EventArgs e)
        {
            //string word = "max";
            //object gggggg = (object)word;
            Button one = (Button)sender;
            //string hhh = one.Text;
            screen.Text = screen.Text + one.Text;
            
        }

        //數字2
        private void Two(object sender, EventArgs e)
        {
            Button two = (Button)sender;
            screen.Text = screen.Text + two.Text;
        }

        //數字3
        private void Three(object sender, EventArgs e)
        {
            Button three = (Button)sender;
            screen.Text = screen.Text + three.Text;
        }

        //加法按鈕
        private void Plus(object sender, EventArgs e)
        {
            //Button plus = (Button)sender;
            //symbol = plus.Text;
            FirstNumber = Convert.ToInt32(screen.Text);
            screen.Text = "";
            action = CalculatePlus;
        }

        //減法按鈕
        private void Less(object sender, EventArgs e)
        {
            //Button less = (Button)sender;
            //symbol = less.Text;
            FirstNumber = Convert.ToInt32(screen.Text);
            screen.Text = "";
            action = CalculateLess;
        }

        //等於按鈕
        private void equals(object sender, EventArgs e)
        {
            SecondNumber = Convert.ToInt32(screen.Text);
            string result = "0";
            CalculateAction kk = new CalculateAction(action);
            result = kk(FirstNumber,SecondNumber);
            //switch (symbol)
            //{
            //    case "+":
            //        result = FirstNumber + SecondNumber;
            //        break;
            //    case "-":
            //        result = FirstNumber - SecondNumber;
            //        break;
            //}
            screen.Text = result;
        }

        //顯示結果欄位
        private void DisplayForm(object sender, EventArgs e)
        {
            
        }

        
    }
}
