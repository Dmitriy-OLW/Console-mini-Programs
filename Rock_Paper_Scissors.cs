using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Rock_Paper_Scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameManager gameManager = new GameManager();
            gameManager.OperatorW = () => Console.WriteLine("Вы выйграл!!!");
            gameManager.OperatorD = () => Console.WriteLine("Вы проиграли(((");
            gameManager.OperatorR = () => Console.WriteLine("Ничья, попробуй ещё раз.");

            Console.WriteLine("Это игра Rock Paper Scissors, вы можете сыграть в игру.");
            while(true)
            {
                gameManager.Play();
                Console.WriteLine("Если хотите продолжить нажмите: Enter, если хотите закончить игру напишите: 'Exit':");
                if (Console.ReadLine() == "Exit")
                {
                    break;
                }
                Console.Clear();
            }
        }
    }
    public class GameManager
    {
        public delegate void Operation();
        public Operation OperatorW;
        public Operation OperatorD;
        public Operation OperatorR;

        public string[] choise = { "Rock", "Paper", "Scissors" };
        public string playerChoice;
        public int computerChoice;

        public void Play()
        {
            Console.WriteLine("Для записи своего ответа ипользуйте: 'Rock', 'Paper', 'Scissors'");
            Console.Write("Ответ пользователя: ");
            playerChoice = Console.ReadLine();
            Console.WriteLine("");

            Random random = new Random();
            int computerChoice = random.Next(0, 3);
            if(playerChoice != "Rock" && playerChoice != "Paper" && playerChoice != "Scissors")
            {
                Console.WriteLine("Ответ игрока некоректен...");
                return;
            }
            else
            {
                Console.WriteLine("Выбор игрока: {0}, выбор компьютера: {1}", playerChoice, choise[computerChoice]);
                if (playerChoice == choise[computerChoice])
                {
                    OperatorR();
                }
                else if ((playerChoice == choise[0] && computerChoice == 2) ||
                        (playerChoice == choise[1] && computerChoice == 0) ||
                        (playerChoice == choise[2] && computerChoice == 1))
                {
                    OperatorW();
                }
                else 
                {
                    OperatorD();
                }
            }
        }
        
        /*public static void Win(string player, string computer)
        {
            Console.WriteLine("Выбор игрока: {0}, выбор компьютера: {1}", player, computer);
            Console.WriteLine("Вы выйграл!!!");
        }
        public static void Defeat(string player, string computer)
        {
            Console.WriteLine("Выбор игрока: {0}, выбор компьютера: {1}", player, computer);
            Console.WriteLine("Вы проиграли(((");
        }
        public static void Draw(string player, string computer)
        {
            Console.WriteLine("Выбор игрока: {0}, выбор компьютера: {1}", player, computer);
            Console.WriteLine("Ничья, попробуй ещё раз.");
        }*/

    }
}




