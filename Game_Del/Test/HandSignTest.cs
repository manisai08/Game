﻿using Xunit;
using System;
using RockPaperScissors.Contracts;
using RockPaperScissors.Model;

namespace RockPaperScissors.Test
{

    public class HandSignTest2
    {
        private HandSign _exeHandSignResult;

        readonly IPrintUtil iprintUtil;
        readonly IHandSign ihandSign = new HandSign();

        public HandSignTest2() {
            iprintUtil = new PrintUtil(ihandSign);
        }

        ///// <summary>
        ///// Handlers the with valid input positive test.
        ///// </summary>
        //[Fact(DisplayName = "HandSignWithMapStringToMove : Positive Scenario: Valid input")]
        //public void HandSignWithMapStringToMove()
        //{
        //    GetValidHandSign();
        //    CheckMapStringToMoveExpectedValue();
        //}
        //private void GetValidHandSign()
        //{
        //    string input = "R";
        //    _exeHandSignResult = ihandSign.MapStringToMove(input);
        //}
        ///// <summary>
        ///// To check the expected value -
        ///// </summary>
        //private void CheckMapStringToMoveExpectedValue()
        //{
        //    Assert.NotNull(_exeHandSignResult);
        //}
    }
}