using Xunit;
using System;
using RockPaperScissors.Contracts;
using RockPaperScissors.Model;

namespace RockPaperScissors.Test
{

    public class HandSignTest
    {
        private HandSign _exeHandSignResult;
        private Move _exeMoveResult;
        private Player player1 = null;
        private Player player2 = null;
        private readonly IHandSign ihandSign = new HandSign();
        private int winner = -1;

        public HandSignTest() {
        }

        /// <summary>
        /// Handlers the with valid input positive test.
        /// </summary>
        [Fact(DisplayName = "HandSignWithMapStringToMove : Positive Scenario: Valid input")]
        public void HandSignWithMapStringToMove()
        {
            GetValidHandSign();
            CheckMapStringToMoveExpectedValue();
        }
        private void GetValidHandSign()
        {
            string input = "R";
            _exeHandSignResult = ihandSign.MapStringToMove(input);
        }


        /// <summary>
        /// Handlers the with valid input positive test.
        /// </summary>
        [Fact(DisplayName = "HandSignWithMapStringToMove : Negative Scenario: Valid input")]
        public void HandSignWithMapStringToMoveNegative()
        {
            GetValidHandSignNegative();
            CheckMapStringToMoveExpectedValueNegative();
        }
        private void GetValidHandSignNegative()
        {
            string input = "S";
            _exeHandSignResult = ihandSign.MapStringToMove(input);
        }

        /// <summary>
        /// To check the expected value -
        /// </summary>
        private void CheckMapStringToMoveExpectedValueNegative()
        {
            Assert.NotEqual(Move.Rock, _exeHandSignResult.move);
            Assert.NotEqual(Move.Paper, _exeHandSignResult.move);
        }


        /// <summary>
        /// Handlers the with valid input positive test.
        /// </summary>
        [Fact(DisplayName = "HandSignWithMapStringToMove : Negative Scenario: InValid input")]
        public void HandSignWithMapStringToMoveInvalid()
        {
            GetValidHandSignInvalid();
            CheckMapStringToMoveExpectedValueInValid();
        }
        private void GetValidHandSignInvalid()
        {
            string input = string.Empty;
            _exeHandSignResult = ihandSign.MapStringToMove(input);
        }


        /// To check the expected value -
        /// </summary>
        private void CheckMapStringToMoveExpectedValueInValid()
        {
            Assert.Null(_exeHandSignResult);
        }


        /// <summary>
        /// To check the expected value -
        /// </summary>
        private void CheckMapStringToMoveExpectedValue()
        {
            Assert.NotNull(_exeHandSignResult);
        }

        /// <summary>
        /// Handlers the with valid  positive test.
        /// </summary>
        [Fact(DisplayName = "HandSignWithGetWinningMove : Positive Scenario: Valid input")]
        public void HandSignWithGetWinningMove()
        {
            GetValidMove();
            CheckGetWinningMoveExpectedValue();
        }
        private void GetValidMove()
        {
            _exeMoveResult = ihandSign.GetWinningMove(Move.Rock);
        }
        private void CheckGetWinningMoveExpectedValue()
        {
            Assert.Equal(Move.Paper,_exeMoveResult);
        }


        /// <summary>
        /// Handlers the with valid input positive test.
        /// </summary>
        [Fact(DisplayName = "HandSignWithGetWinningMove : Negative Scenario: InValid input")]
        public void HandSignWithGetWinningMoveInValid()
        {
            GetInValidMove();
            CheckGetWinningMoveExpectedValueInValid();
        }
        private void GetInValidMove()
        {
            _exeMoveResult = ihandSign.GetWinningMove(Move.Scissors);
        }
        private void CheckGetWinningMoveExpectedValueInValid()
        {
            Assert.Equal(Move.Rock, _exeMoveResult);
        }



        /// <summary>
        /// Handlers the with valid input positive test.
        /// </summary>
        [Fact(DisplayName = "HandSignGetWinnerUser : Positive Scenario: Valid input")]
        public void HandSignGetWinnerHuman()
        {
            GetPlayerDetailsHumanWins();
            EvaluatePlayers();
            CheckWinnerPlayer1();
        }

        private void GetPlayerDetailsHumanWins()
        {
            player1 = new Player
            {
                HandSign = new HandSign
                {
                    move = Move.Rock
                },
                Name = "User"
            };

            player2 = new Player()
            {
                HandSign = new HandSign
                {
                    move = Move.Scissors
                },
                Name = "CPU"
            };
        }


        /// <summary>
        /// Handlers the with valid input positive test.
        /// </summary>
        [Fact(DisplayName = "HandSignGetWinnerCPU : Positive Scenario: Valid input")]
        public void HandSignGetWinnerCPU()
        {
            GetPlayerDetailsCPUWins();
            EvaluatePlayers();
            CheckWinnerPlayer2();
        }


        private void GetPlayerDetailsCPUWins()
        {
            player1 = new Player
            {
                HandSign = new HandSign
                {
                    move = Move.Rock
                },
                Name = "User"
            };

            player2 = new Player()
            {
                HandSign = new HandSign
                {
                    move = Move.Paper
                },
                Name = "CPU"
            };
        }


        /// <summary>
        /// Handlers the with valid input positive test.
        /// </summary>
        [Fact(DisplayName = "HandSignGetWinnerDraw : Positive Scenario: Valid input")]
        public void HandSignGetWinnerDraw()
        {
            GetPlayerDetailsDraw();
            EvaluatePlayers();
            CheckWinnerDraw();
        }

        private void GetPlayerDetailsDraw()
        {
            player1 = new Player
            {
                HandSign = new HandSign
                {
                    move = Move.Rock
                },
                Name = "User"
            };

            player2 = new Player()
            {
                HandSign = new HandSign
                {
                    move = Move.Rock
                },
                Name = "CPU"
            };
        }


        private void EvaluatePlayers()
        {
            winner = ihandSign.EvaluatePlayers(player1, player2);
        }


        /// <summary>
        /// To check the expected value -
        /// </summary>
        private void CheckWinnerPlayer1()
        {
            Assert.Equal(2, winner);
        }


        /// <summary>
        /// To check the expected value -
        /// </summary>
        private void CheckWinnerPlayer2()
        {
            Assert.Equal(1, winner);
        }

        /// <summary>
        /// To check the expected value -
        /// </summary>
        private void CheckWinnerDraw()
        {
            Assert.Equal(0, winner);
        }




    }
}
