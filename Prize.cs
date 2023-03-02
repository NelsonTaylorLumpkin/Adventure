using System;

namespace Quest
{
    class Prize
    {
        private string _text = "Another Shiny Little Hat";
       public Prize(string text)
        {
            _text = text;
        }

        public void ShowPrize(Adventurer advName)
        {
            if (advName.Awesomeness > 0)
            {
                for(int i = 0; i < advName.Awesomeness; i++)
                Console.WriteLine(_text);
            }
            else
            {
                Console.WriteLine("You are not even the most slightly bit awesome!");
            }
        }
    }
}