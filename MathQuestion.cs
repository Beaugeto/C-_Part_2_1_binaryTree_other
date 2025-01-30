using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binaryTreeExample
{
    // TO DO: implement IComparable<MathQues> interface
    internal class MathQuestion : IComparable<MathQuestion>
    {

        // private data fields for a single math question
        // e.g 2 + 5 = 5
        // leftOperand is 2
        // rightOperand is 3
        // mathOp is +
        // answer is 5
        private int leftOperand;
        private string mathOp;
        private int rightOperand;
        private int answer;




        // public properties (provide public get() and set() methods for private instance data)
        // TO DO
        // LeftOperand
        // RightOperand
        // MathOp
        // Answer

        public int LeftOperand
        {
            get { return leftOperand; }
            set { leftOperand = value; }
        }
        public string MathOp
        {
            get { return mathOp; }
            set { mathOp = value; }
        }
        public int RightOperand
        {
            get { return rightOperand; }
            set { rightOperand = value; }
        }
        public int Answer
        {
            get { return answer; }
            set { answer = value; }
        }



        // constructor method
        public MathQuestion(int leftOperand, string mathOp, int rightOperand, int answer)
        {
            // TO DO
            LeftOperand = leftOperand;
            MathOp = mathOp;
            RightOperand = rightOperand;
            Answer = answer;
        }
        // CompareTo() method implementation from IComparable interface
        // compares answer of (this) object with that of the input otherMathObj answer
        // returns 0 if both answers are the same
        // returns -1 if the 'this' object is numerically less than the otherMathObj answer
        // returns 1 if the 'this' object is numerically greater than the otherMathObj answer

        public int CompareTo(MathQuestion otherMathObj)
        {
            if (this.answer > otherMathObj.answer)
            {
                return 1;
            }
            else if (this.answer < otherMathObj.answer)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }



        // ToQuestionStr() method returns a meth question string in the following format: "3 + 4 = 7"
        // Note: the string requires 4 spaces - these being the delimiters required for the Split() method
        public string ToQuestionStr()
        {
            // TO DO
            StringBuilder sb = new StringBuilder();
            sb.Append(leftOperand);
            sb.Append(" ");
            sb.Append(mathOp);
            sb.Append(" ");
            sb.Append(rightOperand);
            sb.Append(" = ");
            sb.Append(answer);
            return sb.ToString();

            
        }




        // ToString() over-ride method to return the math question string for a specific display purpose
        // Format example "7(3+4)"
        public override string ToString()
        {
            // TO DO
            return $"{answer}({leftOperand}{mathOp}{rightOperand})";


        }















    }
}
