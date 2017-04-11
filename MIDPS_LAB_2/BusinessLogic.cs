using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIDPS_LAB_2
{
    class BusinessLogic
    {
        private string number = "";
        private string number1 = "";
        private double result = 0;
        private string operation = "";
        private bool operationPressed = false;
        private bool operationPressed1 = false;
        bool isNegative = false;
        bool powButtonPressed = false;
        bool dotPressed = false;
        private string longExpression = "";

        public void SetIsNegative(bool sign)
        {
            this.isNegative = sign;
        }

        public void SetDotPressed(bool ok)
        {
            this.dotPressed = ok;
        }

        public bool GetCommaPressed()
        {
            return this.dotPressed;
        }

        public bool GetIsNegative()
        {
            return this.isNegative;
        }

        public void SetOperation(string oper)
        {
            this.operation = oper;
        }

        public string GetOperation()
        {
            return this.operation;
        }

        public double GetResult()
        {
            return this.result;
        }

        public void SetNumber(string exp)
        {
            this.number = exp;
        }

        public string GetNumber()
        {
            return this.number;
        }

        public void SetNumber1(string exp)
        {
            this.number1 = exp;
        }

        public string GetNumber1()
        {
            return this.number1;
        }

        public void SetOperationPressed(bool oper)
        {
            this.operationPressed = oper;
        }

        public bool GetOperationPressed()
        {
            return this.operationPressed;
        }


    }
}
