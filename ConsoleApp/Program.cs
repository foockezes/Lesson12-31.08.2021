using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Player bruno = new Player();
            Console.Write("Bruno Mars : ");
            bruno.StartPlay();
            Console.Write("Bruno Mars : ");
            bruno.PauseGame();
            Console.Write("Bruno Mars : ");
            bruno.StopGame();
            Console.Write("Vocal : ");
            bruno.StartRecord();
            Console.Write("Vocal : ");
            bruno.RecPause();
            Console.Write("Vocal : ");
            bruno.RecStop();
        }
    }
    interface IPlayable
    {
        void StartPlay();
        void PauseGame();
        void StopGame();
    }
    interface IRecodable
    {
        void StartRecord();
        void RecPause();
        void RecStop();
    }
    class Player : IPlayable, IRecodable
    {
        public void StartPlay()
        {
            Console.Write("Playing\n");
        }

        public void PauseGame()
        {
            Console.Write("player paused\n");
        }

        public void StopGame()
        {
            Console.Write("player stoped\n");
        }
        public void StartRecord()
        {
            Console.Write("Recording\n");
        }
        public void RecPause()
        {
            Console.Write("Recorder paused\n");
        }
        public void RecStop()
        {
            Console.Write("Recorder stoped\n");
        }
    }
}
