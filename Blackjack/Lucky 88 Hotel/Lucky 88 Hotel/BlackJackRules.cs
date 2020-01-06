using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Casino;

namespace Casino.BlackJack
{
    public class BlackJackRules
    {
        private static Dictionary<Card.Face, int> _cardValues = new Dictionary<Card.Face, int>()
        {
            [Card.Face.Two] = 2,
            [Card.Face.Three] = 3,
            [Card.Face.Four] = 4,
            [Card.Face.Five] = 5,
            [Card.Face.Six] = 6,
            [Card.Face.Seven] = 7,
            [Card.Face.Eight] = 8,
            [Card.Face.Nine] = 9,
            [Card.Face.Ten] = 10,
            [Card.Face.Jack] = 10,
            [Card.Face.Queen] = 10,
            [Card.Face.King] = 10,
            [Card.Face.Ace] = 1
        };
        private static int[] GetAllPossibleHandValues(List<Card> Hand)
        {
            int aceCount = Hand.Count(x => x.face == Card.Face.Ace);
            int[] result = new int[aceCount + 1];
            int value = Hand.Sum(x => _cardValues[x.face]);
            result[0] = value;
            if (result.Length == 1) return result;
            for (int i = 1; i < result.Length; i++)
            {
                value += (i * 10);
                result[i] = value;
            }
            return result;

        }
        public static bool CheckForBlackJack(List<Card> Hand)
        {
            int[] possibleValues = GetAllPossibleHandValues(Hand);
            int value = possibleValues.Max();
            if (value == 21) return true;
            else return false;
        }
        public static bool CheckForBust(List<Card> Hand)
        {
            int value = GetAllPossibleHandValues(Hand).Min();
            if (value > 21) return true;
            else return false;
        }
        public static bool ShouldDealerStay(List<Card> Hand)
        {
            int[] possibleHandValues = GetAllPossibleHandValues(Hand);
            foreach (int value in possibleHandValues)
            {
                if (value > 16 && value < 22) return true;
            }
            return false;
        }
        public static bool? CompareHands(List<Card> PlayerHand, List<Card> DealerHand)
        {
            int[] playerResults = GetAllPossibleHandValues(PlayerHand);
            int[] dealerResults = GetAllPossibleHandValues(DealerHand);
            int playerScore = playerResults.Where(x => x < 22).Max();
            int dealerScore = dealerResults.Where(x => x < 22).Max();
            if (playerScore > dealerScore) return true;
            else if (playerScore > dealerScore) return false;
            else return null;
        }
    }
}
