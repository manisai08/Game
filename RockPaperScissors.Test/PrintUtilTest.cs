using Xunit;
using System;
using RockPaperScissors.Contracts;

namespace RockPaperScissors.Test
{
    
    public class PrintUtilTest
    {
        private HandSign _exeHandSignResult;

        IHandSign ihandSign = new HandSign();


        /// <summary>
        /// Handlers the with valid input positive test.
        /// </summary>
        [Fact(DisplayName = "ChooseHandSign : Positive Scenario: Valid input")]
        public void ChooseHandSignPositive()
        {
            GetHandSignValidInput();
            GetHandSignExpectedValue();
        }


        /// <summary>
        /// Handlers the with valid input positive test.
        /// </summary>
        [Fact(DisplayName = "ChooseHandSign : Negative Scenario: Valid input")]
        public void ChooseHandSignNegative()
        {
            GetHandSignValidInput();
            GetHandSignWrongOutput();
        }


        /// <summary>
        /// Handlers the with valid input positive test.
        /// </summary>
        [Fact(DisplayName = "ChooseHandSign : Negative Scenario: InValid input")]
        public void ChooseHandSignInValid()
        {
            GetHandSignInValidInput();
            GetHandSignInValidOutput();
        }


        private void GetHandSignValidInput()
        {
            IPrintUtil iPrintUtil = new PrintUtil(ihandSign);
            string input = "R";
            _exeHandSignResult = iPrintUtil.ChooseHandSign(input);
        }


        private void GetHandSignInValidInput()
        {
            IPrintUtil iPrintUtil = new PrintUtil(ihandSign);
            string input = "T";
            _exeHandSignResult = iPrintUtil.ChooseHandSign(input);
        }


        /// <summary>
        /// To check the expected value -
        /// </summary>
        private void GetHandSignExpectedValue()
        {
            Assert.Equal(Model.Move.Rock, _exeHandSignResult.move);
        }


        /// <summary>
        /// To check the expected value -
        /// </summary>
        private void GetHandSignWrongOutput()
        {
            Assert.NotEqual(Model.Move.Scissors, _exeHandSignResult.move);
        }


        /// <summary>
        /// To check the expected value -
        /// </summary>
        private void GetHandSignInValidOutput()
        {
            Assert.Null(_exeHandSignResult);
        }


    }
}
