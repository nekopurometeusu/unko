using _20240530_Prac04_小野零乙;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240530_Prac04_小野零乙
{
    /// <summary>
    /// unko
    /// </summary>
    public class CoinCase
    {
        private int _coin500;
        private int _coin100;
        private int _coin50;
        private int _coin10;
        private int _coin5;
        private int _coin1;

        public CoinCase()
        {
            _coin500 = 0;
            _coin100 = 0;
            _coin50 = 0;
            _coin10 = 0;
            _coin5 = 0;
            _coin1 = 0;
        }

        public void AddCoins(int coinType, int count)
        {
            switch (coinType)
            {
                case 500:
                    _coin500 += count;
                    break;
                case 100:
                    _coin100 += count;
                    break;
                case 50:
                    _coin50 += count;
                    break;
                case 10:
                    _coin10 += count;
                    break;
                case 5:
                    _coin5 += count;
                    break;
                case 1:
                    _coin1 += count;
                    break;
                default:

                    break;
            }
        }

        public int GetCount(int coinType)
        {
            switch (coinType)
            {
                case 500:
                    return _coin500;
                case 100:
                    return _coin100;
                case 50:
                    return _coin50;
                case 10:
                    return _coin10;
                case 5:
                    return _coin5;
                case 1:
                    return _coin1;
                default:

                    return 0;
            }
        }

        public int GetAmount()
        {
            return (_coin500 * 500) + (_coin100 * 100) + (_coin50 * 50) + (_coin10 * 10) + (_coin5 * 5) + _coin1;
        }
    }

    class _20240530_Prac04_小野零乙
    {
        static void Main(string[] args)
        {
            CoinCase coinCase = new CoinCase();


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("硬貨の種類を入力してください。※500.100.50.10.5.1");
                int coinType = int.Parse(Console.ReadLine()); // 硬貨の種類を入力
                Console.WriteLine("枚数を入力してください。※10枚まで");
                int count = int.Parse(Console.ReadLine()); // 1から10までの枚数を入力
                coinCase.AddCoins(coinType, count); // コインの種類は100の倍数で表す（500, 100, 50, 10, 5, 1）
                                                    // 各硬貨の枚数を表示
                Console.WriteLine("500 yen coins: " + coinCase.GetCount(500));
                Console.WriteLine("100 yen coins: " + coinCase.GetCount(100));
                Console.WriteLine("50 yen coins: " + coinCase.GetCount(50));
                Console.WriteLine("10 yen coins: " + coinCase.GetCount(10));
                Console.WriteLine("5 yen coins: " + coinCase.GetCount(5));
                Console.WriteLine("1 yen coins: " + coinCase.GetCount(1));

                // 硬貨の総額を表示
                Console.WriteLine("Total: " + coinCase.GetAmount() + " yen");
            }
        }
    }
}