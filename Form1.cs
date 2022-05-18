using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LottoNumberGenerator
{
    public partial class Form1 : Form
    {
        /// <summary>
        ///  arrays for each label
        /// </summary>
        
        int[] displayNumArray1;
        int[] displayNumArray2;
        int[] displayNumArray3;
        int[] displayNumArray4;
        int[] displayNumArray5;
        int[] displayNumArray6;

        /// <summary>
        ///  random number for lottery
        /// </summary>
        Random rndNumGen = new Random();
        
        /// <summary>
        /// for unique number, hashset is used 
        /// </summary>
        HashSet<string> hashNum = new HashSet<string>();

        public Form1()
        {
            InitializeComponent();          
        }
        
    // ***** On Click Generate Number button *******************
        private void button1_Click(object sender, EventArgs e)
        {   
            PutLabelHashSet();            
        }

   //////////////////////////////////////////////////////////////
   // ****** This application includes two methods as below: ////
   //////////////////////////////////////////////////////////////   
   // ******  Method #1 - Display numbers on the labels

        public void Display()
        {           
            RndNumGenerate rnd = new RndNumGenerate();
                    
       // locate multiple numbers in the label before the unique numbers are chosen.
            displayNumArray1 = rnd.GetNumArray();
            foreach (var x in displayNumArray1)
            {
                lbl_num1.Text = x.ToString();
                Console.Write($"{x} ");                

          //// update is used for numbers on label update.
                lbl_num1.Update();                
                Thread.Sleep(10);
            }

            Console.WriteLine();

            displayNumArray2 = rnd.GetNumArray();
            foreach (var x in displayNumArray2)
            {
                lbl_num2.Text = x.ToString();
                Console.Write($"{x} ");
                lbl_num2.Update();
                Thread.Sleep(10);
            }
            /// this is just for check up
            Console.WriteLine();

            displayNumArray3 = rnd.GetNumArray();
            foreach (var x in displayNumArray3)
            {
                lbl_num3.Text = x.ToString();
                Console.Write($"{x} ");
                lbl_num3.Update();
                Thread.Sleep(10);
            }

            Console.WriteLine();

            displayNumArray4 = rnd.GetNumArray();
            foreach (var x in displayNumArray4)
            {
                lbl_num4.Text = x.ToString();
                Console.Write($"{x} ");
                lbl_num4.Update();
                Thread.Sleep(10);
            }

            Console.WriteLine();

            displayNumArray5 = rnd.GetNumArray();
            foreach (var x in displayNumArray5)
            {
                lbl_num5.Text = x.ToString();
                Console.Write($"{x} ");
                lbl_num5.Update();
                Thread.Sleep(10);
            }

            Console.WriteLine();

            displayNumArray6 = rnd.GetNumArray();
            foreach (var x in displayNumArray6)
            {
                lbl_num6.Text = x.ToString();                
                lbl_num6.Update();
                Thread.Sleep(10);
            }
            
        }

        // ******  Method #2  - PutLabelHashSet
        // ****** numbers to hashSet ***** to get unique number
        public void PutLabelHashSet()
        {        
       // **** check if the number of elements of hashNum is under 6
            while (hashNum.Count() < 6)
            {
           // get random numbers and display. Display goes first anyway and check the hasnum.count on the 
           // second round.
                Display();
                hashNum.Add(lbl_num1.Text);
                hashNum.Add(lbl_num2.Text);
                hashNum.Add(lbl_num3.Text);
                hashNum.Add(lbl_num4.Text);
                hashNum.Add(lbl_num5.Text);
                hashNum.Add(lbl_num6.Text);             
            }

            Console.WriteLine($"hashNum count : {hashNum.Count()}");

            hashNum.Clear();
            
        }
    }
}

